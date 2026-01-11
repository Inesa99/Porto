using Microsoft.EntityFrameworkCore;
using Porto.App.Interfaces;
using Porto.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porto.App.Services
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationContext _db;
        public CourseService(ApplicationContext db) => _db = db;

        public async Task<List<Course>> GetAllPublishedAsync() =>
            await _db.Courses
                .Include(c => c.CourseType)
                .Include(c => c.CourseLessons)
                    .ThenInclude(cl => cl.Lesson)
                .Where(c => c.IsPublished)
                .ToListAsync();

        public async Task<Course?> GetByIdAsync(int id) =>
            await _db.Courses
                .Include(c => c.CourseType)
                .Include(c => c.CourseLessons.OrderBy(cl => cl.Lesson.Order))
                    .ThenInclude(cl => cl.Lesson)
                .FirstOrDefaultAsync(c => c.Id == id);

        public async Task CreateAsync(Course course)
        {
            _db.Courses.Add(course);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Course course)
        {
            _db.Courses.Update(course);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int courseId)
        {
            var course = await _db.Courses
                .Include(c => c.CourseLessons) 
                .FirstOrDefaultAsync(c => c.Id == courseId);

            if (course != null)
            {
                _db.CourseLessons.RemoveRange(course.CourseLessons);
                _db.Courses.Remove(course);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<List<Course>> GetByTypeAsync(int courseTypeId) =>
            await _db.Courses
                .Include(c => c.CourseLessons)
                    .ThenInclude(cl => cl.Lesson)
                .Include(c => c.CourseType)
                .Where(c => c.CourseTypeId == courseTypeId && c.IsPublished)
                .ToListAsync();
    }
}
