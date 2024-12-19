using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Demo_RCP
{
    class staffData
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER LAPTOP\OneDrive\Tài liệu\movie.mdf"";Integrated Security=True;Connect Timeout=30";

        public int Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }

        public List<staffData> staffDataListData()
        {
            List<staffData> listData = new List<staffData>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "select * from users where role = 'staff' and status != 'Deleted'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        staffData sdata = new staffData();
                        sdata.Id = (int)reader[0];
                        sdata.Username = reader[1].ToString();
                        sdata.Password = reader[2].ToString();
                        sdata.Role = reader[3].ToString();
                        sdata.Status = reader[4].ToString();
                        

                        listData.Add(sdata);
                    }
                }
            }
            return listData;
        }
    }
}
