using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NamePt { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }
    }
}
