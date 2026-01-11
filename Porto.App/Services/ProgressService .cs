using Microsoft.EntityFrameworkCore;
using Porto.App.Interfaces;
using Porto.Data.Models;

namespace Porto.App.Services
{
    public class ProgressService : IProgressService
    {
        private readonly ApplicationContext _db;
        public ProgressService(ApplicationContext db) => _db = db;

        // Mark a lesson as completed for a user
        public async Task MarkCompletedAsync(string userId, int lessonId, int courseId)
        {
            var lesson = await _db.CourseLessons
                .Include(cl => cl.Lesson)
                .FirstOrDefaultAsync(cl => cl.LessonId == lessonId && cl.CourseId == courseId);

            if (lesson == null) throw new ArgumentException("Lesson not found in this course");

            var canAccess = await CanAccessLessonAsync(userId, lessonId, courseId);
            if (!canAccess) throw new InvalidOperationException("Cannot complete this lesson before previous ones");

            var existing = await _db.UserLessonProgresses.FirstOrDefaultAsync(p => p.UserId == userId && p.LessonId == lessonId );
            if (existing == null)
            {
                _db.UserLessonProgresses.Add(new UserLessonProgress
                {
                    UserId = userId,
                    LessonId = lessonId,
                    //CourseId = courseId,
                    CompletedAt = DateTime.UtcNow
                });
                await _db.SaveChangesAsync();
            }
        }

        // Check if user has completed a lesson in a course
        public async Task<bool> HasCompletedAsync(string userId, int lessonId, int courseId) =>
            await _db.UserLessonProgresses
                     .AnyAsync(p => p.UserId == userId && p.LessonId == lessonId);

        // Get next lesson in the course by order
        public async Task<int?> GetNextLessonIdAsync(int courseId, int currentOrder)
        {
            return await _db.CourseLessons
                .Include(cl => cl.Lesson)
                .Where(cl => cl.CourseId == courseId && cl.Lesson.Order > currentOrder)
                .OrderBy(cl => cl.Lesson.Order)
                .Select(cl => (int?)cl.LessonId)
                .FirstOrDefaultAsync();
        }

        // Check if user can access lesson in a course
        public async Task<bool> CanAccessLessonAsync(string userId, int lessonId, int courseId)
        {
            var cl = await _db.CourseLessons
                .Include(cl => cl.Lesson)
                .FirstOrDefaultAsync(cl => cl.LessonId == lessonId && cl.CourseId == courseId);

            if (cl == null) return false;

            var lesson = cl.Lesson;

            // first lesson always accessible
            if (lesson.Order == 1) return true;

            // check previous lesson completed
            var prevOrder = lesson.Order - 1;

            var prevLesson = await _db.CourseLessons
                .Include(cl => cl.Lesson)
                .Where(cl => cl.CourseId == courseId)
                .FirstOrDefaultAsync(cl => cl.Lesson.Order == prevOrder);

            if (prevLesson == null) return true; // allow if missing
            return await HasCompletedAsync(userId, prevLesson.LessonId, courseId);
        }

        public Task MarkCompletedAsync(string userId, int lessonId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasCompletedAsync(string userId, int lessonId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CanAccessLessonAsync(string userId, int lessonId)
        {
            throw new NotImplementedException();
        }
    }
}
