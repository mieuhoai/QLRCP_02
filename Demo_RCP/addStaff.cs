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
using System.Xml;

namespace Demo_RCP
{
    public partial class addStaff : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\code-master\code-master\Demo_RCP\obj\movie.mdf;Integrated Security=True;Connect Timeout=30";

        public addStaff()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            staffData sData = new staffData();

            List<staffData> listData = sData.staffDataListData();
            dataGridView2.DataSource = listData;
        }

        private void addStaff_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminForm adForm = new AdminForm();
            adForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_log_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon thoat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btn_addstaff_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("o nay bi trong", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectUsername = "select * from users where username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(selectUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", txt_usrname_addstaff.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(txt_usrname_addstaff.Text.Substring(0, 1).ToUpper() + txt_usrname_addstaff.Text.Substring(1) + "da co san", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string insertData = "insert into users (username, password, role, status, date_reg)" + "values(@usern, @pass, @role, @status, @date)";
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", txt_usrname_addstaff.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", txt_passwd_addstaff.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "staff");
                                cmd.Parameters.AddWithValue("@status", cb_status_addstaff.SelectedItem.ToString());
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("them thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                    }
                }
            }


        }
        public bool isEmpty()
        {
            if (txt_usrname_addstaff.Text == "" || txt_passwd_addstaff.Text == "" || cb_status_addstaff.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int getID = 0;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                txt_usrname_addstaff.Text = row.Cells[1].Value.ToString();
                txt_passwd_addstaff.Text = row.Cells[2].Value.ToString();
                cb_status_addstaff.SelectedItem = row.Cells[4].Value.ToString();

            }
        }

        private void btn_upstaff_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("o nay bi trong", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("ban co chac chan cap nhat id nay:" + getID + "?", "thong bao xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        string selectUsername = "select * from users where username = @usern";
                        using (SqlCommand checkUsern = new SqlCommand(selectUsername, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", txt_usrname_addstaff.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show(txt_usrname_addstaff.Text.Substring(0, 1).ToUpper() + txt_usrname_addstaff.Text.Substring(1) + "da co san", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string updatedata = "update users set username = @usern, password = @pass, status = @status where id = @id";
                                using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", txt_usrname_addstaff.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", txt_passwd_addstaff.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", cb_status_addstaff.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@Id", getID);


                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("cap nhat thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }
                        }
                    }
                }
            }
        }
        public void clearFields()
        {
            txt_usrname_addstaff.Text = "";
            txt_passwd_addstaff.Text = "";
            cb_status_addstaff.SelectedIndex = -1;
        }

        private void btn_deletestaff_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("o nay bi trong", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon xoa id nay:" + getID + "?", "thong bao xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        
                                string updatedata = "update users set status = @status where id = @id";
                                using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                                {
                                    
                                    cmd.Parameters.AddWithValue("@status", "Deleted");
                                    cmd.Parameters.AddWithValue("@Id", getID);


                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("xoa thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                    }
                }
            }
        }
    }
}
