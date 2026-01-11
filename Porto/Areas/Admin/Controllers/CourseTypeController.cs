using Microsoft.AspNetCore.Mvc;

namespace Porto.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Porto.Common.ViewModel.CourseType;
    using Porto.Data.Models;

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CourseTypeController : Controller
    {
        private readonly ApplicationContext _db;

        public CourseTypeController(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _db.CourseTypes.ToListAsync());
        }

        public IActionResult Create()
        {
            return View(new CourseTypeViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseTypeViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var type = new CourseType { Name = vm.Name };
            _db.CourseTypes.Add(type);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var type = await _db.CourseTypes.FindAsync(id);
            if (type == null) return NotFound();

            return View(new CourseTypeViewModel { Id = id, Name = type.Name });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CourseTypeViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var type = await _db.CourseTypes.FindAsync(vm.Id);
            if (type == null) return NotFound();

            type.Name = vm.Name;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var type = await _db.CourseTypes.FindAsync(id);
            if (type == null) return NotFound();

            _db.CourseTypes.Remove(type);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }

}
