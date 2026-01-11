
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Porto.Data.Models;


namespace Porto.Data.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<BotMessage> BotMessages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectVote> Votes { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<CourseLesson> CourseLessons { get; set; }

        public DbSet<UserLessonProgress> UserLessonProgresses { get; set; }
        //public DbSet<ApplicationUser> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProjectVote>()
                .HasIndex(v => new { v.ProjectId, v.UserId })
                .IsUnique();

            builder.Entity<ProjectVote>()
                .HasOne(v => v.User)
                .WithMany()
                .HasForeignKey(v => v.UserId)
                .OnDelete(DeleteBehavior.Restrict); // 🚨 IMPORTANT

            builder.Entity<ProjectVote>()
                .HasOne(v => v.Project)
                .WithMany(p => p.Votes)
                .HasForeignKey(v => v.ProjectId)
                .OnDelete(DeleteBehavior.Cascade); // OK
        }

    }
}
