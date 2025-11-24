using Microsoft.EntityFrameworkCore;
using Porto.App.Interfaces;
using Porto.Common.ViewModel.Chatbot;
using Porto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.App.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationContext _context;

        public CategoryService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryViewModel>> GetAllAsync()
        {
            return await _context.Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    NameEn = c.NameEn,
                    NamePt = c.NamePt
                })
                .ToListAsync();
        }

        public async Task<CategoryViewModel> GetByIdAsync(int id)
        {
            return await _context.Categories
                .Where(c => c.Id == id)
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    NameEn = c.NameEn,
                    NamePt = c.NamePt
                })
                .FirstOrDefaultAsync();
        }

        public async Task CreateAsync(CategoryViewModel model)
        {
            var category = new Category
            {
                NameEn = model.NameEn,
                NamePt = model.NamePt
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CategoryViewModel model)
        {
            var category = await _context.Categories.FindAsync(model.Id);

            category.NameEn = model.NameEn;
            category.NamePt = model.NamePt;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);

            await _context.SaveChangesAsync();
        }
    }
}
