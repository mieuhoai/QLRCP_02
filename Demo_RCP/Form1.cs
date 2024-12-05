using System.Data;
using System.Data.SqlClient;
namespace Demo_RCP
{
    public partial class Form1 : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\code-master\code-master\Demo_RCP\obj\movie.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btn_close_log_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon thoat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (log_username.Text == "" || log_passwd.Text == "")
            {
                MessageBox.Show("Hay dien vao nhung o trong", "loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectData = "select * from users where username = @usern and password = @pass";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", log_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", log_passwd.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            string role = table.Rows[0]["role"].ToString();   
                            MessageBox.Show(" dang nhap thanh cong ", " thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (role == "Admin")
                            {
                                AdminForm adform = new AdminForm();
                                adform.Show();
                                
                            }
                            else if(role == "Staff")
                            {
                                UserForm usrform = new UserForm();
                                usrform.Show();
                                
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(" tai khoan hoac mac khau khong dung ", " loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void log_showpass_CheckedChanged(object sender, EventArgs e)
        {
            log_passwd.PasswordChar = log_showpass.Checked ? '\0' : '*';

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void log_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_username_Enter(object sender, EventArgs e)
        {
            if (log_username.Text == "Nhập tên đăng nhập")
            {
                log_username.Text = ""; // Xóa placeholder
                log_username.ForeColor = Color.Black; // Đổi màu chữ khi nhập
            }
        }

        private void log_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(log_username.Text))
            {
                log_username.Text = "Nhập tên đăng nhập"; // Hiển thị lại placeholder
                log_username.ForeColor = Color.Gray; // Màu chữ cho placeholder
            }
        }

        private void log_passwd_Enter(object sender, EventArgs e)
        {
            if (log_passwd.Text == "Nhập tên đăng nhập")
            {
                log_passwd.Text = ""; // Xóa placeholder
                log_passwd.ForeColor = Color.Black; // Đổi màu chữ khi nhập
            }
        }

        private void log_passwd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(log_passwd.Text))
            {
                log_passwd.Text = "Nhập tên đăng nhập"; // Hiển thị lại placeholder
                log_passwd.ForeColor = Color.Gray; // Màu chữ cho placeholder
            }
        }

        private void reg_showpass_CheckedChanged(object sender, EventArgs e)
        {
            reg_passwd.PasswordChar = reg_showpass.Checked ? '\0' : '*';
            reg_cpasswd.PasswordChar = reg_showpass.Checked ? '\0' : '*';
        }




        //đăng ký
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (reg_username.Text == "" || reg_passwd.Text == "" || reg_cpasswd.Text == "")
            {
                MessageBox.Show("Hãy điền vào những ô trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reg_passwd.Text != reg_cpasswd.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reg_passwd.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu phải dài hơn 5 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string checkUsername = "SELECT * FROM users WHERE username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date_reg) VALUES (@usern, @pass, @role, @status, @date)";
                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", reg_passwd.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "member");
                                cmd.Parameters.AddWithValue("@status", "active");
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Sau khi đăng ký, quay lại giao diện đăng nhập
                                panel2.Visible = false;
                                panel1.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void btn_reglink1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; // Ẩn panel Đăng nhập
            panel2.Visible = true;  // Hiển thị panel Đăng ký
        }

        private void btn_reglink2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false; // Ẩn panel Đăng ký
            panel1.Visible = true;  // Hiển thị panel Đăng nhập
        }
    }
}
