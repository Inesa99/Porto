using Microsoft.AspNetCore.Http;
using Porto.Common.ViewModel.Lessons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Porto.Common.ViewModel.CourseFormViewModels
{
    public class CourseFormViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public int CourseTypeId { get; set; }

        public IEnumerable<Porto.Data.Models.CourseType>? CourseTypes { get; set; }

        public IFormFile? CoverImage { get; set; }

        public string? ExistingCover { get; set; }

        public bool IsPublished { get; set; }
        public List<int> LessonIds { get; set; } = new List<int>();

        public List<LessonViewModel> Lessons { get; set; } = new List<LessonViewModel>();
    }

}
