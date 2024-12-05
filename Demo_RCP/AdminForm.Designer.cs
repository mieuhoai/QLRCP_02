namespace Demo_RCP
{
    partial class AdminForm
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
            btn_logout = new Button();
            btn_mangestaff = new Button();
            btn_dashbroad = new Button();
            btn_managemovie = new Button();
            btn_close_log = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_managecus = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.BackColor = SystemColors.Desktop;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(0, 376);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(183, 40);
            btn_logout.TabIndex = 7;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_mangestaff
            // 
            btn_mangestaff.BackColor = SystemColors.Desktop;
            btn_mangestaff.FlatAppearance.BorderSize = 0;
            btn_mangestaff.FlatStyle = FlatStyle.Flat;
            btn_mangestaff.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_mangestaff.ForeColor = Color.White;
            btn_mangestaff.Location = new Point(311, 203);
            btn_mangestaff.Name = "btn_mangestaff";
            btn_mangestaff.Size = new Size(183, 40);
            btn_mangestaff.TabIndex = 2;
            btn_mangestaff.Text = "Them Nhan Vien";
            btn_mangestaff.UseVisualStyleBackColor = false;
            btn_mangestaff.Click += btn_addstaff_Click;
            // 
            // btn_dashbroad
            // 
            btn_dashbroad.BackColor = SystemColors.Desktop;
            btn_dashbroad.FlatAppearance.BorderSize = 0;
            btn_dashbroad.FlatStyle = FlatStyle.Flat;
            btn_dashbroad.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_dashbroad.ForeColor = Color.White;
            btn_dashbroad.Location = new Point(311, 133);
            btn_dashbroad.Name = "btn_dashbroad";
            btn_dashbroad.Size = new Size(183, 40);
            btn_dashbroad.TabIndex = 1;
            btn_dashbroad.Text = "Bang Dieu Khien";
            btn_dashbroad.UseVisualStyleBackColor = false;
            btn_dashbroad.Click += btn_dashbroad_Click;
            // 
            // btn_managemovie
            // 
            btn_managemovie.BackColor = SystemColors.Desktop;
            btn_managemovie.FlatAppearance.BorderSize = 0;
            btn_managemovie.FlatStyle = FlatStyle.Flat;
            btn_managemovie.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_managemovie.ForeColor = Color.White;
            btn_managemovie.Location = new Point(311, 63);
            btn_managemovie.Name = "btn_managemovie";
            btn_managemovie.Size = new Size(183, 40);
            btn_managemovie.TabIndex = 3;
            btn_managemovie.Text = "Quản lý phim";
            btn_managemovie.UseVisualStyleBackColor = false;
            btn_managemovie.Click += btn_addmovie_Click;
            // 
            // btn_close_log
            // 
            btn_close_log.BackColor = Color.FromArgb(133, 19, 33);
            btn_close_log.Dock = DockStyle.Right;
            btn_close_log.FlatAppearance.BorderSize = 0;
            btn_close_log.FlatStyle = FlatStyle.Flat;
            btn_close_log.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_log.ForeColor = Color.White;
            btn_close_log.Location = new Point(777, 0);
            btn_close_log.Name = "btn_close_log";
            btn_close_log.Size = new Size(29, 34);
            btn_close_log.TabIndex = 30;
            btn_close_log.Text = "X";
            btn_close_log.UseVisualStyleBackColor = false;
            btn_close_log.Click += btn_close_log_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(133, 19, 33);
            label1.Location = new Point(284, 7);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 31;
            label1.Text = "he thong quan ly ve xem phim";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_close_log);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 34);
            panel2.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_managecus);
            panel3.Controls.Add(btn_managemovie);
            panel3.Controls.Add(btn_logout);
            panel3.Controls.Add(btn_dashbroad);
            panel3.Controls.Add(btn_mangestaff);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(806, 416);
            panel3.TabIndex = 33;
            // 
            // btn_managecus
            // 
            btn_managecus.BackColor = SystemColors.Desktop;
            btn_managecus.FlatAppearance.BorderSize = 0;
            btn_managecus.FlatStyle = FlatStyle.Flat;
            btn_managecus.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_managecus.ForeColor = Color.White;
            btn_managecus.Location = new Point(311, 274);
            btn_managecus.Margin = new Padding(3, 2, 3, 2);
            btn_managecus.Name = "btn_managecus";
            btn_managecus.Size = new Size(183, 40);
            btn_managecus.TabIndex = 8;
            btn_managecus.Text = "Quản lý khách hàng";
            btn_managecus.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_dashbroad;
        private Button button3;
        private Button btn_managemovie;
        private Button btn_mangestaff;
        private Button btn_close_log;
        private Label label1;
        private Panel panel2;
        private Button btn_logout;
        private Panel panel3;
        private addMovieForm1 addMovieForm1;
        private addMovieForm1 addMovieForm11;
        private Button btn_managecus;
    }
}