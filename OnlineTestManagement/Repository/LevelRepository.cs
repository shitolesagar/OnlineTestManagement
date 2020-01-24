using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class LevelRepository : ILevelRepository
    {
        #region GetAllLevels
        public List<LevelViewModel> GetAllLevels()
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            List<LevelViewModel> model = new List<LevelViewModel>();
            string queryString =
        "SELECT * FROM OnlineTestManagement.Level;";

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
                    LevelViewModel obj = new LevelViewModel();
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
