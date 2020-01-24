using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class JobRoleRepository : IJobRoleRepository
    {
        public List<JobRoleViewModel> GetAllJobRoles()
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            List<JobRoleViewModel> model = new List<JobRoleViewModel>();
            string queryString =
        "SELECT * FROM OnlineTestManagement.JobRole;";

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
                    JobRoleViewModel obj = new JobRoleViewModel();
                    obj.Id = (int)reader[0];
                    obj.Value = reader[1].ToString();
                    obj.Description = reader[2].ToString();
                    model.Add(obj);

                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
    }
}
