using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace OkulOtomasyon.Models
{
    public class Teacher
    {
        public int OgretmenID { get; set; }
        public string OgretmenIsim { get; set; }
        public string OgretmenSoyisim { get; set; }
        public string OgretmenTelefon { get; set; }
        public string OgretmenEmail { get; set; }
        public string OgretmenBrans { get; set; }
        public DateTime OgretmenIseBaslamaTarihi { get; set; }

        private DatabaseConnection dbConnection = DatabaseConnection.Instance;

        public Teacher()
        {
        }

        public Teacher(int ogretmenID, string ogretmenIsim, string ogretmenSoyisim, string ogretmenTelefon,
                      string ogretmenEmail, string ogretmenBrans, DateTime ogretmenIseBaslamaTarihi)
        {
            OgretmenID = ogretmenID;
            OgretmenIsim = ogretmenIsim;
            OgretmenSoyisim = ogretmenSoyisim;
            OgretmenTelefon = ogretmenTelefon;
            OgretmenEmail = ogretmenEmail;
            OgretmenBrans = ogretmenBrans;
            OgretmenIseBaslamaTarihi = ogretmenIseBaslamaTarihi;
        }



        public static Teacher GetById(int id)
        {
            try
            {
                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    string query = "SELECT * FROM ogretmen WHERE ogretmenID = @ogretmenID";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ogretmenID", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Teacher
                                {
                                    OgretmenID = Convert.ToInt32(reader["ogretmenID"]),
                                    OgretmenIsim = reader["ogretmenIsim"].ToString(),
                                    OgretmenSoyisim = reader["ogretmenSoyisim"].ToString(),
                                    OgretmenTelefon = reader["ogretmenTelefon"].ToString(),
                                    OgretmenEmail = reader["ogretmenEmail"].ToString(),
                                    OgretmenBrans = reader["ogretmenBrans"].ToString(),
                                    OgretmenIseBaslamaTarihi = Convert.ToDateTime(reader["ogretmenIseBaslamaTarihi"])
                                };
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
                DatabaseConnection.Instance.CloseConnection();
            }
            return null;
        }

        
    }
}
