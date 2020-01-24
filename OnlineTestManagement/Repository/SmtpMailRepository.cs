using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class SmtpMailRepository : ISmtpMailRepository
    {
        #region GetMailInfo
        public SmtpModel GetMailInfo()
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            SmtpModel model = new SmtpModel();
            string queryString =
        "SELECT * FROM OnlineTestManagement.SmtpMail;";

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
                    model.FromMail = reader[1].ToString();
                    model.SmtpPassword = reader[2].ToString();
                    model.Host = reader[3].ToString();
                    model.Port = reader[4].ToString();
                    model.DisplayName = reader[5].ToString();
                    model.Description = reader[6].ToString();
                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion
    }
}
