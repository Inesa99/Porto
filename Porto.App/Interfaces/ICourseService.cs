using Porto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.App.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllPublishedAsync();
        Task<Course?> GetByIdAsync(int id);
        Task CreateAsync(Course course);
        Task UpdateAsync(Course course);
        Task DeleteAsync(int courseId);
        Task<List<Course>> GetByTypeAsync(int courseTypeId);
    }

}
