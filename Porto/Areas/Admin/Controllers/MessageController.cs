using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Porto.Data.Models;

namespace Porto.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MessageController : Controller
    {
        private readonly ApplicationContext _context;

        public MessageController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var messages = await _context.ChatMessages
               .Include(m => m.User)
               .OrderBy(m => m.Timestamp)
               .ToListAsync();

            return View(messages);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var message = await _context.ChatMessages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }
            _context.ChatMessages.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
