using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class CourseType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
