using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Services
{
    public interface IResultService
    {
        CandidateExamWrapperModel GetCandidateExamList();
        CandidateExamModel GetCandidateExamDetails(int id);
    }
}
