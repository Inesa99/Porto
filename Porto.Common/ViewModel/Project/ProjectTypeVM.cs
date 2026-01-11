using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Common.ViewModel.Project
{
    public class ProjectTypeVM
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public IFormFile Image { get; set; }

        public string ExistingImagePath { get; set; }
    }

}
