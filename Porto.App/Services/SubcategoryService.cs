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
    public class SubcategoryService : ISubcategoryService
    {
        private readonly ApplicationContext _context;

        public SubcategoryService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<SubcategoryViewModel>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Subcategories
                .Where(s => s.CategoryId == categoryId)
                .Select(s => new SubcategoryViewModel
                {
                    Id = s.Id,
                    CategoryId = s.CategoryId,
                    NameEn = s.NameEn,
                    NamePt = s.NamePt,
                    DescriptionEn = s.DescriptionEn,
                    DescriptionPt = s.DescriptionPt
                })
                .ToListAsync();
        }

        public async Task<SubcategoryViewModel> GetByIdAsync(int id)
        {
            return await _context.Subcategories
                .Where(s => s.Id == id)
                .Select(s => new SubcategoryViewModel
                {
                    Id = s.Id,
                    CategoryId = s.CategoryId,
                    NameEn = s.NameEn,
                    NamePt = s.NamePt,
                    DescriptionEn = s.DescriptionEn,
                    DescriptionPt = s.DescriptionPt
                })
                .FirstOrDefaultAsync();
        }

        public async Task CreateAsync(SubcategoryViewModel model)
        {
            var entity = new Subcategory
            {
                CategoryId = model.CategoryId,
                NameEn = model.NameEn,
                NamePt = model.NamePt,
                DescriptionEn = model.DescriptionEn,
                DescriptionPt = model.DescriptionPt
            };

            _context.Subcategories.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SubcategoryViewModel model)
        {
            var entity = await _context.Subcategories.FindAsync(model.Id);

            entity.NameEn = model.NameEn;
            entity.NamePt = model.NamePt;
            entity.DescriptionEn = model.DescriptionEn;
            entity.DescriptionPt = model.DescriptionPt;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Subcategories.FindAsync(id);
            _context.Subcategories.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SubcategoryViewModel>> GetAllAsync()
        {
            return await _context.Subcategories
                .Select(s => new SubcategoryViewModel
                {
                    Id = s.Id,
                    CategoryId = s.CategoryId,
                    NameEn = s.NameEn,
                    NamePt = s.NamePt,
                    DescriptionEn = s.DescriptionEn,
                    DescriptionPt = s.DescriptionPt,
                })
                .ToListAsync();
        }
    }

}
