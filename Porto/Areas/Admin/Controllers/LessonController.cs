using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Porto.Common.ViewModel.Lessons;
using Porto.Data.Models;


namespace Porto.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LessonController : Controller
    {
        private readonly ApplicationContext _db;
        private readonly IWebHostEnvironment _env;

        public LessonController(ApplicationContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public async Task<IActionResult> Index(int? courseId)
        {
            var query = _db.Lessons
                .Include(l => l.CourseLessons)
                    .ThenInclude(cl => cl.Course)
                .AsQueryable();

            if (courseId.HasValue)
            {
                query = query.Where(l => l.CourseLessons.Any(cl => cl.CourseId == courseId.Value));
            }

            var lessons = await query.OrderBy(l => l.Order).ToListAsync();
            ViewBag.CourseId = courseId;

            return View(lessons);
        }

        public IActionResult Create()
        {
            var vm = new LessonViewModel();
            ViewBag.Courses = _db.Courses.ToList(); 
            return View(vm);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LessonViewModel vm)
        {
           

            var lesson = new Lesson
            {
                Title = vm.Title,
                Description = vm.Description,
                Order = vm.Order,
                DurationSeconds = vm.DurationSeconds,
                IsVideo = vm.IsVideo,
                MediaPath = await SaveFile(vm.Media)
            };

            _db.Lessons.Add(lesson);
            await _db.SaveChangesAsync();

            if (vm.CourseIds != null && vm.CourseIds.Any())
            {
                foreach (var courseId in vm.CourseIds)
                {
                    _db.CourseLessons.Add(new CourseLesson
                    {
                        CourseId = courseId,
                        LessonId = lesson.Id
                    });
                }
                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int id)
        {
            var lesson = await _db.Lessons
                .Include(l => l.CourseLessons)
                .FirstOrDefaultAsync(l => l.Id == id);

            if (lesson == null) return NotFound();

            var vm = new LessonViewModel
            {
                Id = lesson.Id,
                Title = lesson.Title,
                Description = lesson.Description,
                Order = lesson.Order,
                DurationSeconds = lesson.DurationSeconds,
                IsVideo = lesson.IsVideo,
                ExistingMediaPath = lesson.MediaPath,
                CourseIds = lesson.CourseLessons.Select(cl => cl.CourseId).ToList()
            };

            ViewBag.Courses = _db.Courses.ToList();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LessonViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Courses = _db.Courses.ToList();
                return View(vm);
            }

            var lesson = await _db.Lessons
                .Include(l => l.CourseLessons)
                .FirstOrDefaultAsync(l => l.Id == vm.Id);

            if (lesson == null) return NotFound();

            lesson.Title = vm.Title;
            lesson.Description = vm.Description;
            lesson.Order = vm.Order;
            lesson.DurationSeconds = vm.DurationSeconds;
            lesson.IsVideo = vm.IsVideo;

            if (vm.Media != null)
                lesson.MediaPath = await SaveFile(vm.Media);

            lesson.CourseLessons.Clear();
            if (vm.CourseIds != null)
            {
                foreach (var cid in vm.CourseIds)
                {
                    var course = await _db.Courses.FindAsync(cid);
                    if (course != null)
                        lesson.CourseLessons.Add(new CourseLesson { CourseId = cid, LessonId = lesson.Id });
                }
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var lesson = await _db.Lessons.FindAsync(id);
            if (lesson == null) return NotFound();

            _db.Lessons.Remove(lesson);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        private async Task<string?> SaveFile(IFormFile? file)
        {
            if (file == null || file.Length == 0) return null;

            var uploads = Path.Combine(_env.WebRootPath, "uploads");
            Directory.CreateDirectory(uploads);

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var path = Path.Combine(uploads, fileName);

            using var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);

            return "/uploads/" + fileName;
        }
    }
}
