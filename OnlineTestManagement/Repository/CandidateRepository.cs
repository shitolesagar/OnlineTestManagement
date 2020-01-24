using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class CandidateRepository : ICandidateRepository
    {
        #region AddCandidate
        public void AddCandidate(CandidateViewModel model)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "INSERT INTO OnlineTestManagement.Candidate(Name, EmailId, MobileNumber, Password, AppliedFor,CreatedOn, ModifiedOn, TestId) " +
                   "VALUES ('" + model.Name + "', '" + model.EmailId + "', '" + model.MobileNumber + "', '" + model.Password + "', '" + model.AppliedFor + "',@date,@date1," + model.TestId + ") ";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.Parameters.AddWithValue("@date1", DateTime.Now);
                connection.Open();

                //command.ExecuteNonQuery();
                command.ExecuteNonQuery();

                // Call Close when done reading.
                connection.Close();
            }

            return;
        }
        #endregion

        #region GetAllCandidates
        public List<CandidateViewModel> GetAllCandidates()
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            List<CandidateViewModel> model = new List<CandidateViewModel>();
            string queryString =
        "SELECT * FROM OnlineTestManagement.Candidate;";

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
                    CandidateViewModel obj = new CandidateViewModel();
                    obj.Id = (int)reader[0];
                    obj.Name = reader[1].ToString();
                    obj.EmailId = reader[2].ToString();
                    obj.MobileNumber = reader[3].ToString();
                    obj.Password = reader[4].ToString();
                    obj.AppliedFor = reader[5].ToString();
                    obj.CreatedOn = Convert.ToDateTime(reader[6]);
                    obj.ModifiedOn = Convert.ToDateTime(reader[7]);
                    obj.TestId = (int)reader[8];
                    model.Add(obj);

                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion

        #region GetCandidateForEdit
        public CandidateViewModel GetCandidateForEdit(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            CandidateViewModel model = new CandidateViewModel();
            string queryString =
        "select * from OnlineTestManagement.Candidate where id=" + id + "; ";

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
                    model.Name = reader[1].ToString();
                    model.EmailId = reader[2].ToString();
                    model.MobileNumber = reader[3].ToString();
                    model.Password = reader[4].ToString();
                    model.AppliedFor = reader[5].ToString();
                    model.CreatedOn = Convert.ToDateTime(reader[6]);
                    model.ModifiedOn = Convert.ToDateTime(reader[7]);
                    model.TestId = (int)reader[8];
                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion

        #region EditCandidate
        public void EditCandidate(int id, CandidateViewModel model)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "update OnlineTestManagement.Candidate set Name = '" + model.Name + "', EmailId = '" + model.EmailId + "', MobileNumber = '" + model.MobileNumber + "',Password = '" + model.Password + "', AppliedFor = '" + model.AppliedFor + "', ModifiedOn = @date, TestId=" + model.TestId + " where Id =" + model.Id + " ";
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

        #region GetCandidateDetails
        public CandidateDetailsViewModel GetCandidateDetails(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            CandidateDetailsViewModel model = new CandidateDetailsViewModel();
            string queryString =
        "select OnlineTestManagement.Candidate.Id, OnlineTestManagement.Candidate.Name,OnlineTestManagement.Candidate.EmailId,OnlineTestManagement.Candidate.MobileNumber,OnlineTestManagement.Candidate.Password,OnlineTestManagement.Candidate.AppliedFor, OnlineTestManagement.Test.Name as Test from (OnlineTestManagement.Candidate INNER JOIN Test ON OnlineTestManagement.Candidate.TestId = OnlineTestManagement.Test.Id) where OnlineTestManagement.Candidate.Id=" + id + " ";

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
                    model.Name = reader[1].ToString();
                    model.EmailId = reader[2].ToString();
                    model.MobileNumber = reader[3].ToString();
                    model.Password = reader[4].ToString();
                    model.AppliedFor = reader[5].ToString();
                    model.Test = reader[6].ToString();
                }
                connection.Close();

            }
            return model;
        }
        #endregion
    }
}
