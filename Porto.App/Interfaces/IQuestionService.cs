using Microsoft.EntityFrameworkCore;
using Porto.Common.ViewModel.Chatbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.App.Interfaces
{
    public interface IQuestionService
    {
        Task<List<QuestionViewModel>> GetBySubcategoryAsync(int subcategoryId);
        Task<QuestionViewModel> GetByIdAsync(int id);
        Task CreateAsync(QuestionViewModel model);
        Task UpdateAsync(QuestionViewModel model);
        Task DeleteAsync(int id);
        Task<List<QuestionViewModel>> GetAllAsync();
        
    }
}
