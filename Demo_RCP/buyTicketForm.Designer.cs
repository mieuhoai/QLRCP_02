namespace Demo_RCP
{
    partial class buyTicketForm
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
            panel2 = new Panel();
            btn_backListStaff = new Button();
            label1 = new Label();
            btn_close_log = new Button();
            dataGridView3 = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            btn_delmovie = new Button();
            btn_selectMovie = new Button();
            buyTicket_moviePrice = new Label();
            label9 = new Label();
            buyTicket_movieGenre = new Label();
            label7 = new Label();
            buyTicket_movieName = new Label();
            label5 = new Label();
            buyTicket_movieID = new Label();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_backListStaff);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_close_log);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 34);
            panel2.TabIndex = 34;
            // 
            // btn_backListStaff
            // 
            btn_backListStaff.BackColor = Color.FromArgb(133, 19, 33);
            btn_backListStaff.FlatAppearance.BorderSize = 0;
            btn_backListStaff.FlatStyle = FlatStyle.Flat;
            btn_backListStaff.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_backListStaff.ForeColor = Color.White;
            btn_backListStaff.Location = new Point(3, 3);
            btn_backListStaff.Name = "btn_backListStaff";
            btn_backListStaff.Size = new Size(77, 27);
            btn_backListStaff.TabIndex = 44;
            btn_backListStaff.Text = "<--";
            btn_backListStaff.UseVisualStyleBackColor = false;
            btn_backListStaff.Click += btn_backListStaff_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(133, 19, 33);
            label1.Location = new Point(317, 8);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 31;
            label1.Text = " mua ve xem phim";
            // 
            // btn_close_log
            // 
            btn_close_log.BackColor = Color.FromArgb(133, 19, 33);
            btn_close_log.Dock = DockStyle.Right;
            btn_close_log.FlatAppearance.BorderSize = 0;
            btn_close_log.FlatStyle = FlatStyle.Flat;
            btn_close_log.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_log.ForeColor = Color.White;
            btn_close_log.Location = new Point(771, 0);
            btn_close_log.Name = "btn_close_log";
            btn_close_log.Size = new Size(29, 34);
            btn_close_log.TabIndex = 30;
            btn_close_log.Text = "X";
            btn_close_log.UseVisualStyleBackColor = false;
            btn_close_log.Click += btn_close_log_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(133, 19, 33);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.Location = new Point(9, 59);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(779, 173);
            dataGridView3.TabIndex = 35;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(133, 19, 33);
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 36;
            label2.Text = "List movie";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_delmovie);
            panel1.Controls.Add(btn_selectMovie);
            panel1.Controls.Add(buyTicket_moviePrice);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(buyTicket_movieGenre);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(buyTicket_movieName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buyTicket_movieID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(9, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 200);
            panel1.TabIndex = 37;
            // 
            // btn_delmovie
            // 
            btn_delmovie.BackColor = Color.FromArgb(133, 19, 33);
            btn_delmovie.FlatAppearance.BorderSize = 0;
            btn_delmovie.FlatStyle = FlatStyle.Flat;
            btn_delmovie.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delmovie.ForeColor = Color.White;
            btn_delmovie.Location = new Point(663, 154);
            btn_delmovie.Name = "btn_delmovie";
            btn_delmovie.Size = new Size(100, 35);
            btn_delmovie.TabIndex = 44;
            btn_delmovie.Text = "Bo Chon";
            btn_delmovie.UseVisualStyleBackColor = false;
            // 
            // btn_selectMovie
            // 
            btn_selectMovie.BackColor = Color.FromArgb(133, 19, 33);
            btn_selectMovie.FlatAppearance.BorderSize = 0;
            btn_selectMovie.FlatStyle = FlatStyle.Flat;
            btn_selectMovie.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_selectMovie.ForeColor = Color.White;
            btn_selectMovie.Location = new Point(557, 154);
            btn_selectMovie.Name = "btn_selectMovie";
            btn_selectMovie.Size = new Size(100, 35);
            btn_selectMovie.TabIndex = 43;
            btn_selectMovie.Text = "Chon ";
            btn_selectMovie.UseVisualStyleBackColor = false;
            btn_selectMovie.Click += btn_selectMovie_Click;
            // 
            // buyTicket_moviePrice
            // 
            buyTicket_moviePrice.AutoSize = true;
            buyTicket_moviePrice.BackColor = Color.White;
            buyTicket_moviePrice.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_moviePrice.ForeColor = Color.FromArgb(133, 19, 33);
            buyTicket_moviePrice.Location = new Point(283, 172);
            buyTicket_moviePrice.Name = "buyTicket_moviePrice";
            buyTicket_moviePrice.Size = new Size(40, 17);
            buyTicket_moviePrice.TabIndex = 42;
            buyTicket_moviePrice.Text = "____";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(133, 19, 33);
            label9.Location = new Point(244, 172);
            label9.Name = "label9";
            label9.Size = new Size(38, 17);
            label9.TabIndex = 41;
            label9.Text = "Gia:";
            // 
            // buyTicket_movieGenre
            // 
            buyTicket_movieGenre.AutoSize = true;
            buyTicket_movieGenre.BackColor = Color.White;
            buyTicket_movieGenre.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_movieGenre.ForeColor = Color.FromArgb(133, 19, 33);
            buyTicket_movieGenre.Location = new Point(320, 131);
            buyTicket_movieGenre.Name = "buyTicket_movieGenre";
            buyTicket_movieGenre.Size = new Size(40, 17);
            buyTicket_movieGenre.TabIndex = 40;
            buyTicket_movieGenre.Text = "____";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(133, 19, 33);
            label7.Location = new Point(244, 131);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 39;
            label7.Text = "The Loai:";
            // 
            // buyTicket_movieName
            // 
            buyTicket_movieName.AutoSize = true;
            buyTicket_movieName.BackColor = Color.White;
            buyTicket_movieName.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_movieName.ForeColor = Color.FromArgb(133, 19, 33);
            buyTicket_movieName.Location = new Point(346, 89);
            buyTicket_movieName.Name = "buyTicket_movieName";
            buyTicket_movieName.Size = new Size(40, 17);
            buyTicket_movieName.TabIndex = 36;
            buyTicket_movieName.Text = "____";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(133, 19, 33);
            label5.Location = new Point(244, 89);
            label5.Name = "label5";
            label5.Size = new Size(101, 17);
            label5.TabIndex = 35;
            label5.Text = "Movie Name:";
            // 
            // buyTicket_movieID
            // 
            buyTicket_movieID.AutoSize = true;
            buyTicket_movieID.BackColor = Color.White;
            buyTicket_movieID.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyTicket_movieID.ForeColor = Color.FromArgb(133, 19, 33);
            buyTicket_movieID.Location = new Point(320, 40);
            buyTicket_movieID.Name = "buyTicket_movieID";
            buyTicket_movieID.Size = new Size(40, 17);
            buyTicket_movieID.TabIndex = 34;
            buyTicket_movieID.Text = "____";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(133, 19, 33);
            label3.Location = new Point(244, 40);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 33;
            label3.Text = "Movie ID:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(23, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(166, 177);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buyTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "buyTicketForm";
            Text = "buyTicketForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btn_close_log;
        private Button btn_backListStaff;
        private DataGridView dataGridView3;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label buyTicket_movieID;
        private Label label3;
        private Label buyTicket_movieName;
        private Label label5;
        private Label buyTicket_movieGenre;
        private Label label7;
        private Label buyTicket_moviePrice;
        private Label label9;
        private Button btn_delmovie;
        private Button btn_selectMovie;
    }
}