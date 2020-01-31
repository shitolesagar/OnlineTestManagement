using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Entities.ViewModels;

namespace OnlineTestManagement.Controllers
{
    public class ResultController : Controller
    {
        private readonly IResultService _resultService;
        public ResultController(IResultService resultService)
        {
            _resultService = resultService;
        }

        public IActionResult Index()
        {
            CandidateExamWrapperModel model = _resultService.GetCandidateExamList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            CandidateExamModel model = _resultService.GetCandidateExamDetails(id);
            return View(model);
        }
    }
}