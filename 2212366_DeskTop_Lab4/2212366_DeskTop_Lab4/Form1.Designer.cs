namespace _2212366_DeskTop_Lab4
{
    partial class Form1
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
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.coMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coPhai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coHinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(12, 12);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(153, 185);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMacDinh);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnChonHinh);
            this.groupBox1.Controls.Add(this.mtxtSDT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtHinh);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.mtxtMSSV);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(171, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 250);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // mtxtMSSV
            // 
            this.mtxtMSSV.Location = new System.Drawing.Point(63, 19);
            this.mtxtMSSV.Mask = "0000000";
            this.mtxtMSSV.Name = "mtxtMSSV";
            this.mtxtMSSV.Size = new System.Drawing.Size(284, 20);
            this.mtxtMSSV.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(63, 46);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(284, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(63, 98);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(284, 20);
            this.txtDiaChi.TabIndex = 3;
            
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(63, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 20);
            this.txtEmail.TabIndex = 2;
            
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(63, 125);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(479, 20);
            this.txtHinh.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(424, 22);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(430, 49);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(528, 49);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 6;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
            this.cboLop.Location = new System.Drawing.Point(424, 72);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(200, 21);
            this.cboLop.TabIndex = 7;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(557, -21);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox2.TabIndex = 18;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(425, 99);
            this.mtxtSDT.Mask = "0000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(199, 20);
            this.mtxtSDT.TabIndex = 8;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(549, 123);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonHinh.TabIndex = 9;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(450, 156);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(548, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(348, 156);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
            this.btnMacDinh.TabIndex = 10;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coMSSV,
            this.coHoTen,
            this.coPhai,
            this.coNgaySinh,
            this.coLop,
            this.coSDT,
            this.coEmail,
            this.coDiaChi,
            this.coHinh});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(782, 231);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // coMSSV
            // 
            this.coMSSV.Text = "MSSV";
            this.coMSSV.Width = 70;
            // 
            // coHoTen
            // 
            this.coHoTen.Text = "Họ và tên";
            this.coHoTen.Width = 170;
            // 
            // coPhai
            // 
            this.coPhai.Text = "Phái";
            // 
            // coNgaySinh
            // 
            this.coNgaySinh.Text = "Ngày sinh";
            // 
            // coLop
            // 
            this.coLop.Text = "Lớp";
            // 
            // coSDT
            // 
            this.coSDT.Text = "Số điện thoại";
            this.coSDT.Width = 100;
            // 
            // coEmail
            // 
            this.coEmail.Text = "Email";
            this.coEmail.Width = 170;
            // 
            // coDiaChi
            // 
            this.coDiaChi.Text = "Địa Chỉ";
            this.coDiaChi.Width = 250;
            // 
            // coHinh
            // 
            this.coHinh.Text = "Hình";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(879, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "label10";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 575);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbHinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtMSSV;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader coMSSV;
        private System.Windows.Forms.ColumnHeader coHoTen;
        private System.Windows.Forms.ColumnHeader coPhai;
        private System.Windows.Forms.ColumnHeader coNgaySinh;
        private System.Windows.Forms.ColumnHeader coLop;
        private System.Windows.Forms.ColumnHeader coSDT;
        private System.Windows.Forms.ColumnHeader coEmail;
        private System.Windows.Forms.ColumnHeader coDiaChi;
        private System.Windows.Forms.ColumnHeader coHinh;
        private System.Windows.Forms.Label label10;
    }
}

