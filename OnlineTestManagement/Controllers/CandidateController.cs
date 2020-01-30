using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Entities.ViewModels;

namespace OnlineTestManagement.Controllers
{
    public class CandidateController : Controller
    {
        #region Services
        private readonly ICandidateService _candidateService;
        private readonly ITestService _testService;
        private readonly IQuestionRepository _questionRepository;
        private readonly ICandidateRepository _candidateRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IJobRoleRepository _jobRoleRepository;
        private readonly ITestRepository _testRepository;
        private readonly ITestQuestionRepository _testQuestionRepository;

        public CandidateController(ITestQuestionRepository testQuestionRepository,ITestRepository testRepository, IJobRoleRepository jobRoleRepository, ICandidateService candidateService, ITestService testService, IQuestionRepository questionRepository, ICandidateRepository candidateRepository, ISubjectRepository subjectRepository)
        {
            _candidateService = candidateService;
            _questionRepository = questionRepository;
            _candidateRepository = candidateRepository;
            _subjectRepository = subjectRepository;
            _testService = testService;
            _jobRoleRepository = jobRoleRepository;
            _testQuestionRepository = testQuestionRepository;
            _testRepository = testRepository;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            CandidateWrapperViewModel model = new CandidateWrapperViewModel();
            model = _candidateService.GetCandidateList();
            return View(model);
        }
        #endregion

        #region Add
        public IActionResult Add()
        {
            List<TestViewModel> TesList = _testRepository.GetAllTests();
            List<IdNameViewModel> TestList = TesList.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Name }).ToList();
            ViewBag.TestsList = TestList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            return View();
        }
        #endregion

        #region Add Candidate
        [HttpPost]
        public IActionResult Add(int id, CandidateViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            _candidateService.AddCandidate(model);
            return RedirectToAction("Add", "Candidate");
        }
        #endregion

        #region Edit Get Method
        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<TestViewModel> TesList = _testRepository.GetAllTests();
            List<IdNameViewModel> TestList = TesList.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Name }).ToList();
            ViewBag.TestsList = TestList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            CandidateViewModel model = _candidateService.GetCandidateForEdit(id);
            return View(model);
        }
        #endregion

        #region Edit Post method
        [HttpPost]
        public IActionResult Edit(int id, CandidateViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            _candidateService.EditCandidate(id, model);
            return RedirectToAction("details", new { id });
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            CandidateDetailsViewModel model = _candidateService.GetCandidateDetails(id);
            return View(model);
        }
        #endregion

        #region Send Test
        public IActionResult SendTest(int id)
        {
            _candidateService.SendTest(id);
            return RedirectToAction("Index", "Candidate");
        }
        #endregion

        #region Start Test
        public IActionResult StartTest(string UniqueId)
        {
            TestDetailsViewModel model = new TestDetailsViewModel();
            model = _candidateService.StartTest(UniqueId);
            return View(model);
        }
        #endregion

        #region SubmitAnswer
        public void SubmitAnswer(int QuestionId, string SelectedAnswer, int CandidateExamId)
        {
            _candidateService.SubmitAnswer(QuestionId, SelectedAnswer, CandidateExamId);
        }

        #endregion

        #region Submit Test
        public IActionResult SubmitTest(int CandidateExamId)
        {
            _candidateService.SubmitTest(CandidateExamId);
            return RedirectToAction("Index", "Candidate");
        }
        #endregion
    }
}