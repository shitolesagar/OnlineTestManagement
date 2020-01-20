using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Entities.ViewModels;

namespace OnlineTestManagement.Controllers
{
    public class QuestionController : Controller
    {
        #region Services
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
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
            QuestionViewModel model = _questionService.GetQuestionDetails(id);
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