using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = string.Empty;
        public string? CoverImagePath { get; set; }
        public int CourseTypeId { get; set; }
        public CourseType CourseType { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsPublished { get; set; } = false;
        public ICollection<CourseLesson> CourseLessons { get; set; } = new List<CourseLesson>();

    }

}
