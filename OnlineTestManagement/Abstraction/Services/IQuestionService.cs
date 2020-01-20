using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Services
{
    public interface IQuestionService
    {
        QuestionViewModel GetQuestion();
        QuestionWrapperViewModel GetQuestionList();
        void AddQuestion(QuestionViewModel model);
        QuestionViewModel GetQuestionForEdit(int id);
        void EditQuestion(int id, QuestionViewModel model);
        QuestionViewModel GetQuestionDetails(int id);
        void DeleteQuestion(int id);
    }
}
