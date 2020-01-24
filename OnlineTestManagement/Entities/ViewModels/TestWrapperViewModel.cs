using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Entities.ViewModels
{
    public class TestWrapperViewModel
    {
        public List<TestViewModel> TestList { get; set; }
    }

    public class TestViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public int JobRoleId { get; set; }
        public List<int> SelectedQuestionIds { get; set; } = new List<int>();
    }

    public class TestDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public string JobRole { get; set; }
        public List<QuestionViewModel> QuestionList { get; set; }
        public int CandidateExamId { get; set; }
    }

   
}
