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
        private readonly IQuestionRepository _questionRepository;
        private readonly ICandidateUniqueIdRepository _candidateUniqueIdRepository;
        private readonly ICandidateExamRepository _candidateExamRepository;
        private readonly ICandidateExamQuestionLogRepository _candidateExamQuestionLogRepository;
        private readonly ITestRepository _testRepository;
        private readonly IEmailService _emailService;

        public CandidateService(ICandidateExamQuestionLogRepository candidateExamQuestionLogRepository, IQuestionRepository questionRepository, ICandidateExamRepository candidateExamRepository, ITestRepository testRepository, IEmailService emailService, ICandidateRepository candidateRepository, ICandidateUniqueIdRepository candidateUniqueIdRepository)
        {
            _candidateRepository = candidateRepository;
            _candidateUniqueIdRepository = candidateUniqueIdRepository;
            _emailService = emailService;
            _testRepository = testRepository;
            _candidateExamRepository = candidateExamRepository;
            _candidateExamQuestionLogRepository = candidateExamQuestionLogRepository;
            _questionRepository = questionRepository;
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
            string link = "https://localhost:44311/candidate/startTest?uniqueId=" + UniqueId;
            var body = string.Format("<html><body>Hi Candidate<br /><p><a href='{0}'>Click here to start test</a></p><br />Regards<br />HR team<br />Omni-Bridge</body></html>", link);
            _emailService.SendEmail(model.EmailId,body, "Test");
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

        #region SubmitAnswer
        public void SubmitAnswer(int QuestionId, string SelectedAnswer, int CandidateExamId)
        {
            QuestionViewModel record = _questionRepository.GetQuestionForEdit(QuestionId);
            CandidateExamQuestionLogModel obj = new CandidateExamQuestionLogModel();
            obj = _candidateExamQuestionLogRepository.FindByQuestionIdAndCandidateExamId(QuestionId, CandidateExamId);
            CandidateExamQuestionLogModel model = new CandidateExamQuestionLogModel()
            {
                Question = record.Question,
                SelectedAnswer = SelectedAnswer,
                CandidateExamId = CandidateExamId,
                QuestionId = QuestionId
            };
            if (SelectedAnswer == record.CorrectAnswer)
            {
                model.IsAnswerCorrect = true;
            }
            else
            {
                model.IsAnswerCorrect = false;
            }
            if (obj.Id == 0)
            {
                _candidateExamQuestionLogRepository.AddLog(model);
            }
            else
            {
                _candidateExamQuestionLogRepository.UpdateLog(model);
            }
            return;
        }
        #endregion

        public void SubmitTest(int CandidateExamId)
        {
            _candidateExamRepository.SubmitTest(CandidateExamId);
        }
    }
}
