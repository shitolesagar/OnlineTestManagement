using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Repository
{
    public interface IQuestionRepository
    {
        List<QuestionViewModel> GetAllQuestions();
        void AddQuestion(QuestionViewModel model);
        QuestionViewModel GetQuestionForEdit(int id);
        void EditQuestion(int id, QuestionViewModel model);
        QuestionDetailsViewModel GetQuestionDetails(int id);
        void DeleteQuestion(int id);
        
    }
}
