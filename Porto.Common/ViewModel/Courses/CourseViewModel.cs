using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Common.ViewModel.CoursesVM
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required] public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = string.Empty;
        public int CourseTypeId { get; set; }
        public IFormFile? CoverImage { get; set; }
        public bool IsPublished { get; set; }
    }

}
