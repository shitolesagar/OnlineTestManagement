using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Entities.ViewModels
{
    public class CandidateExamWrapperModel
    {
        public List<CandidateExamModel> CandidateExamList { get; set; }
    }

    public class CandidateExamModel
    {
        public int Id { get; set; }
        public DateTime StartedTime { get; set; }
        public DateTime SubmittedTime { get; set; }
        public bool IsTestEnded { get; set; }
        public int TestId { get; set; }
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string TestName { get; set; }
        public string Score { get; set; }
        public int TotalNumberOfQuestions { get; set; }
        public int AttemptedQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public int WrongAnswers { get; set; }

        public List<CandidateExamQuestionLogModel> list { get; set; }
    }
}
