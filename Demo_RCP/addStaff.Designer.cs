namespace Demo_RCP
{
    partial class addStaff
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
            btn_backListStaff = new Button();
            label1 = new Label();
            btn_close_log = new Button();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_passwd_addstaff = new TextBox();
            txt_usrname_addstaff = new TextBox();
            cb_status_addstaff = new ComboBox();
            groupBox1 = new GroupBox();
            btn_deletestaff = new Button();
            btn_upstaff = new Button();
            btn_addstaff = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_backListStaff);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_close_log);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 34);
            panel1.TabIndex = 0;
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
            btn_backListStaff.TabIndex = 43;
            btn_backListStaff.Text = "<--";
            btn_backListStaff.UseVisualStyleBackColor = false;
            btn_backListStaff.Click += btn_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(133, 19, 33);
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 19);
            label1.TabIndex = 32;
            label1.Text = "Quan Ly Nhan Vien";
            label1.Click += label1_Click;
            // 
            // btn_close_log
            // 
            btn_close_log.BackColor = Color.FromArgb(133, 19, 33);
            btn_close_log.Dock = DockStyle.Right;
            btn_close_log.FlatAppearance.BorderSize = 0;
            btn_close_log.FlatStyle = FlatStyle.Flat;
            btn_close_log.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_log.ForeColor = Color.White;
            btn_close_log.Location = new Point(747, 0);
            btn_close_log.Name = "btn_close_log";
            btn_close_log.Size = new Size(29, 34);
            btn_close_log.TabIndex = 31;
            btn_close_log.Text = "X";
            btn_close_log.UseVisualStyleBackColor = false;
            btn_close_log.Click += btn_close_log_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(133, 19, 33);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(15, 78);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(426, 360);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(133, 19, 33);
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 5;
            label3.Text = "List staff";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(133, 19, 33);
            label2.Location = new Point(530, 58);
            label2.Name = "label2";
            label2.Size = new Size(182, 18);
            label2.TabIndex = 6;
            label2.Text = "Dien thong tin nhan vien";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(133, 19, 33);
            label4.Location = new Point(19, 32);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(133, 19, 33);
            label5.Location = new Point(19, 91);
            label5.Name = "label5";
            label5.Size = new Size(68, 16);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(133, 19, 33);
            label6.Location = new Point(19, 152);
            label6.Name = "label6";
            label6.Size = new Size(75, 16);
            label6.TabIndex = 9;
            label6.Text = "Trang Thai";
            // 
            // txt_passwd_addstaff
            // 
            txt_passwd_addstaff.Location = new Point(34, 110);
            txt_passwd_addstaff.Name = "txt_passwd_addstaff";
            txt_passwd_addstaff.Size = new Size(258, 22);
            txt_passwd_addstaff.TabIndex = 10;
            // 
            // txt_usrname_addstaff
            // 
            txt_usrname_addstaff.Location = new Point(34, 51);
            txt_usrname_addstaff.Name = "txt_usrname_addstaff";
            txt_usrname_addstaff.Size = new Size(258, 22);
            txt_usrname_addstaff.TabIndex = 11;
            // 
            // cb_status_addstaff
            // 
            cb_status_addstaff.FormattingEnabled = true;
            cb_status_addstaff.Items.AddRange(new object[] { "dang lam", "nghi" });
            cb_status_addstaff.Location = new Point(34, 171);
            cb_status_addstaff.Name = "cb_status_addstaff";
            cb_status_addstaff.Size = new Size(121, 24);
            cb_status_addstaff.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_deletestaff);
            groupBox1.Controls.Add(btn_upstaff);
            groupBox1.Controls.Add(btn_addstaff);
            groupBox1.Controls.Add(cb_status_addstaff);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_passwd_addstaff);
            groupBox1.Controls.Add(txt_usrname_addstaff);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(133, 19, 13);
            groupBox1.Location = new Point(447, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 359);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin Nhan Vien";
            // 
            // btn_deletestaff
            // 
            btn_deletestaff.BackColor = Color.FromArgb(133, 19, 33);
            btn_deletestaff.FlatAppearance.BorderSize = 0;
            btn_deletestaff.FlatStyle = FlatStyle.Flat;
            btn_deletestaff.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deletestaff.ForeColor = Color.White;
            btn_deletestaff.Location = new Point(232, 243);
            btn_deletestaff.Name = "btn_deletestaff";
            btn_deletestaff.Size = new Size(77, 27);
            btn_deletestaff.TabIndex = 44;
            btn_deletestaff.Text = "delete";
            btn_deletestaff.UseVisualStyleBackColor = false;
            btn_deletestaff.Click += btn_deletestaff_Click;
            // 
            // btn_upstaff
            // 
            btn_upstaff.BackColor = Color.FromArgb(133, 19, 33);
            btn_upstaff.FlatAppearance.BorderSize = 0;
            btn_upstaff.FlatStyle = FlatStyle.Flat;
            btn_upstaff.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_upstaff.ForeColor = Color.White;
            btn_upstaff.Location = new Point(130, 243);
            btn_upstaff.Name = "btn_upstaff";
            btn_upstaff.Size = new Size(77, 27);
            btn_upstaff.TabIndex = 43;
            btn_upstaff.Text = "update";
            btn_upstaff.UseVisualStyleBackColor = false;
            btn_upstaff.Click += btn_upstaff_Click;
            // 
            // btn_addstaff
            // 
            btn_addstaff.BackColor = Color.FromArgb(133, 19, 33);
            btn_addstaff.FlatAppearance.BorderSize = 0;
            btn_addstaff.FlatStyle = FlatStyle.Flat;
            btn_addstaff.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addstaff.ForeColor = Color.White;
            btn_addstaff.Location = new Point(19, 243);
            btn_addstaff.Name = "btn_addstaff";
            btn_addstaff.Size = new Size(77, 27);
            btn_addstaff.TabIndex = 42;
            btn_addstaff.Text = "add";
            btn_addstaff.UseVisualStyleBackColor = false;
            btn_addstaff.Click += btn_addstaff_Click;
            // 
            // addStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addStaff";
            Text = "addStaff";
            Load += addStaff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_close_log;
        private DataGridView dataGridView2;
        private Label label3;
        private Button btn_backListStaff;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_passwd_addstaff;
        private TextBox txt_usrname_addstaff;
        private ComboBox cb_status_addstaff;
        private GroupBox groupBox1;
        private Button btn_addstaff;
        private Button btn_upstaff;
        private Button btn_deletestaff;
    }
}