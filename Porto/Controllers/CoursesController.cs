using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Porto.Common.ViewModel.Page;
using Porto.Data.Models;

namespace Porto.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationContext _db;

        public CoursesController(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int? courseTypeId, int page = 1)
        {
            const int pageSize = 6;

            ViewBag.CourseTypes = await _db.CourseTypes.ToListAsync();

            var query = _db.Courses
                .Include(c => c.CourseType)
                .Include(c => c.CourseLessons)
                    .ThenInclude(cl => cl.Lesson)
                .Where(c => c.IsPublished)
                .AsQueryable();

            if (courseTypeId.HasValue)
                query = query.Where(c => c.CourseTypeId == courseTypeId.Value);

            var totalItems = await query.CountAsync();

            var courses = await query
                .OrderByDescending(c => c.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var model = new PagedViewModel<Course>
            {
                Items = courses,
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems
            };

            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var course = await _db.Courses
                .Include(c => c.CourseType)
                .Include(c => c.CourseLessons)
                    .ThenInclude(cl => cl.Lesson)
                .FirstOrDefaultAsync(c => c.Id == id && c.IsPublished);

            if (course == null) return NotFound();

            return View(course);
        }
    }
}
