namespace Demo_RCP
{
    partial class addMovieForm1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addmovie_status = new ComboBox();
            label6 = new Label();
            btn_deletemovie = new Button();
            btn_upmovie = new Button();
            btn_addmovie = new Button();
            btn_import = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            addmovie_genre = new TextBox();
            label4 = new Label();
            addmovie_price = new TextBox();
            label3 = new Label();
            addmovie_name = new TextBox();
            label2 = new Label();
            addmovie_id = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addmovie_status
            // 
            addmovie_status.FormattingEnabled = true;
            addmovie_status.Items.AddRange(new object[] { "Chon", "Co san", "Khong co san ", "da xoa" });
            addmovie_status.Location = new Point(161, 117);
            addmovie_status.Name = "addmovie_status";
            addmovie_status.Size = new Size(117, 23);
            addmovie_status.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(133, 19, 33);
            label6.Location = new Point(69, 121);
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
            btn_deletemovie.Location = new Point(495, 153);
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
            btn_upmovie.Location = new Point(334, 153);
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
            btn_addmovie.Location = new Point(175, 153);
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
            btn_import.Location = new Point(659, 117);
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
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(650, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(95, 98);
            panel3.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(133, 19, 33);
            label5.Location = new Point(341, 80);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 38;
            label5.Text = "The Loai";
            // 
            // addmovie_genre
            // 
            addmovie_genre.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_genre.Location = new Point(417, 77);
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
            label4.Location = new Point(378, 28);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 36;
            label4.Text = "Gia";
            // 
            // addmovie_price
            // 
            addmovie_price.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_price.Location = new Point(417, 28);
            addmovie_price.Multiline = true;
            addmovie_price.Name = "addmovie_price";
            addmovie_price.Size = new Size(117, 20);
            addmovie_price.TabIndex = 35;
            addmovie_price.Tag = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(133, 19, 33);
            label3.Location = new Point(59, 80);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 34;
            label3.Text = "Movie Name";
            // 
            // addmovie_name
            // 
            addmovie_name.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_name.Location = new Point(161, 77);
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
            label2.Location = new Point(85, 31);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 32;
            label2.Text = "Movie ID";
            // 
            // addmovie_id
            // 
            addmovie_id.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmovie_id.Location = new Point(161, 28);
            addmovie_id.Multiline = true;
            addmovie_id.Name = "addmovie_id";
            addmovie_id.Size = new Size(117, 20);
            addmovie_id.TabIndex = 31;
            addmovie_id.Tag = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
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
            panel2.Location = new Point(16, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 203);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(751, 143);
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
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 2;
            label1.Text = "List movie";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 178);
            panel1.TabIndex = 2;
            // 
            // addMovieForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addMovieForm1";
            Size = new Size(789, 416);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
    }
}
