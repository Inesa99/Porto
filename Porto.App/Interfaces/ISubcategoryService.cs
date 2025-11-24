using Porto.Common.ViewModel.Chatbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.App.Interfaces
{
    public interface ISubcategoryService
    {
        Task<List<SubcategoryViewModel>> GetByCategoryAsync(int categoryId);
        Task<List<SubcategoryViewModel>> GetAllAsync();
        Task<SubcategoryViewModel> GetByIdAsync(int id);
        Task CreateAsync(SubcategoryViewModel model);
        Task UpdateAsync(SubcategoryViewModel model);
        Task DeleteAsync(int id);
    }
}
