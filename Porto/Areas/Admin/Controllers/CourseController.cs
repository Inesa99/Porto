using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Porto.Common.ViewModel.CourseFormViewModels;
using Porto.Data.Models;

namespace Porto.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly ApplicationContext _db;
        private readonly IWebHostEnvironment _env;

        public CourseController(ApplicationContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await _db.Courses
                .Include(c => c.CourseType)
                .Include(c => c.CourseLessons)
                    .ThenInclude(cl => cl.Lesson)
                .ToListAsync();

            return View(courses);
        }

        public IActionResult Create()
        {
            var vm = new CourseFormViewModel
            {
                CourseTypes = _db.CourseTypes.ToList(),
                LessonIds = new List<int>()
            };
            ViewBag.Lessons = _db.Lessons.ToList(); // all lessons
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseFormViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.CourseTypes = _db.CourseTypes.ToList();
                ViewBag.Lessons = _db.Lessons.ToList();
                return View(vm);
            }

            var course = new Course
            {
                Title = vm.Title,
                ShortDescription = vm.ShortDescription,
                CourseTypeId = vm.CourseTypeId,
                IsPublished = vm.IsPublished,
                CoverImagePath = await SaveFile(vm.CoverImage)
            };

            if (vm.LessonIds != null)
            {
                foreach (var lessonId in vm.LessonIds)
                {
                    var lesson = await _db.Lessons.FindAsync(lessonId);
                    if (lesson != null)
                    {
                        course.CourseLessons.Add(new CourseLesson
                        {
                            LessonId = lesson.Id
                        });
                    }
                }
            }

            _db.Courses.Add(course);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var course = await _db.Courses
                .Include(c => c.CourseLessons)
                    .ThenInclude(cl => cl.Lesson)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null) return NotFound();

            var vm = new CourseFormViewModel
            {
                Id = course.Id,
                Title = course.Title,
                ShortDescription = course.ShortDescription,
                CourseTypeId = course.CourseTypeId,
                IsPublished = course.IsPublished,
                ExistingCover = course.CoverImagePath,
                CourseTypes = _db.CourseTypes.ToList(),
                LessonIds = course.CourseLessons.Select(cl => cl.LessonId).ToList()
            };

            ViewBag.Lessons = _db.Lessons.ToList();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CourseFormViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.CourseTypes = _db.CourseTypes.ToList();
                ViewBag.Lessons = _db.Lessons.ToList();
                return View(vm);
            }

            var course = await _db.Courses
                .Include(c => c.CourseLessons)
                .FirstOrDefaultAsync(c => c.Id == vm.Id);

            if (course == null) return NotFound();

            course.Title = vm.Title;
            course.ShortDescription = vm.ShortDescription;
            course.CourseTypeId = vm.CourseTypeId;
            course.IsPublished = vm.IsPublished;

            if (vm.CoverImage != null)
                course.CoverImagePath = await SaveFile(vm.CoverImage);

            // Update assigned lessons
            course.CourseLessons.Clear();
            if (vm.LessonIds != null)
            {
                foreach (var lessonId in vm.LessonIds)
                {
                    course.CourseLessons.Add(new CourseLesson { LessonId = lessonId });
                }
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _db.Courses
                .Include(c => c.CourseLessons)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null) return NotFound();

            _db.CourseLessons.RemoveRange(course.CourseLessons);
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<string?> SaveFile(IFormFile? file)
        {
            if (file == null || file.Length == 0) return null;

            var uploads = Path.Combine(_env.WebRootPath, "uploads");
            if (!Directory.Exists(uploads))
                Directory.CreateDirectory(uploads);

            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(uploads, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return "/uploads/" + fileName;
        }
    }
}
