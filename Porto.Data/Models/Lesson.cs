using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        public string? Description { get; set; }
        public string? MediaPath { get; set; }
        public bool IsVideo { get; set; } = true;

        public int Order { get; set; }

        public int? DurationSeconds { get; set; }
        public ICollection<CourseLesson> CourseLessons { get; set; } = new List<CourseLesson>();


    }
}
