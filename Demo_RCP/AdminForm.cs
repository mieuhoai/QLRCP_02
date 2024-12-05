using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_RCP
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_close_log_Click(object sender, EventArgs e)

        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon thoat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon dang xuat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();
            }
        }

        private void btn_addmovie_Click(object sender, EventArgs e)
        {
            addMovieForm admform = new addMovieForm();
            admform.Show();
            this.Hide();

        }

        private void addMovieForm13_Load(object sender, EventArgs e)
        {

        }

        private void btn_dashbroad_Click(object sender, EventArgs e)
        {
            addMovieForm1 admform = new addMovieForm1();
            admform.Visible = false;
            dashbroadForm1 dbform = new dashbroadForm1();
            dbform.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_addstaff_Click(object sender, EventArgs e)
        {
            addStaff addsForm = new addStaff();
            addsForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}