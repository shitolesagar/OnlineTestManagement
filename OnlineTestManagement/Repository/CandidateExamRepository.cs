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
        public int AddExam(CandidateExamModel obj)
        {
            int candidateExamId = 0;
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "INSERT INTO OnlineTestManagement.CandidateExam(StartedTime, SubmittedTime, IsTestEnded, TestId, CandidateId) " +
                   "VALUES ('" + obj.StartedTime + "', '" + obj.SubmittedTime + "', " + obj.IsTestEnded + ", " + obj.TestId + ", " + obj.CandidateId + ");select last_insert_id() ";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                connection.Open();

                //command.ExecuteNonQuery();
                // command.ExecuteNonQuery();
                candidateExamId = Convert.ToInt32(command.ExecuteScalar());

                // Call Close when done reading.
                connection.Close();
            }

            return candidateExamId;
        }
    }
}
