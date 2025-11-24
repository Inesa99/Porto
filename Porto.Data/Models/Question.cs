using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int SubcategoryId { get; set; }

        public string QuestionEn { get; set; }
        public string QuestionPt { get; set; }
        public string AnswerEn { get; set; }
        public string AnswerPt { get; set; }
    }
}
