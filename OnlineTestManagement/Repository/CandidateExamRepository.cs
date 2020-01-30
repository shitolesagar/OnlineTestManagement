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
    }
}
