using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using OnlineTestManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        #region AddQuestion
        public void AddQuestion(QuestionViewModel model)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "INSERT INTO OnlineTestManagement.Question(Question, Option1, Option2, Option3, Option4, CorrectAnswer, CreatedOn, ModifiedOn, CreatedBy, LevelId, SubjectId) " + 
                   "VALUES ('"+model.Question+"','"+model.Option1+"','"+model.Option2+"','"+model.Option3+"','"+model.Option4+"','"+model.CorrectAnswer+"',@date,@date1,'"+model.CreatedBy+"',"+model.LevelId+","+model.SubjectId+") ";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@date",DateTime.Now );
                command.Parameters.AddWithValue("@date1", DateTime.Now);
                connection.Open();

                command.ExecuteNonQuery();

                // Call Close when done reading.
                connection.Close();
            }

            return;
        }
        #endregion

        #region DeleteQuestion
        public void DeleteQuestion(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "update OnlineTestManagement.Question set IsDeleted = true where Id =" + id + " ";

            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                connection.Open();

                command.ExecuteNonQuery();

                // Call Read before accessing data.


                // Call Close when done reading.
                connection.Close();
            }

            return;
        }
        #endregion

        #region EditQuestion
        public void EditQuestion(int id, QuestionViewModel model)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "update OnlineTestManagement.Question set Question = '"+model.Question+"', Option1 = '"+model.Option1+"', Option2 = '"+model.Option2+"',Option3='"+model.Option3+"',Option4='"+model.Option4+"',CorrectAnswer='"+model.CorrectAnswer+"',CreatedBy='"+model.CreatedBy+"',ModifiedOn=@date,LevelId="+model.LevelId+",SubjectId="+model.SubjectId+" where Id ="+model.Id+" ";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                connection.Open();

                command.ExecuteNonQuery();

                // Call Close when done reading.
                connection.Close();
            }

            return;
        }
        #endregion

        #region GetAllQuestions
        public List<QuestionViewModel> GetAllQuestions()
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            List<QuestionViewModel> model = new List<QuestionViewModel>();
            string queryString =
        "SELECT * FROM OnlineTestManagement.Question where OnlineTestManagement.Question.IsDeleted=false";

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
                    QuestionViewModel obj = new QuestionViewModel();
                    obj.Id = (int)reader[0];
                    obj.Question = reader[1].ToString();
                    obj.CreatedBy = reader[9].ToString();
                    model.Add(obj);
                    
                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion

        #region GetQuestionDetails
        public QuestionDetailsViewModel GetQuestionDetails(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            QuestionDetailsViewModel model = new QuestionDetailsViewModel();
            string queryString =
        "select OnlineTestManagement.Question.Id, OnlineTestManagement.Question.Question,OnlineTestManagement.Question.Option1,OnlineTestManagement.Question.Option2,OnlineTestManagement.Question.Option3,OnlineTestManagement.Question.Option4,OnlineTestManagement.Question.CorrectAnswer,OnlineTestManagement.Question.CreatedOn,OnlineTestManagement.Question.ModifiedOn,OnlineTestManagement.Question.CreatedBy, OnlineTestManagement.Level.Value as Level,OnlineTestManagement.Subject.Value as Subject  from ((OnlineTestManagement.Question INNER JOIN Level ON OnlineTestManagement.Question.LevelId = OnlineTestManagement.Level.Id)INNER JOIN Subject ON OnlineTestManagement.Question.SubjectId = OnlineTestManagement.Subject.Id) where OnlineTestManagement.Question.Id=" + id + " ";

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
                    model.Id = (int)reader[0];
                    model.Question = reader[1].ToString();
                    model.Option1 = reader[2].ToString();
                    model.Option2 = reader[3].ToString();
                    model.Option3 = reader[4].ToString();
                    model.Option4 = reader[5].ToString();
                    model.CorrectAnswer = reader[6].ToString();
                    model.CreatedOn = Convert.ToDateTime(reader[7]);
                    model.ModifiedOn = Convert.ToDateTime(reader[8]);
                    model.CreatedBy = reader[9].ToString();
                    model.Level = reader[10].ToString();
                    model.Subject = reader[11].ToString();

                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion

        #region GetQuestionForEdit
        public QuestionViewModel GetQuestionForEdit(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            QuestionViewModel model = new QuestionViewModel();
            string queryString =
        "select * from OnlineTestManagement.Question where id=" + id+"; ";

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
                    model.Id = (int)reader[0];
                    model.Question = reader[1].ToString();
                    model.Option1 = reader[2].ToString();
                    model.Option2 = reader[3].ToString();
                    model.Option3 = reader[4].ToString();
                    model.Option4 = reader[5].ToString();
                    model.CorrectAnswer = reader[6].ToString();
                    model.CreatedOn =Convert.ToDateTime (reader[7]);
                    model.ModifiedOn = Convert.ToDateTime (reader[8]);
                    model.CreatedBy = reader[9].ToString();
                    model.LevelId = (int)reader[10];
                    model.SubjectId =(int) reader[11];

                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion

        #region GetAllQuestionsForSubject
        public TestQuestionListModel GetAllQuestionsForSubject(int SubId)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            TestQuestionListModel model = new TestQuestionListModel();
            model.QuestionList = new List<Question>();
            string queryString =
        "SELECT Id, Question FROM OnlineTestManagement.Question where SubjectId=" + SubId + ";";

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
                    Question obj = new Question();
                    obj.Id = (int)reader[0];
                    obj.Text = reader[1].ToString();
                    model.QuestionList.Add(obj);

                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion
    }
}
