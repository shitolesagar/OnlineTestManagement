using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        #region AddUser
        public void Add(ApplicationUserViewModel model)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "INSERT INTO OnlineTestManagement.ApplicationUser(Name, EmailId, MobileNumber, PasswordHash, PasswordSalt, RoleId) " +
                   "VALUES ('" + model.Name + "','" + model.EmailId + "','" + model.MobileNumber + "',@passwordhash,@passwordsalt,1) ";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@passwordhash", model.PasswordHash);
                command.Parameters.AddWithValue("@passwordsalt", model.PasswordSalt);
                connection.Open();

                command.ExecuteNonQuery();

                // Call Close when done reading.
                connection.Close();
            }

            return;
        }
        #endregion

        #region FindByEmail
        public ApplicationUserViewModel FindByEmail(string Email)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            ApplicationUserViewModel model = new ApplicationUserViewModel();
            string queryString =
        "select * from OnlineTestManagement.ApplicationUser where EmailId='" + Email + "'; ";

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
                    model.RoleId = (int)reader[6];
                    model.Password = reader[7].ToString();
                    BinaryFormatter bf = new BinaryFormatter();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bf.Serialize(ms, reader[4]);
                        model.PasswordHash =  ms.ToArray();
                    }
                    BinaryFormatter bbf = new BinaryFormatter();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bbf.Serialize(ms, reader[5]);
                        model.PasswordSalt = ms.ToArray();
                    }
                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion
    }
}
