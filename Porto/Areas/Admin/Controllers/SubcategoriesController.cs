using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Porto.App.Interfaces;
using Porto.Common.ViewModel.Chatbot;
using System.Threading.Tasks;

namespace Porto.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubcategoriesController : Controller
    {
        private readonly ISubcategoryService _subcategoryService;
        private readonly ICategoryService _categoryService; 

        public SubcategoriesController(
            ISubcategoryService subcategoryService,
            ICategoryService categoryService)
        {
            _subcategoryService = subcategoryService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(int? categoryId)
        {
            List<SubcategoryViewModel> list;

            if (categoryId.HasValue && categoryId.Value > 0)
                list = await _subcategoryService.GetByCategoryAsync(categoryId.Value);
            else
                list = await _subcategoryService.GetAllAsync();

            return View(list);
        }


        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync(); 
            ViewBag.Categories = new SelectList(categories, "Id", "NameEn"); 
            return View(new SubcategoryViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubcategoryViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            await _subcategoryService.CreateAsync(model);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var vm = await _subcategoryService.GetByIdAsync(id);
            if (vm == null)
                return NotFound();

            var categories = await _categoryService.GetAllAsync();
            ViewBag.Categories = new SelectList(categories, "Id", "NameEn", vm.CategoryId);

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SubcategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var categories = await _categoryService.GetAllAsync();
                ViewBag.Categories = new SelectList(categories, "Id", "NameEn", model.CategoryId);
                return View(model);
            }

            await _subcategoryService.UpdateAsync(model);

            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id, int categoryId)
        {
            await _subcategoryService.DeleteAsync(id);

            return RedirectToAction("Index", new { categoryId });
        }
    }
}
