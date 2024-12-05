namespace Demo_RCP
{
    partial class addMovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_hidepanel1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btn_back = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_hidepanel2 = new Button();
            addmovie_status = new ComboBox();
            label6 = new Label();
            btn_deletemovie = new Button();
            btn_upmovie = new Button();
            btn_addmovie = new Button();
            btn_import = new Button();
            panel3 = new Panel();
            label5 = new Label();
            addmovie_genre = new TextBox();
            label4 = new Label();
            addmovie_price = new TextBox();
            label3 = new Label();
            addmovie_name = new TextBox();
            label2 = new Label();
            addmovie_id = new TextBox();
            label7 = new Label();
            addmovie_capacity = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_hidepanel1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 4;
            // 
            // btn_hidepanel1
            // 
            btn_hidepanel1.BackColor = Color.FromArgb(133, 19, 33);
            btn_hidepanel1.FlatAppearance.BorderSize = 0;
            btn_hidepanel1.FlatStyle = FlatStyle.Flat;
            btn_hidepanel1.ForeColor = Color.White;
            btn_hidepanel1.Location = new Point(150, 26);
            btn_hidepanel1.Margin = new Padding(3, 2, 3, 2);
            btn_hidepanel1.Name = "btn_hidepanel1";
            btn_hidepanel1.Size = new Size(97, 26);
            btn_hidepanel1.TabIndex = 47;
            btn_hidepanel1.Text = "Thêm phim";
            btn_hidepanel1.UseVisualStyleBackColor = false;
            btn_hidepanel1.Click += btn_hidepanel1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(133, 19, 33);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 395);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(133, 19, 33);
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 2;
            label1.Text = "List movie";
            label1.Click += label1_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(133, 19, 33);
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(1, 0);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(77, 27);
            btn_back.TabIndex = 42;
            btn_back.Text = "<--";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(addmovie_capacity);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btn_hidepanel2);
            panel2.Controls.Add(addmovie_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btn_deletemovie);
            panel2.Controls.Add(btn_upmovie);
            panel2.Controls.Add(btn_addmovie);
            panel2.Controls.Add(btn_import);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addmovie_genre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addmovie_price);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addmovie_name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(addmovie_id);
            panel2.Location = new Point(1, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 424);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(404, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(404, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(356, 205);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btn_hidepanel2
            // 
            btn_hidepanel2.BackColor = Color.FromArgb(133, 19, 33);
            btn_hidepanel2.FlatAppearance.BorderSize = 0;
            btn_hidepanel2.FlatStyle = FlatStyle.Flat;
            btn_hidepanel2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btn_hidepanel2.ForeColor = SystemColors.ControlLightLight;
            btn_hidepanel2.Location = new Point(15, 32);
            btn_hidepanel2.Margin = new Padding(3, 2, 3, 2);
            btn_hidepanel2.Name = "btn_hidepanel2";
            btn_hidepanel2.Size = new Size(142, 28);
            btn_hidepanel2.TabIndex = 47;
            btn_hidepanel2.Text = "Danh sách phim";
            btn_hidepanel2.UseVisualStyleBackColor = false;
            btn_hidepanel2.Click += btn_hidepanel2_Click;
            // 
            // addmovie_status
            // 
            addmovie_status.FormattingEnabled = true;
            addmovie_status.Items.AddRange(new object[] { "Chon", "Co san", "Khong co san ", "da xoa" });
            addmovie_status.Location = new Point(178, 234);
            addmovie_status.Name = "addmovie_status";
            addmovie_status.Size = new Size(117, 23);
            addmovie_status.TabIndex = 46;
            addmovie_status.SelectedIndexChanged += addmovie_status_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(133, 19, 33);
            label6.Location = new Point(64, 234);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 45;
            label6.Text = "Trang Thai";
            // 
            // btn_deletemovie
            // 
            btn_deletemovie.BackColor = Color.FromArgb(133, 19, 33);
            btn_deletemovie.FlatAppearance.BorderSize = 0;
            btn_deletemovie.FlatStyle = FlatStyle.Flat;
            btn_deletemovie.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deletemovie.ForeColor = Color.White;
            btn_deletemovie.Location = new Point(224, 83);
            btn_deletemovie.Name = "btn_deletemovie";
            btn_deletemovie.Size = new Size(77, 27);
            btn_deletemovie.TabIndex = 43;
            btn_deletemovie.Text = "delete";
            btn_deletemovie.UseVisualStyleBackColor = false;
            btn_deletemovie.Click += btn_deletemovie_Click;
            // 
            // btn_upmovie
            // 
            btn_upmovie.BackColor = Color.FromArgb(133, 19, 33);
            btn_upmovie.FlatAppearance.BorderSize = 0;
            btn_upmovie.FlatStyle = FlatStyle.Flat;
            btn_upmovie.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_upmovie.ForeColor = Color.White;
            btn_upmovie.Location = new Point(117, 83);
            btn_upmovie.Name = "btn_upmovie";
            btn_upmovie.Size = new Size(77, 27);
            btn_upmovie.TabIndex = 42;
            btn_upmovie.Text = "update";
            btn_upmovie.UseVisualStyleBackColor = false;
            btn_upmovie.Click += btn_upmovie_Click;
            // 
            // btn_addmovie
            // 
            btn_addmovie.BackColor = Color.FromArgb(133, 19, 33);
            btn_addmovie.FlatAppearance.BorderSize = 0;
            btn_addmovie.FlatStyle = FlatStyle.Flat;
            btn_addmovie.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addmovie.ForeColor = Color.White;
            btn_addmovie.Location = new Point(15, 83);
            btn_addmovie.Name = "btn_addmovie";
            btn_addmovie.Size = new Size(77, 27);
            btn_addmovie.TabIndex = 41;
            btn_addmovie.Text = "add";
            btn_addmovie.UseVisualStyleBackColor = false;
            btn_addmovie.Click += btn_addmovie_Click;
            // 
            // btn_import
            // 
            btn_import.BackColor = Color.FromArgb(133, 19, 33);
            btn_import.FlatAppearance.BorderSize = 0;
            btn_import.FlatStyle = FlatStyle.Flat;
            btn_import.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_import.ForeColor = Color.White;
            btn_import.Location = new Point(404, 317);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(77, 27);
            btn_import.TabIndex = 40;
            btn_import.Text = "Import";
            btn_import.UseVisualStyleBackColor = false;
            btn_import.Click += btn_import_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(404, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 205);
            panel3.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(133, 19, 33);
            label5.Location = new Point(64, 338);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 38;
            label5.Text = "The Loai";
            // 
            // addmovie_genre
            // 
            addmovie_genre.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_genre.Location = new Point(178, 338);
            addmovie_genre.Multiline = true;
            addmovie_genre.Name = "addmovie_genre";
            addmovie_genre.Size = new Size(117, 20);
            addmovie_genre.TabIndex = 37;
            addmovie_genre.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(133, 19, 33);
            label4.Location = new Point(64, 286);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 36;
            label4.Text = "Gia";
            // 
            // addmovie_price
            // 
            addmovie_price.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_price.Location = new Point(178, 284);
            addmovie_price.Multiline = true;
            addmovie_price.Name = "addmovie_price";
            addmovie_price.Size = new Size(117, 20);
            addmovie_price.TabIndex = 35;
            addmovie_price.Tag = "";
            addmovie_price.TextChanged += addmovie_price_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(133, 19, 33);
            label3.Location = new Point(64, 188);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 34;
            label3.Text = "Movie Name";
            // 
            // addmovie_name
            // 
            addmovie_name.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_name.Location = new Point(178, 188);
            addmovie_name.Multiline = true;
            addmovie_name.Name = "addmovie_name";
            addmovie_name.Size = new Size(117, 20);
            addmovie_name.TabIndex = 33;
            addmovie_name.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(133, 19, 33);
            label2.Location = new Point(64, 146);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 32;
            label2.Text = "Movie ID";
            // 
            // addmovie_id
            // 
            addmovie_id.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_id.Location = new Point(178, 146);
            addmovie_id.Multiline = true;
            addmovie_id.Name = "addmovie_id";
            addmovie_id.Size = new Size(117, 20);
            addmovie_id.TabIndex = 31;
            addmovie_id.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(133, 19, 33);
            label7.Location = new Point(64, 385);
            label7.Name = "label7";
            label7.Size = new Size(76, 17);
            label7.TabIndex = 48;
            label7.Text = "So Luong";
            // 
            // addmovie_capacity
            // 
            addmovie_capacity.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_capacity.Location = new Point(178, 382);
            addmovie_capacity.Multiline = true;
            addmovie_capacity.Name = "addmovie_capacity";
            addmovie_capacity.Size = new Size(117, 20);
            addmovie_capacity.TabIndex = 49;
            addmovie_capacity.Tag = "";
            // 
            // addMovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addMovieForm";
            Text = "addMovieForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private ComboBox addmovie_status;
        private Label label6;
        private Button btn_deletemovie;
        private Button btn_upmovie;
        private Button btn_addmovie;
        private Button btn_import;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox addmovie_genre;
        private Label label4;
        private TextBox addmovie_price;
        private Label label3;
        private TextBox addmovie_name;
        private Label label2;
        private TextBox addmovie_id;
        private Button btn_back;
        private PictureBox pictureBox2;
        private Button btn_hidepanel1;
        private Button btn_hidepanel2;
        private TextBox addmovie_capacity;
        private Label label7;
    }
}