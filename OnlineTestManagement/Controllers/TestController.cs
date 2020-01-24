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
    public class TestController : Controller
    {
        #region Services
        private readonly IQuestionService _questionService;
        private readonly ITestService _testService;
        private readonly IQuestionRepository _questionRepository;
        private readonly ILevelRepository _levelRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IJobRoleRepository _jobRoleRepository;
        private readonly ITestQuestionRepository _testQuestionRepository;

        public TestController(ITestQuestionRepository testQuestionRepository, IJobRoleRepository jobRoleRepository, IQuestionService questionService, ITestService testService, IQuestionRepository questionRepository, ILevelRepository levelRepository, ISubjectRepository subjectRepository)
        {
            _questionService = questionService;
            _questionRepository = questionRepository;
            _levelRepository = levelRepository;
            _subjectRepository = subjectRepository;
            _testService = testService;
            _jobRoleRepository = jobRoleRepository;
            _testQuestionRepository = testQuestionRepository;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            TestWrapperViewModel model = new TestWrapperViewModel();
            model = _testService.GetTestList();
            return View(model);
        }
        #endregion

        #region Add
        public IActionResult Add()
        {
            List<JobRoleViewModel> list = _jobRoleRepository.GetAllJobRoles();
            List<IdNameViewModel> jobRolesList = list.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Value }).ToList();
            ViewBag.JobRolesList = jobRolesList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            List<QuestionViewModel> QueList = _questionRepository.GetAllQuestions();
            List<IdNameViewModel> QuestionList = QueList.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Question }).ToList();
            ViewBag.QuestionsList = QuestionList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            return View();
        }
        #endregion

        #region Add Test
        [HttpPost]
        public IActionResult Add(int id, TestViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            _testService.AddTest(model);
            return RedirectToAction("Add", "Test");
        }
        #endregion

        #region Edit Get Method
        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<JobRoleViewModel> list = _jobRoleRepository.GetAllJobRoles();
            List<IdNameViewModel> jobRolesList = list.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Value }).ToList();
            ViewBag.JobRolesList = jobRolesList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            List<QuestionViewModel> QueList = _questionRepository.GetAllQuestions();
            List<IdNameViewModel> QuestionList = QueList.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Question }).ToList();
            ViewBag.QuestionsList = QuestionList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            TestViewModel model = _testService.GetTestForEdit(id);
            return View(model);
        }
        #endregion

        #region Edit Post method
        [HttpPost]
        public IActionResult Edit(int id, TestViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            _testService.EditTest(id, model);
            return RedirectToAction("details", new { id });
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            TestDetailsViewModel model = _testService.GetTestDetails(id);
            return View(model);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            _testService.DeleteTest(id);
            return RedirectToAction("Index", "Test");
        }
        #endregion
    }
}