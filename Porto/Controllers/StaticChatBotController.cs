using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Porto.Data.Models;

namespace Porto.Controllers
{
    public class StaticChatBotController : Controller
    {
        private readonly ApplicationContext context;
        public StaticChatBotController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetChatbotData()
        {
            var data = await context.Categories
                .Include(c => c.Subcategories)
                    .ThenInclude(s => s.Questions)
                .Select(c => new
                {
                    id = c.Id,
                    name = new
                    {
                        en = c.NameEn,
                        pt = c.NamePt
                    },
                    subcategories = c.Subcategories.Select(s => new
                    {
                        id = s.Id,
                        name = new
                        {
                            en = s.NameEn,
                            pt = s.NamePt
                        },
                        description = new
                        {
                            en = s.DescriptionEn,
                            pt = s.DescriptionPt
                        },
                        questions = s.Questions.Select(q => new
                        {
                            id = q.Id,
                            question = new
                            {
                                en = q.QuestionEn,
                                pt = q.QuestionPt
                            },
                            answer = new
                            {
                                en = q.AnswerEn,
                                pt = q.AnswerPt
                            }
                        }).ToList()
                    }).ToList()
                }).ToListAsync();

            return Json(data);
        }

    }
}
