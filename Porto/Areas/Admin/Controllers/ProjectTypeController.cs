using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Porto.Common.ViewModel.Project;
using Porto.Data.Models;

namespace Porto.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProjectTypeController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment _env;


        public ProjectTypeController(ApplicationContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectTypes.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectTypeVM model)
        {
          

            string imagePath = null;

            if (model.Image != null)
            {
                imagePath = await SaveImage(model.Image);
            }

            var projectType = new ProjectType
            {
                Name = model.Name,
                IsActive = model.IsActive,
                ImagePath = imagePath
            };

            _context.ProjectTypes.Add(projectType);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var projectType = await _context.ProjectTypes.FindAsync(id);
            if (projectType == null)
                return NotFound();

            var vm = new ProjectTypeVM
            {
                Id = projectType.Id,
                Name = projectType.Name,
                IsActive = projectType.IsActive,
                ExistingImagePath = projectType.ImagePath
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProjectTypeVM model)
        {
            if (id != model.Id)
                return BadRequest();

           
            var projectType = await _context.ProjectTypes.FindAsync(id);
            if (projectType == null)
                return NotFound();

            projectType.Name = model.Name;
            projectType.IsActive = model.IsActive;

            if (model.Image != null)
            {
                if (!string.IsNullOrEmpty(projectType.ImagePath))
                {
                    DeleteImage(projectType.ImagePath);
                }

                projectType.ImagePath = await SaveImage(model.Image);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        private async Task<string> SaveImage(IFormFile image)
        {
            string folder = Path.Combine(_env.WebRootPath, "uploads", "project-types");
            Directory.CreateDirectory(folder);

            string fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);
            string filePath = Path.Combine(folder, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return $"/uploads/project-types/{fileName}";
        }


        private void DeleteImage(string imagePath)
        {

            var fullPath = Path.Combine(_env.WebRootPath, imagePath.TrimStart('/'));
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Toggle(int id)
        {
            var projectType = await _context.ProjectTypes.FindAsync(id);
            if (projectType == null)
                return NotFound();

            projectType.IsActive = !projectType.IsActive;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var projectType = await _context.ProjectTypes
                .Include(pt => pt.Projects)
                .FirstOrDefaultAsync(pt => pt.Id == id);

            if (projectType == null)
                return NotFound();

            if (projectType.Projects.Any())
            {
                ModelState.AddModelError("", "Cannot delete a project type that has projects.");
                return RedirectToAction(nameof(Index));
            }

            _context.ProjectTypes.Remove(projectType);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
