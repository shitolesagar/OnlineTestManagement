using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        #region GetAllSubjects
        public List<SubjectViewModel> GetAllSubjects()
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            List<SubjectViewModel> model = new List<SubjectViewModel>();
            string queryString =
        "SELECT * FROM OnlineTestManagement.Subject;";

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
                    SubjectViewModel obj = new SubjectViewModel();
                    obj.Id = (int)reader[0];
                    obj.Value = reader[1].ToString();
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
