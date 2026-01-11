using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class ProjectType
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string ImagePath { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation
        public ICollection<Project> Projects { get; set; }
    }
    public enum ProjectStatus
    {
        Pending = 0,
        Approved = 1,
        Rejected = 2,
        InProgress = 3
    }
}
