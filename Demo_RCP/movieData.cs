using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Demo_RCP
{
    internal class movieData
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\code-master\code-master\Demo_RCP\obj\movie.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { get; set; }
        public string MovieID { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }
        public string Capacity { get; set; }

        public string Status { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }

        public List<movieData> movieListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "select * from movies where delete_date is null";
                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        movieData mdata = new movieData();
                        mdata.ID = Convert.ToInt32(reader["id"]);
                        mdata.MovieID = reader["movie_id"].ToString();
                        mdata.MovieName = reader["movie_name"].ToString();
                        mdata.Genre = reader["genre"].ToString();
                        mdata.Price = reader["price"].ToString();
                        mdata.Capacity = reader["capacity"].ToString();
                        mdata.Status = reader["status"].ToString();
                        mdata.Image = reader["movie_image"].ToString();
                        mdata.Date = reader["created_at"].ToString();

                        listData.Add(mdata);
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
                string selectData = "select * from movies where status = 'Co san' and delete_date is null";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        movieData mdata = new movieData();
                        mdata.ID = Convert.ToInt32(reader["id"]);
                        mdata.MovieID = reader["movie_id"].ToString();
                        mdata.MovieName = reader["movie_name"].ToString();
                        mdata.Genre = reader["genre"].ToString();
                        mdata.Price = reader["price"].ToString();
                        mdata.Capacity = reader["capacity"].ToString();
                        mdata.Status = reader["status"].ToString();
                        mdata.Image = reader["movie_image"].ToString();
                        mdata.Date = reader["created_at"].ToString();

                        listData.Add(mdata);
                    }
                }
            }
            return listData;
        }
    }
}
