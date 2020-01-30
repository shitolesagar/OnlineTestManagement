using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Entities.ViewModels
{
    public class CandidateExamQuestionLogModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string SelectedAnswer { get; set; }
        public bool IsAnswerCorrect { get; set; }
        public int CandidateExamId { get; set; }
        public int QuestionId { get; set; }
    }
}
