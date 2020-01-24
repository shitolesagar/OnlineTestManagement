using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Entities.ViewModels
{
    public class QuestionWrapperViewModel
    {
        public List<QuestionViewModel> QuestionList { get; set; }
    }

    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectAnswer { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public int LevelId { get; set; }
        public int SubjectId { get; set; }
    }

    public class QuestionDetailsViewModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectAnswer { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Level { get; set; }
        public string Subject { get; set; }
    }
}
