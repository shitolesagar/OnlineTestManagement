using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Entities.ViewModels
{
    public class CandidateWrapperViewModel
    {
        public List<CandidateViewModel> CandidateList { get; set; }
    }

    public class CandidateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string AppliedFor { get; set; }
        public int TestId { get; set; }
    }

    public class CandidateDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string AppliedFor { get; set; }
        public string Test { get; set; }
    }
}
