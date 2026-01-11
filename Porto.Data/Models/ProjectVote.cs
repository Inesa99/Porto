using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class ProjectVote
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public DateTime VotedAt { get; set; } = DateTime.UtcNow;
    }

}
