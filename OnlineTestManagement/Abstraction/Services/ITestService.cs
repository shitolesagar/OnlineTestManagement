using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Services
{
    public interface ITestService
    {
        TestWrapperViewModel GetTestList();
        void AddTest(TestViewModel model);
        TestViewModel GetTestForEdit(int id);
        void EditTest(int id, TestViewModel model);
        void DeleteTest(int id);
        TestDetailsViewModel GetTestDetails(int id);
    }
}
