using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Services
{
    public class CandidateService : ICandidateService
    {
        #region Services
        private readonly ICandidateRepository _candidateRepository;
        private readonly ICandidateUniqueIdRepository _candidateUniqueIdRepository;
        private readonly ICandidateExamRepository _candidateExamRepository;
        private readonly ITestRepository _testRepository;
        private readonly IEmailService _emailService;

        public CandidateService(ICandidateExamRepository candidateExamRepository, ITestRepository testRepository, IEmailService emailService, ICandidateRepository candidateRepository, ICandidateUniqueIdRepository candidateUniqueIdRepository)
        {
            _candidateRepository = candidateRepository;
            _candidateUniqueIdRepository = candidateUniqueIdRepository;
            _emailService = emailService;
            _testRepository = testRepository;
            _candidateExamRepository = candidateExamRepository;
        }

        #endregion

        #region GetCandidateList
        public CandidateWrapperViewModel GetCandidateList()
        {
            CandidateWrapperViewModel model = new CandidateWrapperViewModel();
            List<CandidateViewModel> list = _candidateRepository.GetAllCandidates();
            model.CandidateList = list.Select(x => new CandidateViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CreatedOn = x.CreatedOn,
                ModifiedOn = x.ModifiedOn,
                EmailId = x.EmailId,
                Password = x.Password,
                MobileNumber = x.MobileNumber,
                AppliedFor = x.AppliedFor,
                TestId = x.TestId
            }).ToList();
            return (model);
        }
        #endregion

        #region AddCandidate
        public void AddCandidate(CandidateViewModel model)
        {
            _candidateRepository.AddCandidate(model);
            return;
        }
        #endregion

        #region GetCandidateForEdit
        public CandidateViewModel GetCandidateForEdit(int id)
        {
            CandidateViewModel model = _candidateRepository.GetCandidateForEdit(id);
            return model;
        }
        #endregion

        #region EditCandidate
        public void EditCandidate(int id, CandidateViewModel model)
        {
            _candidateRepository.EditCandidate(id, model);
            return;
        }
        #endregion

        #region GetCandidateDetails
        public CandidateDetailsViewModel GetCandidateDetails(int id)
        {
            CandidateDetailsViewModel model = _candidateRepository.GetCandidateDetails(id);
            return model;
        }
        #endregion

        #region SendTest
        public void SendTest(int id)
        {
            CandidateViewModel model = new CandidateViewModel();
            model = _candidateRepository.GetCandidateForEdit(id);
            string UniqueId = CreateGuid();
            _candidateUniqueIdRepository.AddUniqueId(id, UniqueId);
            _emailService.SendEmail(model.EmailId, "Test", "Test Link");
        }
        #endregion

        #region Private Methods

        #region CreateGuid
        private string CreateGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
        #endregion

        #endregion

        #region StartTest
        public TestDetailsViewModel StartTest(string UniqueId)
        {
            TestDetailsViewModel model = new TestDetailsViewModel();
            int CandidateId = _candidateUniqueIdRepository.FindCandidateId(UniqueId);
            CandidateViewModel candidate = _candidateRepository.GetCandidateForEdit(CandidateId);
            model = _testRepository.GetTestDetails(candidate.TestId);
            CandidateExamModel obj = new CandidateExamModel()
            {
                StartedTime = DateTime.Now,
                IsTestEnded = false,
                TestId = candidate.TestId,
                CandidateId = CandidateId
            };
            int candidateExamId = _candidateExamRepository.AddExam(obj);
            model.CandidateExamId = candidateExamId;
            return model;
        }
        #endregion
    }
}
