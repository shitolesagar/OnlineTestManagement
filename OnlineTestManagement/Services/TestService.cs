using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Services
{
    public class TestService : ITestService
    {
        #region Services
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }
        #endregion

        #region GetTestList
        public TestWrapperViewModel GetTestList()
        {
            TestWrapperViewModel model = new TestWrapperViewModel();
            List<TestViewModel> list = _testRepository.GetAllTests();
            model.TestList = list.Select(x => new TestViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CreatedOn = x.CreatedOn,
                ModifiedOn = x.ModifiedOn,
                CreatedBy = x.CreatedBy,
                JobRoleId = x.JobRoleId
            }).ToList();
            return (model);
        }
        #endregion

        #region AddTest
        public void AddTest(TestViewModel model)
        {
            _testRepository.AddTest(model);
            return;
        }
        #endregion

        #region GetTestForEdit
        public TestViewModel GetTestForEdit(int id)
        {
            TestViewModel model = _testRepository.GetTestForEdit(id);
            return model;
        }
        #endregion

        #region EditTest
        public void EditTest(int id, TestViewModel model)
        {
            _testRepository.EditTest(id, model);
            return;
        }
        #endregion

        #region DeleteTest
        public void DeleteTest(int id)
        {
            _testRepository.DeleteTest(id);
        }
        #endregion

        #region GetTestDetails
        public TestDetailsViewModel GetTestDetails(int id)
        {
            TestDetailsViewModel model = _testRepository.GetTestDetails(id);
            return model;
        }
        #endregion
    }
}
