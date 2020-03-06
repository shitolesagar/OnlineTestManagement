using OnlineTestManagement.Entities.ViewModels;
using OnlineTestManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Repository
{
    public interface ITestRepository
    {
        List<TestViewModel> GetAllTests();
        void AddTest(TestViewModel model);
        TestViewModel GetTestForEdit(int id);
        void EditTest(int id, TestViewModel model);
        void DeleteTest(int id);
        TestDetailsViewModel GetTestDetails(int id);
        TestQuestionListModel GetAllQuestionsForSubject(int SubId);
    }
}
