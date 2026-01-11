using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Porto.Common.ViewModel.Page;
using Porto.Common.ViewModel.Project;
using Porto.Data.Models;
using System.Security.Claims;

namespace Porto.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProjectController(ApplicationContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        [AllowAnonymous] 
        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 6;

            var query = _context.Projects
                .Where(p => p.Status == ProjectStatus.Approved)
                .Include(p => p.ProjectType)
                .Include(p => p.CreatedByUser)
                .OrderByDescending(p => p.CreatedAt);

            var totalItems = await query.CountAsync();

            var projects = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var model = new PagedViewModel<Project>
            {
                Items = projects,
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems
            };

            ViewBag.ProjectTypes = await _context.ProjectTypes.ToListAsync();

            return View(model);
        }


        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            var model = new CreateProjectViewModel
            {
                ProjectTypes = _context.ProjectTypes
                    .Select(pt => new SelectListItem
                    {
                        Value = pt.Id.ToString(),
                        Text = pt.Name
                    })
                    .ToList()
            };
            return View(model);
        }
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProjectViewModel model)
        {

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
                return RedirectToAction("Login", "Account");
            }

            var userId = user.Id;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(); // ⬅ prevents FK crash
            }

            var project = new Project
            {
                Title = model.Title,
                Description = model.Description,
                ProjectTypeId = model.ProjectTypeId,
                CreatedByUserId = userId,
                Status = ProjectStatus.Pending,
                VotesCount = 0,
                CreatedAt = DateTime.UtcNow
            };

            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            TempData["ProjectSubmitted"] = true;
            return RedirectToAction("Index");
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Vote(int projectId)
        {
            var userId = _userManager.GetUserId(User);

            // Check if user already voted
            bool alreadyVoted = await _context.Votes
                .AnyAsync(v => v.ProjectId == projectId && v.UserId == userId);

            if (alreadyVoted)
            {
                return BadRequest("You have already voted for this project.");
            }

            var vote = new ProjectVote
            {
                ProjectId = projectId,
                UserId = userId,
                VotedAt = DateTime.UtcNow
            };

            _context.Votes.Add(vote);

            // Increment the vote count in project
            var project = await _context.Projects.FindAsync(projectId);
            project.VotesCount++;

            await _context.SaveChangesAsync();

            return Ok(new { VotesCount = project.VotesCount });
        }


    }

}
