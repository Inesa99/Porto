using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Porto.Data.Models;

namespace Porto.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProjectController : Controller
    {
        private readonly ApplicationContext _context;

        public ProjectController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var approvedProjects = await _context.Projects
              .Where(p => p.Status == ProjectStatus.Approved)  
              .Include(p => p.ProjectType)                    
              .Include(p => p.CreatedByUser)                 
              .ToListAsync();

            return View(approvedProjects);
        }
        public async Task<IActionResult> PendingProjects()
        {
            var projects = await _context.Projects
                .Where(p => p.Status == ProjectStatus.Pending)
                .Include(p => p.ProjectType) 
                .Include(p => p.CreatedByUser) 
                .ToListAsync();

            return View(projects);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Approve(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
                return NotFound();

            project.Status = ProjectStatus.Approved;
            await _context.SaveChangesAsync();

            return RedirectToAction("PendingProjects");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null) return NotFound();

            ViewBag.ProjectTypes = new SelectList(
                await _context.ProjectTypes.Where(pt => pt.IsActive).ToListAsync(),
                "Id",
                "Name",
                project.ProjectTypeId
            );

            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Project model)
        {
            if (id != model.Id)
                return BadRequest();

          

            var project = await _context.Projects.FindAsync(id);
            if (project == null)
                return NotFound();

            project.Title = model.Title;
            project.Description = model.Description;
            project.ProjectTypeId = model.ProjectTypeId;
            project.Status = model.Status;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
                return NotFound();

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }



    }
}
