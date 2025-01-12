using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace OkulOtomasyon.Models
{
    public class Student
    {
        public int OgrenciID { get; set; }
        public string OgrenciIsmi { get; set; }
        public string OgrenciSoyismi { get; set; }
        public string OgrenciYili { get; set; }
        public DateTime OgrenciDogumYili { get; set; }
        public int OgrenciSinif { get; set; }
        public string OgrenciVeliİsmi { get; set; }
        public string OgrenciVeliTel { get; set; }

        private DatabaseConnection dbConnection = DatabaseConnection.Instance;

        public Student()
        {
        }

        public Student(int ogrenciID, string ogrenciIsmi, string ogrenciSoyismi, string ogrenciYili,
                      DateTime ogrenciDogumYili, int ogrenciSinif, string OgrenciVeliİsmi, string ogrenciVeliTel)
        {
            OgrenciID = ogrenciID;
            OgrenciIsmi = ogrenciIsmi;
            OgrenciSoyismi = ogrenciSoyismi;
            OgrenciYili = ogrenciYili;
            OgrenciDogumYili = ogrenciDogumYili;
            OgrenciSinif = ogrenciSinif;
            OgrenciVeliİsmi = OgrenciVeliİsmi;
            OgrenciVeliTel = ogrenciVeliTel;
        }

        public static Student GetById(int id)
        {
            try
            {
                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    string query = "SELECT * FROM ogrenci WHERE ogrenciID = @ogrenciID";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ogrenciID", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Student
                                {
                                    OgrenciID = Convert.ToInt32(reader["ogrenciID"]),
                                    OgrenciIsmi = reader["ogrenciIsmi"].ToString(),
                                    OgrenciSoyismi = reader["ogrenciSoyismi"].ToString(),
                                    OgrenciYili = reader["ogrenciYili"].ToString(),
                                    OgrenciDogumYili = Convert.ToDateTime(reader["ogrenciDogumYili"]),
                                    OgrenciSinif = Convert.ToInt32(reader["ogrenciSinif"]),
                                    OgrenciVeliİsmi = reader["OgrenciVeliİsmi"].ToString(),
                                    OgrenciVeliTel = Convert.ToString(reader["ogrenciVeliTel"])
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
