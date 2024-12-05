using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_RCP
{
    public partial class buyTicketForm_2 : Form
    {
        public buyTicketForm_2()
        {
            InitializeComponent();
        }

        private void btn_backListStaff_Click(object sender, EventArgs e)
        {
            buyTicketForm btkForm = new buyTicketForm();
            btkForm.Show();
            this.Hide();
        }

        private void btn_close_log_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon thoat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
        string movie_id;
        public void displayAvailableSeats()
        {
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\code-master\code-master\Demo_RCP\obj\movie.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectAvailableSeat = $"select capacity from movies where delete_date is null and status != 'Deleted' and movie_id = {movie_id}";
                int setAvailable = 0;
                using(SqlCommand cmdSelectSeat = new SqlCommand(selectAvailableSeat,connect))
                {
                    SqlDataReader reader = cmdSelectSeat.ExecuteReader();
                    if (reader.Read())
                    {
                        setAvailable = (int)reader["capacity"];
                    }
                    reader.Close();
                }
                if(setAvailable > 0)
                {
                    string selectBookSeats = "select seat_number from buy_tickets where movie_id = @movie_id";
                    List<int> bookSeat = new List<int>();

                    using(SqlCommand cmd = new SqlCommand(selectBookSeats,connect))
                    {
                        cmd.Parameters.AddWithValue("@movie_id",movie_id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                        }
                    }
                }
            }
        }
    }
}
