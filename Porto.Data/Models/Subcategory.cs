using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class Subcategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string NameEn { get; set; }
        public string NamePt { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionPt { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
