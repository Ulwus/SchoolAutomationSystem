using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace OkulOtomasyon.Models
{
    public class Account
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserPermission { get; set; }
        public int UserAttachID { get; set; }

        private DatabaseConnection dbConnection = DatabaseConnection.Instance;

        public Account()
        {
        }

        public Account(int userId, string userName, string userPassword, int userPermission, int userAttachID)
        {
            UserId = userId;
            UserName = userName;
            UserPassword = userPassword;
            UserPermission = userPermission;
            UserAttachID = userAttachID;
        }

        public bool ValidateLogin(string userName, string password)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    string query = "SELECT * FROM account WHERE userName = @userName AND userPassword = @password";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserId = Convert.ToInt32(reader["userId"]);
                                UserName = reader["userName"].ToString();
                                UserPassword = reader["userPassword"].ToString();
                                UserPermission = Convert.ToInt32(reader["userPermission"]);
                                UserAttachID = Convert.ToInt32(reader["userAttachID"]);
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
            return false;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    string checkQuery = "SELECT COUNT(*) FROM account WHERE userId = @userId AND userPassword = @oldPass";
                    using (var cmd = new MySqlCommand(checkQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserId);
                        cmd.Parameters.AddWithValue("@oldPass", oldPassword);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0) return false;
                    }

                    string updateQuery = "UPDATE account SET userPassword = @newPass WHERE userId = @userId";
                    using (var cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserId);
                        cmd.Parameters.AddWithValue("@newPass", newPassword);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        
    }
}
