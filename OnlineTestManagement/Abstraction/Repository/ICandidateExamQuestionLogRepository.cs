using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Repository
{
    public interface ICandidateExamQuestionLogRepository
    {
        void AddLog(CandidateExamQuestionLogModel model);
        void UpdateLog(CandidateExamQuestionLogModel model);
        CandidateExamQuestionLogModel FindByQuestionIdAndCandidateExamId(int QuestionId, int CandidateExamId);
    }
}
