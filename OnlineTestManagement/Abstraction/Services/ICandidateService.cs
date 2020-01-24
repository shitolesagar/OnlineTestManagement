using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Services
{
    public interface ICandidateService
    {
        CandidateWrapperViewModel GetCandidateList();
        void AddCandidate(CandidateViewModel model);
        CandidateViewModel GetCandidateForEdit(int id);
        void EditCandidate(int id, CandidateViewModel model);
        CandidateDetailsViewModel GetCandidateDetails(int id);
        void SendTest(int id);
        TestDetailsViewModel StartTest(string UniqueId);
    }
}
