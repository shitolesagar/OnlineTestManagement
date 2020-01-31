using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class CandidateExamQuestionLogRepository : ICandidateExamQuestionLogRepository
    {
        #region AddLog
        public void AddLog(CandidateExamQuestionLogModel model)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "INSERT INTO OnlineTestManagement.CandidateExamQuestionsLog(Question, SelectedAnswer, IsAnswerCorrect, CandidateExamId, QuestionId) " +
                   "VALUES ('" + model.Question + "', '" + model.SelectedAnswer + "', " + model.IsAnswerCorrect + ", " + model.CandidateExamId + ", " + model.QuestionId + ") ";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                connection.Open();

                command.ExecuteNonQuery();

                // Call Close when done reading.
                connection.Close();
            }

            return;
        }
        #endregion

        #region FindByQuestionIdAndCandidateExamId
        public CandidateExamQuestionLogModel FindByQuestionIdAndCandidateExamId(int QuestionId, int CandidateExamId)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            CandidateExamQuestionLogModel model = new CandidateExamQuestionLogModel();
            string queryString =
        "select * from OnlineTestManagement.CandidateExamQuestionsLog where QuestionId=" + QuestionId + " AND CandidateExamId=" + CandidateExamId + "; ";

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
                    model.SelectedAnswer = reader[2].ToString();
                    model.IsAnswerCorrect = (Boolean)reader[3];
                    model.CandidateExamId =(int) reader[4];
                    model.QuestionId = (int)reader[5];
                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion

        #region UpdateLog
        public void UpdateLog(CandidateExamQuestionLogModel model)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "UPDATE OnlineTestManagement.CandidateExamQuestionsLog SET SelectedAnswer = '" + model.SelectedAnswer + "', IsAnswerCorrect = " + model.IsAnswerCorrect + " WHERE QuestionId = " + model.QuestionId + " && CandidateExamId = " + model.CandidateExamId + ";";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                connection.Open();

                command.ExecuteNonQuery();

                // Call Close when done reading.
                connection.Close();
            }

            return;
        }
        #endregion

        #region FindByCandidateExamId
        public List<CandidateExamQuestionLogModel> FindByCandidateExamId(int CandidateExamId)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            List<CandidateExamQuestionLogModel> model = new List<CandidateExamQuestionLogModel>();
            string queryString =
        "select * from OnlineTestManagement.CandidateExamQuestionsLog where CandidateExamId=" + CandidateExamId + "; ";

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
                    CandidateExamQuestionLogModel obj = new CandidateExamQuestionLogModel();
                    obj.Id = (int)reader[0];
                    obj.Question = reader[1].ToString();
                    obj.SelectedAnswer = reader[2].ToString();
                    obj.IsAnswerCorrect = (Boolean)reader[3];
                    obj.CandidateExamId = (int)reader[4];
                    obj.QuestionId = (int)reader[5];
                    model.Add(obj);
                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion
    }
}
