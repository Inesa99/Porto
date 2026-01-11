using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Required, MaxLength(1000)]
        public string Description { get; set; }

        // 🔑 Foreign Key instead of enum
        public int ProjectTypeId { get; set; }
        public ProjectType ProjectType { get; set; }

        public ProjectStatus Status { get; set; } = ProjectStatus.Pending;

        public int VotesCount { get; set; } = 0;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string CreatedByUserId { get; set; }
        public ApplicationUser CreatedByUser { get; set; }

        public ICollection<ProjectVote> Votes { get; set; }
    }
}
