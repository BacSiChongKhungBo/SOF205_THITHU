namespace SOF205_THITHU.View
{
    partial class Home
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTen = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtIDPhuHuynh = new TextBox();
            txtDiaChi = new TextBox();
            txtSearch = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnShow = new Button();
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 117);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 2;
            label3.Text = "SDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 238);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 157);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 3;
            label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 195);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 4;
            label6.Text = "IdPhuHuynh";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(143, 33);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(334, 23);
            txtTen.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(334, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(143, 114);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(334, 23);
            txtSDT.TabIndex = 7;
            // 
            // txtIDPhuHuynh
            // 
            txtIDPhuHuynh.Location = new Point(143, 192);
            txtIDPhuHuynh.Name = "txtIDPhuHuynh";
            txtIDPhuHuynh.Size = new Size(334, 23);
            txtIDPhuHuynh.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(143, 154);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(334, 23);
            txtDiaChi.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(143, 235);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(334, 23);
            txtSearch.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(525, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(225, 54);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(525, 93);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(225, 54);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(525, 153);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(225, 54);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(525, 218);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(225, 54);
            btnShow.TabIndex = 13;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(25, 275);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(725, 172);
            dtgView.TabIndex = 14;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgView);
            Controls.Add(btnShow);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSearch);
            Controls.Add(txtDiaChi);
            Controls.Add(txtIDPhuHuynh);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtTen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTen;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtIDPhuHuynh;
        private TextBox txtDiaChi;
        private TextBox txtSearch;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnShow;
        private DataGridView dtgView;
    }
}