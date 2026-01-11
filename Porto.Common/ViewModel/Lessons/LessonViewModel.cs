using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Porto.Common.ViewModel.Lessons
{
    public class LessonViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public IFormFile? Media { get; set; }

        public bool IsVideo { get; set; } = true;

        public int Order { get; set; }

        public int? DurationSeconds { get; set; }

        public string? ExistingMediaPath { get; set; }

        // New: select multiple courses
        public List<int> CourseIds { get; set; } = new List<int>();
    }
}
