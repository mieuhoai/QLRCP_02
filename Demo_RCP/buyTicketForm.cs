using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Demo_RCP
{
    public partial class buyTicketForm : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\code-master\code-master\Demo_RCP\obj\movie.mdf;Integrated Security=True;Connect Timeout=30";

        public buyTicketForm()
        {
            InitializeComponent();
            displayAvailableMovies();
        }

        private void btn_close_log_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon thoat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btn_backListStaff_Click(object sender, EventArgs e)
        {
            UserForm usrForm = new UserForm();
            usrForm.Show();
            this.Hide();
        }
        public void displayAvailableMovies()
        {
            movieData mData = new movieData();
            List<movieData> listData = mData.movieAvailableListData();
            dataGridView3.DataSource = listData;
        }

        string movie_id;
        private void btn_selectMovie_Click(object sender, EventArgs e)
        {
            movie_id = buyTicket_movieName.Text.Trim();
            buyTicketForm_2 btk2Form = new buyTicketForm_2();
            btk2Form.Show();
            this.Hide();
        }
        

        private int id = 0;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                buyTicket_movieID.Text = row.Cells[1].Value.ToString();
                buyTicket_movieName.Text = row.Cells[2].Value.ToString();
                buyTicket_movieGenre.Text = row.Cells[3].Value.ToString();
                buyTicket_moviePrice.Text = row.Cells[4].Value.ToString();
                
                pictureBox1.ImageLocation = row.Cells[6].Value.ToString();
            }
        }
    }
}
