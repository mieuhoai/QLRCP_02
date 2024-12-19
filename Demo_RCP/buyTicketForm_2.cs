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
    public partial class buyTicketForm_2 : Form
    {
        string movie_id; // ID phim
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER LAPTOP\OneDrive\Tài liệu\movie.mdf"";Integrated Security=True;Connect Timeout=30";

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
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void displayAvailableSeats()
        {
            using (SqlConnection connect = new SqlConnection(connString))
            {
                try
                {
                    connect.Open();

                    // Lấy danh sách ghế đã đặt
                    string selectBookSeats = "SELECT seat_number FROM buy_tickets WHERE movie_id = @movie_id";
                    List<int> bookedSeats = new List<int>();

                    using (SqlCommand cmd = new SqlCommand(selectBookSeats, connect))
                    {
                        cmd.Parameters.AddWithValue("@movie_id", movie_id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bookedSeats.Add((int)reader["seat_number"]);
                        }
                        reader.Close();
                    }

                    // Đánh dấu ghế đã đặt trên giao diện
                    foreach (Button btn in button_Group.Controls.OfType<Button>())
                    {
                        int seatNumber = int.Parse(btn.Text);
                        if (bookedSeats.Contains(seatNumber))
                        {
                            btn.BackColor = Color.Yellow;
                            btn.Enabled = false; // Vô hiệu hóa ghế đã đặt
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            btn.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu ghế: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChooseASeat(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue; // Chọn ghế
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White; // Bỏ chọn ghế
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được bán!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tính tổng tiền
            int tongTien = 0;

            foreach (Button b in button_Group.Controls.OfType<Button>())
            {
                if (b.BackColor == Color.Blue)
                {
                    string seatText = b.Text;

                    // Tách phần số từ tên ghế (G1, G2,...)
                    string seatNumberString = new string(seatText.Where(char.IsDigit).ToArray());

                    if (int.TryParse(seatNumberString, out int seatNumber))
                    {
                        // Tính tiền dựa trên số ghế
                        if (seatNumber >= 1 && seatNumber <= 5)
                        {
                            tongTien += 30000;
                        }
                        else if (seatNumber >= 6 && seatNumber <= 10)
                        {
                            tongTien += 40000;
                        }
                        else if (seatNumber >= 11 && seatNumber <= 15)
                        {
                            tongTien += 50000;
                        }
                        else if (seatNumber >= 16 && seatNumber <= 20)
                        {
                            tongTien += 80000;
                        }
                    }
                }
            }

            txtThanhTien.Text = tongTien.ToString("N0") + " VND";
        }


        private void btn_buy_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connString))
            {
                try
                {
                    connect.Open();

                    foreach (Button btn in button_Group.Controls.OfType<Button>())
                    {
                        if (btn.BackColor == Color.Blue) // Ghế được chọn
                        {
                            // Tách số từ tên ghế (G1, G2, ...)
                            string seatNumberString = new string(btn.Text.Where(char.IsDigit).ToArray());

                            if (int.TryParse(seatNumberString, out int seatNumber))
                            {
                                // Lưu vào cơ sở dữ liệu
                                string insertTicket = "INSERT INTO buy_tickets (movie_id, seat_number) VALUES (@movie_id, @seat_number)";
                                using (SqlCommand cmd = new SqlCommand(insertTicket, connect))
                                {
                                    cmd.Parameters.AddWithValue("@movie_id", movie_id);
                                    cmd.Parameters.AddWithValue("@seat_number", seatNumber);
                                    cmd.ExecuteNonQuery();
                                }

                                btn.BackColor = Color.Yellow; // Đánh dấu ghế đã bán
                                btn.Enabled = false; // Vô hiệu hóa ghế
                            }
                            else
                            {
                                MessageBox.Show($"Không thể nhận diện số ghế từ '{btn.Text}'. Vui lòng kiểm tra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThanhTien.Text = "0 VND"; // Reset tổng tiền
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mua vé: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buyTicketForm_2_Load(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các nút trong GroupBox và gán sự kiện Click
            for (int i = 1; i <= 50; i++)
            {
                Button btn = button_Group.Controls["button" + i] as Button;
                if (btn != null)
                {
                    btn.Click += btnChooseASeat;
                }
            }
        }



        private void CalculateTotalPrice()
        {
            int totalPrice = 0;

            foreach (Button btn in button_Group.Controls.OfType<Button>())
            {
                if (btn.BackColor == Color.Blue) // Ghế đang chọn
                {
                    int seatNumber = int.Parse(btn.Text);

                    if (seatNumber >= 1 && seatNumber <= 5)
                        totalPrice += 30000;
                    else if (seatNumber >= 6 && seatNumber <= 10)
                        totalPrice += 40000;
                    else if (seatNumber >= 11 && seatNumber <= 15)
                        totalPrice += 50000;
                    else if (seatNumber >= 16 && seatNumber <= 20)
                        totalPrice += 80000;
                }
            }

            txtThanhTien.Text = totalPrice.ToString("N0") + " VND";
        }
    }
}
