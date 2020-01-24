using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Repository
{
    public interface ICandidateRepository
    {
        List<CandidateViewModel> GetAllCandidates();
        void AddCandidate(CandidateViewModel model);
        CandidateViewModel GetCandidateForEdit(int id);
        void EditCandidate(int id, CandidateViewModel model);
        CandidateDetailsViewModel GetCandidateDetails(int id);
    }
}
