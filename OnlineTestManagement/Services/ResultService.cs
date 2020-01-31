using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Services
{
    public class ResultService : IResultService
    {
        private readonly ICandidateExamRepository _candidateExamRepository;
        private readonly ICandidateRepository _candidateRepository;
        private readonly ITestRepository _testRepository;
        private readonly ICandidateExamQuestionLogRepository _candidateExamQuestionLogRepository;
        public ResultService(ICandidateExamQuestionLogRepository candidateExamQuestionLogRepository, ICandidateExamRepository candidateExamRepository, ICandidateRepository candidateRepository, ITestRepository testRepository)
        {
            _candidateExamRepository = candidateExamRepository;
            _candidateRepository = candidateRepository;
            _testRepository = testRepository;
            _candidateExamQuestionLogRepository = candidateExamQuestionLogRepository;
        }

        public CandidateExamModel GetCandidateExamDetails(int id)
        {
            CandidateExamModel model = new CandidateExamModel();
            model = _candidateExamRepository.GetExamDetails(id);
            CandidateDetailsViewModel candidate = _candidateRepository.GetCandidateDetails(model.CandidateId);
            model.CandidateName = candidate.Name;
            TestDetailsViewModel test = _testRepository.GetTestDetails(model.TestId);
            model.TestName = test.Name;
            List<CandidateExamQuestionLogModel> list = _candidateExamQuestionLogRepository.FindByCandidateExamId(id);
            int CorrectAnswers = 0;
            int TotalQuestions = test.QuestionList.Count();
            foreach (var obj in list)
            {
                if (obj.IsAnswerCorrect == true)
                {
                    CorrectAnswers = CorrectAnswers + 1;
                }
            }
            model.Score = CorrectAnswers + "/" + TotalQuestions;
            model.TotalNumberOfQuestions = TotalQuestions;
            model.AttemptedQuestions = list.Count();
            model.CorrectAnswers = CorrectAnswers;
            model.WrongAnswers = list.Count() - CorrectAnswers;
            return model;
        }

        public CandidateExamWrapperModel GetCandidateExamList()
        {
            CandidateExamWrapperModel model = new CandidateExamWrapperModel();
            model = _candidateExamRepository.GetAllSubmittedTests();
            foreach (var rec in model.CandidateExamList)
            {
                CandidateDetailsViewModel candidate = _candidateRepository.GetCandidateDetails(rec.CandidateId);
                rec.CandidateName = candidate.Name;
                TestDetailsViewModel test = _testRepository.GetTestDetails(rec.TestId);
                rec.TestName = test.Name;
                List<CandidateExamQuestionLogModel> list = _candidateExamQuestionLogRepository.FindByCandidateExamId(rec.Id);
                int CorrectAnswers = 0;
                int TotalQuestions = test.QuestionList.Count();
                foreach (var obj in list)
                {
                    if (obj.IsAnswerCorrect == true)
                    {
                        CorrectAnswers = CorrectAnswers + 1;
                    }
                }
                rec.Score = CorrectAnswers + "/" + TotalQuestions;
            }
            return model;
        }
    }
}
