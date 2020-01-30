using MySql.Data.MySqlClient;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Repository
{
    public class TestRepository : ITestRepository
    {
        #region AddTest
        public void AddTest(TestViewModel model)
        {
            int recordId = 0;
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "INSERT INTO OnlineTestManagement.Test(Name, CreatedOn, ModifiedOn, CreatedBy, JobRoleId) " +
                   "VALUES ('" + model.Name + "',@date,@date1,'" + model.CreatedBy + "'," + model.JobRoleId + ");select last_insert_id() ";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.Parameters.AddWithValue("@date1", DateTime.Now);
                connection.Open();

                //command.ExecuteNonQuery();
                recordId = Convert.ToInt32(command.ExecuteScalar());

                // Call Close when done reading.
                connection.Close();
            }


            foreach (var que in model.SelectedQuestionIds)
            {

                string query =
                "INSERT INTO OnlineTestManagement.TestQuestion(TestId, QuestionId) " +
                       "VALUES (" + recordId + "," + que + ") ";
                using (MySqlConnection connection =
                           new MySqlConnection(connectionString))
                {
                    MySqlCommand command =
                        new MySqlCommand(query, connection);
                    connection.Open();

                    command.ExecuteNonQuery();

                    // Call Close when done reading.
                    connection.Close();
                }
            }

            return;
        }

        #endregion

        #region GetAllTests
        public List<TestViewModel> GetAllTests()
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            List<TestViewModel> model = new List<TestViewModel>();
            string queryString =
        "SELECT * FROM OnlineTestManagement.Test;";

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
                    TestViewModel obj = new TestViewModel();
                    obj.Id = (int)reader[0];
                    obj.Name = reader[1].ToString();
                    obj.CreatedOn = Convert.ToDateTime(reader[2]);
                    obj.ModifiedOn = Convert.ToDateTime(reader[3]);
                    obj.CreatedBy = reader[4].ToString();
                    obj.JobRoleId = (int)reader[5];
                    model.Add(obj);

                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion

        #region GetTestForEdit
        public TestViewModel GetTestForEdit(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            TestViewModel model = new TestViewModel();
            string queryString =
        "select * from OnlineTestManagement.Test where id=" + id + "; ";

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
                    model.CreatedOn = Convert.ToDateTime(reader[2]);
                    model.ModifiedOn = Convert.ToDateTime(reader[3]);
                    model.CreatedBy = reader[4].ToString();
                    model.JobRoleId = (int)reader[5];
                }

                // Call Close when done reading.
                connection.Close();
            }


            string query =
        "select * from OnlineTestManagement.TestQuestion where TestId=" + id + "; ";

            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(query, connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    int queid = (int)reader[1];
                    model.SelectedQuestionIds.Add(queid);
                }

                // Call Close when done reading.
                connection.Close();
            }


            return model;
        }
        #endregion

        #region EditTest
        public void EditTest(int id, TestViewModel model)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
            "update OnlineTestManagement.Test set Name = '" + model.Name + "', ModifiedOn = @date, CreatedBy = '" + model.CreatedBy + "',JobRoleId=" + model.JobRoleId + " where Id =" + model.Id + " ";
            string deleteQuery = "Delete from OnlineTestManagement.TestQuestion where TestId = " + model.Id + "";
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                MySqlCommand deleteCommand =
                    new MySqlCommand(deleteQuery, connection);
                connection.Open();

                command.ExecuteNonQuery();
                deleteCommand.ExecuteNonQuery();

                // Call Close when done reading.
                connection.Close();
            }

            foreach (var que in model.SelectedQuestionIds)
            {

                string query =
                "INSERT INTO OnlineTestManagement.TestQuestion(TestId, QuestionId) " +
                       "VALUES (" + model.Id + "," + que + ") ";
                using (MySqlConnection connection =
                           new MySqlConnection(connectionString))
                {
                    MySqlCommand command =
                        new MySqlCommand(query, connection);
                    connection.Open();

                    command.ExecuteNonQuery();

                    // Call Close when done reading.
                    connection.Close();
                }
            }

            return;
        }
        #endregion

        #region DeleteTest
        public void DeleteTest(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            string queryString =
        "delete from OnlineTestManagement.Test where id=" + id + " ";
            string deleteQuery = "Delete from OnlineTestManagement.TestQuestion where TestId = " + id + "";

            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand(queryString, connection);
                MySqlCommand deleteCommand =
                    new MySqlCommand(deleteQuery, connection);
                connection.Open();


                deleteCommand.ExecuteNonQuery();
                command.ExecuteNonQuery();

                // Call Read before accessing data.


                // Call Close when done reading.
                connection.Close();
            }

            return;
        }
        #endregion

        #region GetTestDetails
        public TestDetailsViewModel GetTestDetails(int id)
        {
            string connectionString = "server=localhost;uid=root;password=Reset1234;database=OnlineTestManagement;";
            TestDetailsViewModel model = new TestDetailsViewModel();
            model.QuestionList = new List<QuestionViewModel>();
            string queryString =
        "select OnlineTestManagement.Test.Id, OnlineTestManagement.Test.Name,OnlineTestManagement.Test.CreatedBy, OnlineTestManagement.JobRole.Value as JobRole from (OnlineTestManagement.Test INNER JOIN JobRole ON OnlineTestManagement.Test.JobRoleId = OnlineTestManagement.JobRole.Id) where OnlineTestManagement.Test.Id=" + id + " ";

            string queList = "select OnlineTestManagement.Question.Id as Id,OnlineTestManagement.Question.Question as Question,OnlineTestManagement.Question.CreatedBy as CreatedBy,OnlineTestManagement.Question.CreatedBy as CreatedBy,OnlineTestManagement.Question.Option1 as Option1,OnlineTestManagement.Question.Option2 as Option2,OnlineTestManagement.Question.Option3 as Option3,OnlineTestManagement.Question.Option4 as Option4  from (OnlineTestManagement.Question INNER JOIN TestQuestion ON OnlineTestManagement.Question.Id = OnlineTestManagement.TestQuestion.QUestionId) where OnlineTestManagement.TestQuestion.TestId=" + id + " ";

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
                    model.CreatedBy = reader[2].ToString();
                    model.JobRole = reader[3].ToString();
                }
                connection.Close();

            }
            using (MySqlConnection connection =
                       new MySqlConnection(connectionString))
            {
                MySqlCommand queCommand =
                   new MySqlCommand(queList, connection);
                connection.Open();
                MySqlDataReader reader = queCommand.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    QuestionViewModel obj = new QuestionViewModel();

                    obj.Id =(int) reader[0];
                    obj.Question = reader[1].ToString();
                    obj.CreatedBy = reader[2].ToString();
                    obj.CorrectAnswer = reader[3].ToString();
                    obj.Option1 = reader[4].ToString();
                    obj.Option2 = reader[5].ToString();
                    obj.Option3 = reader[6].ToString();
                    obj.Option4 = reader[7].ToString();
                    model.QuestionList.Add(obj);
                }

                // Call Close when done reading.
                connection.Close();
            }

            return model;
        }
        #endregion
    }
}
