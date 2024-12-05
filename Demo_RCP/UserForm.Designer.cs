namespace Demo_RCP
{
    partial class UserForm
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
            panel2 = new Panel();
            label1 = new Label();
            btn_close_log = new Button();
            btn_logout = new Button();
            btn_buyticket = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_close_log);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 34);
            panel2.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(133, 19, 33);
            label1.Location = new Point(344, 8);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 31;
            label1.Text = " ve xem phim";
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
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(133, 19, 33);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(12, 398);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(183, 40);
            btn_logout.TabIndex = 34;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_buyticket
            // 
            btn_buyticket.BackColor = Color.FromArgb(133, 19, 33);
            btn_buyticket.FlatAppearance.BorderSize = 0;
            btn_buyticket.FlatStyle = FlatStyle.Flat;
            btn_buyticket.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_buyticket.ForeColor = Color.White;
            btn_buyticket.Location = new Point(305, 93);
            btn_buyticket.Name = "btn_buyticket";
            btn_buyticket.Size = new Size(183, 40);
            btn_buyticket.TabIndex = 35;
            btn_buyticket.Text = "Mua ve";
            btn_buyticket.UseVisualStyleBackColor = false;
            btn_buyticket.Click += btn_buyticket_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_buyticket);
            Controls.Add(btn_logout);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btn_close_log;
        private Button btn_logout;
        private Button btn_buyticket;
    }
}