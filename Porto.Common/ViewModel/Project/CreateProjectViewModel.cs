using Microsoft.AspNetCore.Mvc.Rendering;
using Porto.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Common.ViewModel.Project
{
    public class CreateProjectViewModel
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a project type")]
        public int ProjectTypeId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public IEnumerable<SelectListItem> ProjectTypes { get; set; }

    }


}
