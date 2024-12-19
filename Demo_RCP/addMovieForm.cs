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
    public partial class addMovieForm : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\code-master\code-master\Demo_RCP\obj\movie.mdf;Integrated Security=True;Connect Timeout=30";
        /* string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\QLRCP.mdf;Integrated Security=True;Connect Timeout=30";*/
        public addMovieForm()
        {
            InitializeComponent();
            displayData();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";
                file.Filter = "Image Files (*.jpg; *png)|*.jpg; *png";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"loi: {ex}", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_addmovie_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string checkID = "SELECT movie_id FROM movies WHERE movie_id = @movieID";
                    using (SqlCommand cID = new SqlCommand(checkID, connect))
                    {
                        cID.Parameters.AddWithValue("@movieID", addmovie_id.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cID);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show($"Movie ID: {addmovie_id.Text.Trim()} đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string insertData = "INSERT INTO movies(movie_id, movie_name, genre, price,capacity, movie_image, status, created_at) " +
                                                "VALUES(@movieID, @movieName, @genre, @price,@capacity, @movieImage, @status, @date)";

                            // Kiểm tra nếu chưa chọn ảnh
                            if (string.IsNullOrEmpty(pictureBox1.ImageLocation))
                            {
                                MessageBox.Show("Vui lòng chọn hình ảnh trước khi thêm phim!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ds_movie", addmovie_id.Text.Trim() + ".jpg");
                            string directoryPath = Path.GetDirectoryName(path);
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            // Sao chép file ảnh
                            File.Copy(pictureBox1.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@movieID", addmovie_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@movieName", addmovie_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@genre", addmovie_genre.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", addmovie_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@capacity", addmovie_capacity.Text.Trim());
                                cmd.Parameters.AddWithValue("@movieImage", path);
                                cmd.Parameters.AddWithValue("@status", addmovie_status.SelectedItem?.ToString() ?? "Unknown");
                                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                                cmd.ExecuteNonQuery();
                                displayData();
                                clearFields();
                                MessageBox.Show("Thêm phim thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_upmovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ban co chac chan cap nhat id nay: " + addmovie_id.Text
                    + "?", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        string checkID = "Select count(id) from movies where movie_id = @movieID";
                        using (SqlCommand cID = new SqlCommand(checkID, connect))
                        {
                            cID.Parameters.AddWithValue("@movieID", addmovie_id.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cID);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show($"Movie ID: " + addmovie_id.Text.Trim() + " da duoc thuc hien", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string updateData = "update movies set movie_id = @movieID, movie_name=@movieName, genre=@genre" + ", price=@price, movie_image=@image,status=@status, update_date =@updateDate where id = @id";

                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@movieID", addmovie_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@movieName", addmovie_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@genre", addmovie_genre.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", addmovie_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", addmovie_status.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@image", pictureBox1.ImageLocation);
                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@updateDate", today);
                                    cmd.Parameters.AddWithValue("@id", id);
                                    cmd.ExecuteNonQuery();
                                    displayData();
                                    clearFields();
                                    MessageBox.Show("cap nhat thanh cong ", " thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"loi: {ex}", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_deletemovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ban co chac chan cap nhat id nay: " + addmovie_id.Text
                    + "?", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        string updateData = "update movies set delete_date = @delete_date, status=@status where id = @id";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@delete_Date", today);
                            cmd.Parameters.AddWithValue("@status", "Deleted");
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            displayData();
                            clearFields();
                            MessageBox.Show("cap nhat thanh cong ", " thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"loi: {ex}", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                addmovie_id.Text = row.Cells[1].Value.ToString();
                addmovie_name.Text = row.Cells[2].Value.ToString();
                addmovie_genre.Text = row.Cells[3].Value.ToString();
                addmovie_price.Text = row.Cells[4].Value.ToString();
                addmovie_status.Text = row.Cells[5].Value.ToString();
                pictureBox1.ImageLocation = row.Cells[6].Value.ToString();
            }
        }
        public void clearFields()
        {
            addmovie_id.Text = "";
            addmovie_name.Text = "";
            addmovie_genre.Text = "";
            addmovie_price.Text = "";
            pictureBox1.Image = null;
            addmovie_status.SelectedIndex = -1;
        }
        public void displayData()
        {

            movieData mData = new movieData();
            List<movieData> listData = mData.movieListData();
            dataGridView1.DataSource = listData;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminForm adForm = new AdminForm();
            adForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addmovie_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void addmovie_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_hidepanel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void btn_hidepanel2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
