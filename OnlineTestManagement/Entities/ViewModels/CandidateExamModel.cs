using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Entities.ViewModels
{
    public class CandidateExamModel
    {
        public int Id { get; set; }
        public DateTime StartedTime { get; set; }
        public DateTime SubmittedTime { get; set; }
        public bool IsTestEnded { get; set; }
        public int TestId { get; set; }
        public int CandidateId { get; set; }
    }
}
