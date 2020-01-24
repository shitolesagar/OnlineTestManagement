using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Repository
{
    public interface ICandidateUniqueIdRepository
    {
        void AddUniqueId(int CandidateId, string UniqueId);
        int FindCandidateId(string UniqueId);
    }
}
