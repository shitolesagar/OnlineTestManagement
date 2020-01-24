using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Services
{
    public class QuestionService : IQuestionService
    {
        #region Services
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        #endregion

        #region GetQuestion
        public QuestionViewModel GetQuestion()
        {
            string result = null;
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            QuestionViewModel model = new QuestionViewModel();
            string queryString =
        "SELECT Question, Option1 FROM OnlineTestManagement.Question Where Id=1;";

            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    result = reader[0].ToString();
                    string option1 = reader[1].ToString();
                    //Console.WriteLine(String.Format("{0}, {1}",
                    //    reader[0], reader[1]));
                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion

        #region GetQuestionList
        public QuestionWrapperViewModel GetQuestionList()
        {
            QuestionWrapperViewModel model = new QuestionWrapperViewModel();
            List<QuestionViewModel> list = _questionRepository.GetAllQuestions();
            model.QuestionList = list.Select(x => new QuestionViewModel
            {
                Id = x.Id,
                Question = x.Question,
                Option1 = x.Option1,
                Option2 = x.Option2,
                Option3 = x.Option3,
                Option4 = x.Option4,
                CorrectAnswer = x.CorrectAnswer,
                CreatedOn = x.CreatedOn,
                ModifiedOn = x.ModifiedOn,
                CreatedBy = x.CreatedBy
            }).ToList();
            return (model);
        }
        #endregion

        #region AddQuestion
        public void AddQuestion(QuestionViewModel model)
        {
            _questionRepository.AddQuestion(model);
            return;
        }
        #endregion

        #region GetQuestionForEdit
        public QuestionViewModel GetQuestionForEdit(int id)
        {
            QuestionViewModel model = _questionRepository.GetQuestionForEdit(id);
            return model;
        }
        #endregion

        #region EditQuestion
        public void EditQuestion(int id, QuestionViewModel model)
        {
            _questionRepository.EditQuestion(id, model);
            return;
        }
        #endregion

        #region GetQuestionDetails
        public QuestionDetailsViewModel GetQuestionDetails(int id)
        {
            QuestionDetailsViewModel model = _questionRepository.GetQuestionDetails(id);
            return model;
        }
        #endregion

        #region DeleteQuestion
        public void DeleteQuestion(int id)
        {
            _questionRepository.DeleteQuestion(id);
        }
        #endregion
    }
}
