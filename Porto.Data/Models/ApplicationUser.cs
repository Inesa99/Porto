using Microsoft.AspNetCore.Identity;

namespace Porto.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ChatMessage> Messages { get; set; }
        public ICollection<UserLessonProgress> LessonProgresses { get; set; } = new List<UserLessonProgress>();


    }

}
