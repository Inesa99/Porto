using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Porto.App.Interfaces;
using Porto.Common.ViewModel.Chatbot;

namespace Porto.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly ISubcategoryService _subcategoryService;

        public QuestionsController(IQuestionService questionService, ISubcategoryService subcategoryService)
        {
            _questionService = questionService;
            _subcategoryService = subcategoryService;
        }

        public async Task<IActionResult> Index(int? subcategoryId)
        {
            var list = subcategoryId.HasValue
                ? await _questionService.GetBySubcategoryAsync(subcategoryId.Value)
                : await _questionService.GetAllAsync(); 

            ViewBag.SubcategoryId = subcategoryId;
            return View(list);
        }


        public async Task<IActionResult> Create()
        {
            var subcategories = await _subcategoryService.GetAllAsync();
            ViewBag.Subcategories = new SelectList(subcategories, "Id", "NameEn");

            return View(new QuestionViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(QuestionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var subcategories = await _subcategoryService.GetAllAsync();
                ViewBag.Subcategories = new SelectList(subcategories, "Id", "NameEn", model.SubcategoryId);
                return View(model);
            }

            await _questionService.CreateAsync(model);
            return RedirectToAction("Index", new { subcategoryId = model.SubcategoryId });
        }

        public async Task<IActionResult> Edit(int id)
        {
            var vm = await _questionService.GetByIdAsync(id);
            if (vm == null)
                return NotFound();

            var subcategories = await _subcategoryService.GetAllAsync();
            ViewBag.Subcategories = new SelectList(subcategories, "Id", "NameEn", vm.SubcategoryId);

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(QuestionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var subcategories = await _subcategoryService.GetAllAsync();
                ViewBag.Subcategories = new SelectList(subcategories, "Id", "NameEn", model.SubcategoryId);
                return View(model);
            }

            await _questionService.UpdateAsync(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, int subcategoryId)
        {
            await _questionService.DeleteAsync(id);
            return RedirectToAction("Index", new { subcategoryId });
        }
    }

}
