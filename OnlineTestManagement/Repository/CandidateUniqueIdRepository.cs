using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class CandidateUniqueIdRepository : ICandidateUniqueIdRepository
    {
        #region AddUniqueId
        public void AddUniqueId(int CandidateId, string UniqueId)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "INSERT INTO OnlineTestManagement.CandidateUniqueId(CandidateId, UniqueId) " +
                   "VALUES (" + CandidateId + ",'" + UniqueId + "') ";
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

        #region FindCandidateId
        public int FindCandidateId(string UniqueId)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            int UniqId = 0;
            string queryString =
        "select CandidateId from OnlineTestManagement.CandidateUniqueId where UniqueId='" + UniqueId + "'; ";

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
                    UniqId = (int)reader[0];
                }

                // Call Close when done reading.
                connection.Close();
            }

            return UniqId;
        }
        #endregion
    }
}
