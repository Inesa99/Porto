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
    public class QuestionService : IQuestionService
    {
        private readonly ApplicationContext _context;

        public QuestionService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<QuestionViewModel>> GetBySubcategoryAsync(int subcategoryId)
        {
            return await _context.Questions
                .Where(q => q.SubcategoryId == subcategoryId)
                .Select(q => new QuestionViewModel
                {
                    Id = q.Id,
                    SubcategoryId = q.SubcategoryId,
                    QuestionEn = q.QuestionEn,
                    QuestionPt = q.QuestionPt,
                    AnswerEn = q.AnswerEn,
                    AnswerPt = q.AnswerPt
                })
                .ToListAsync();
        }

        public async Task<QuestionViewModel> GetByIdAsync(int id)
        {
            return await _context.Questions
                .Where(q => q.Id == id)
                .Select(q => new QuestionViewModel
                {
                    Id = q.Id,
                    SubcategoryId = q.SubcategoryId,
                    QuestionEn = q.QuestionEn,
                    QuestionPt = q.QuestionPt,
                    AnswerEn = q.AnswerEn,
                    AnswerPt = q.AnswerPt
                })
                .FirstOrDefaultAsync();
        }

        public async Task CreateAsync(QuestionViewModel model)
        {
            var entity = new Question
            {
                SubcategoryId = model.SubcategoryId,
                QuestionEn = model.QuestionEn,
                QuestionPt = model.QuestionPt,
                AnswerEn = model.AnswerEn,
                AnswerPt = model.AnswerPt
            };

            _context.Questions.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(QuestionViewModel model)
        {
            var entity = await _context.Questions.FindAsync(model.Id);

            entity.QuestionEn = model.QuestionEn;
            entity.QuestionPt = model.QuestionPt;
            entity.AnswerEn = model.AnswerEn;
            entity.AnswerPt = model.AnswerPt;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<List<QuestionViewModel>> GetAllAsync()
        {
            return await _context.Questions
                .Select(q => new QuestionViewModel
                {
                    Id = q.Id,
                    SubcategoryId = q.SubcategoryId,
                    QuestionEn = q.QuestionEn,
                    QuestionPt = q.QuestionPt,
                    AnswerEn = q.AnswerEn,
                    AnswerPt = q.AnswerPt
                })
                .ToListAsync();
        }

    }

}
