using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.App.Interfaces
{
    public interface IProgressService
    {
        Task MarkCompletedAsync(string userId, int lessonId);
        Task<bool> HasCompletedAsync(string userId, int lessonId);
        Task<int?> GetNextLessonIdAsync(int courseId, int currentOrder);
        Task<bool> CanAccessLessonAsync(string userId, int lessonId);
    }

}
