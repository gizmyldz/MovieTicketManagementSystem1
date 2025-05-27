using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MovieTicketManagementSystem
{/*
    class movieData
    {
        string conn = @"Data Source=LAPTOP-PM5A38PG\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";


        public int ID { set; get; } // 0
        public string MovieID { set; get; }  // 1
        public string MovieName { set; get; } // 2
        public string Genre { set; get; } // 3
        public string Price { set; get; } // 4
        public string Capacity { set; get; } // 5
        public string Status { set; get; } // 6
        public string Image { set; get; } // 7
        public string Date { set; get; } // 8

        public List<movieData> movieListData()
        {
            List<movieData> listData = new List<movieData>();

            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM movie WHERE delete_date IS NULL";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["id"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        listData.Add(mData);
                    }
                }
            }

            return listData;
        }

        public List<movieData> movieAvailableListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM movie WHERE status = 'Available' AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["id"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        listData.Add(mData);
                    }
                }
            }

            return listData;
        }
    } */
    class movieData
    {
        string conn = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";

        public int ID { get; set; }              // 0
        public string MovieID { get; set; }      // 1
        public string MovieName { get; set; }    // 2
        public string Genre { get; set; }        // 3
        public string Price { get; set; }        // 4
        public string Capacity { get; set; }     // 5
        public string Status { get; set; }       // 6
        public string Image { get; set; }        // 7
        public string Date { get; set; }         // 8

        public int SalonID { get; set; }         // 9
        public string SalonAdi { get; set; }     // 10 (JOIN'den geliyor)

        public List<movieData> movieListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = @"SELECT m.*, s.SalonAdi 
                                      FROM movie m
                                      LEFT JOIN Salons s ON m.salon_id = s.SalonID
                                      WHERE m.delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["id"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        // Yeni alanlar
                        mData.SalonID = reader["salon_id"] != DBNull.Value ? Convert.ToInt32(reader["salon_id"]) : 0;
                        mData.SalonAdi = reader["SalonAdi"].ToString();

                        listData.Add(mData);
                    }
                }
            }

            return listData;
        }

        public List<movieData> movieAvailableListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = @"SELECT m.*, s.SalonAdi 
                                      FROM movie m
                                      LEFT JOIN Salons s ON m.salon_id = s.SalonID
                                      WHERE m.status = 'Available' AND m.delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["id"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        // Yeni alanlar
                        mData.SalonID = reader["salon_id"] != DBNull.Value ? Convert.ToInt32(reader["salon_id"]) : 0;
                        mData.SalonAdi = reader["SalonAdi"].ToString();

                        listData.Add(mData);
                    }
                }
            }

            return listData;
        }
    }
}
