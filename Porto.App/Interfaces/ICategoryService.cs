using Porto.Common.ViewModel.Chatbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.App.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAllAsync();
        Task<CategoryViewModel> GetByIdAsync(int id);
        Task CreateAsync(CategoryViewModel model);
        Task UpdateAsync(CategoryViewModel model);
        Task DeleteAsync(int id);
    }
}
