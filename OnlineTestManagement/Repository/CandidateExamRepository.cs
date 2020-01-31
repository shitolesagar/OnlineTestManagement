using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class CandidateExamRepository : ICandidateExamRepository
    {
        #region AddExam
        public int AddExam(CandidateExamModel obj)
        {
            int candidateExamId = 0;
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "INSERT INTO OnlineTestManagement.CandidateExam(StartedTime, SubmittedTime, IsTestEnded, TestId, CandidateId) " +
                   "VALUES (@date, @date1, " + obj.IsTestEnded + ", " + obj.TestId + ", " + obj.CandidateId + ");select last_insert_id() ";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@date", obj.StartedTime);
                command.Parameters.AddWithValue("@date1", obj.SubmittedTime);
                connection.Open();

                //command.ExecuteNonQuery();
                // command.ExecuteNonQuery();
                candidateExamId = Convert.ToInt32(command.ExecuteScalar());

                // Call Close when done reading.
                connection.Close();
            }

            return candidateExamId;
        }
        #endregion

        #region SubmitTest
        public void SubmitTest(int CandidateExamId)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "update OnlineTestManagement.CandidateExam set SubmittedTime = @date, IsTestEnded = true where Id =" + CandidateExamId + " ";
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
        }
        #endregion

        #region GetAllSubmittedTests
        public CandidateExamWrapperModel GetAllSubmittedTests()
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string querryString = "select * from OnlineTestManagement.CandidateExam where IsTestEnded = true";
            CandidateExamWrapperModel model = new CandidateExamWrapperModel();
            model.CandidateExamList = new List<CandidateExamModel>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(querryString, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    CandidateExamModel obj = new CandidateExamModel();
                    obj.Id = (int)reader[0];
                    obj.StartedTime = (DateTime)reader[1];
                    obj.SubmittedTime = (DateTime)reader[2];
                    obj.IsTestEnded =(bool) reader[3];
                    obj.TestId = (int)reader[4];
                    obj.CandidateId = (int)reader[5];
                    model.CandidateExamList.Add(obj);
                }
                connection.Close();
            }
            return model;
        }
        #endregion

        #region GetExamDetails
        public CandidateExamModel GetExamDetails(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string querryString = "select * from OnlineTestManagement.CandidateExam where Id = "+id+"";
            CandidateExamModel model = new CandidateExamModel();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(querryString, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    model.Id = (int)reader[0];
                    model.StartedTime = (DateTime)reader[1];
                    model.SubmittedTime = (DateTime)reader[2];
                    model.IsTestEnded = (bool)reader[3];
                    model.TestId = (int)reader[4];
                    model.CandidateId = (int)reader[5];
                }
                connection.Close();
            }
            return model;
        }
        #endregion

    }
}
