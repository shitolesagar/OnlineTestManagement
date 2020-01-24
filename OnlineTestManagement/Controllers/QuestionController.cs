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
    public class QuestionController : Controller
    {
        #region Services
        private readonly IQuestionService _questionService;
        private readonly IQuestionRepository _questionRepository;
        private readonly ILevelRepository _levelRepository;
        private readonly ISubjectRepository _subjectRepository;

        public QuestionController(IQuestionService questionService, IQuestionRepository questionRepository, ILevelRepository levelRepository, ISubjectRepository subjectRepository)
        {
            _questionService = questionService;
            _questionRepository = questionRepository;
            _levelRepository = levelRepository;
            _subjectRepository = subjectRepository;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            QuestionWrapperViewModel model = new QuestionWrapperViewModel();
            model = _questionService.GetQuestionList();
            return View(model);
        }
        #endregion

        #region Add
        public IActionResult Add()
        {
            List<LevelViewModel> list = _levelRepository.GetAllLevels();
            List<IdNameViewModel> levelsList = list.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Value }).ToList();
            ViewBag.LevelsList = levelsList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            List<SubjectViewModel> SubList = _subjectRepository.GetAllSubjects();
            List<IdNameViewModel> SubjectsList = SubList.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Value }).ToList();
            ViewBag.SubjectsList = SubjectsList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            return View();
        }
        #endregion

        #region Add Question
        [HttpPost]
        public IActionResult Add(int id, QuestionViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            _questionService.AddQuestion(model);
            return RedirectToAction("Add", "Question");
        }
        #endregion

        #region Edit Get Method
        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<LevelViewModel> list = _levelRepository.GetAllLevels();
            List<IdNameViewModel> levelsList = list.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Value }).ToList();
            ViewBag.LevelsList = levelsList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            List<SubjectViewModel> SubList = _subjectRepository.GetAllSubjects();
            List<IdNameViewModel> SubjectsList = SubList.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Value }).ToList();
            ViewBag.SubjectsList = SubjectsList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });

            QuestionViewModel model = _questionService.GetQuestionForEdit(id);
            return View(model);
        }
        #endregion

        #region Edit Post method
        [HttpPost]
        public IActionResult Edit(int id, QuestionViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            _questionService.EditQuestion(id, model);
            return RedirectToAction("details", new { id });
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            QuestionDetailsViewModel model = _questionService.GetQuestionDetails(id);
            return View(model);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            _questionService.DeleteQuestion(id);
            return RedirectToAction("Index", "Question");
        }
        #endregion
    }
}