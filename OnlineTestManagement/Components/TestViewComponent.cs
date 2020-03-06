using Microsoft.AspNetCore.Mvc;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Components
{
    public class TestViewComponent : ViewComponent
    {
        private readonly ITestService _testService;

        public TestViewComponent(ITestService testService)
        {
            _testService = testService;
        }
        public  IViewComponentResult InvokeAsync(int SubId, bool IsPartial)
        {
            TestQuestionListModel ResponseModel =  _testService.GetAllQuestionsForSubject(SubId);
            ViewBag.ShowEmptyState = !IsPartial;
            return View(ResponseModel);
        }
    }
}
