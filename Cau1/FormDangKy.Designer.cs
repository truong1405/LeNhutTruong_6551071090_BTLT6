namespace BaiTapChuong5
{
    partial class FormDangKy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDe = new System.Windows.Forms.Label();
            lblPhuDe = new System.Windows.Forms.Label();
            lblHoTen = new System.Windows.Forms.Label();
            lblSDT = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblMatKhau = new System.Windows.Forms.Label();
            lblXacNhanMK = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            txtSDT = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtMatKhau = new System.Windows.Forms.TextBox();
            txtXacNhanMK = new System.Windows.Forms.TextBox();
            btnDangKy = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblTieuDe.Location = new System.Drawing.Point(23, 16);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new System.Drawing.Size(256, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Đăng ký tài khoản mới";
            // 
            // lblPhuDe
            // 
            lblPhuDe.AutoSize = true;
            lblPhuDe.Location = new System.Drawing.Point(25, 56);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new System.Drawing.Size(214, 20);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new System.Drawing.Point(11, 104);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(143, 27);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSDT
            // 
            lblSDT.Location = new System.Drawing.Point(11, 151);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new System.Drawing.Size(143, 27);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.Location = new System.Drawing.Point(11, 197);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(143, 27);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Location = new System.Drawing.Point(11, 244);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new System.Drawing.Size(143, 27);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblXacNhanMK
            // 
            lblXacNhanMK.Location = new System.Drawing.Point(11, 291);
            lblXacNhanMK.Name = "lblXacNhanMK";
            lblXacNhanMK.Size = new System.Drawing.Size(143, 27);
            lblXacNhanMK.TabIndex = 6;
            lblXacNhanMK.Text = "Xác nhận mật khẩu";
            lblXacNhanMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new System.Drawing.Point(166, 100);
            txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(217, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(166, 147);
            txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(217, 27);
            txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(166, 193);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(217, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new System.Drawing.Point(166, 240);
            txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new System.Drawing.Size(217, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new System.Drawing.Point(166, 287);
            txtXacNhanMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new System.Drawing.Size(217, 27);
            txtXacNhanMK.TabIndex = 4;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDangKy.ForeColor = System.Drawing.Color.White;
            btnDangKy.Location = new System.Drawing.Point(171, 360);
            btnDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new System.Drawing.Size(103, 43);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.CausesValidation = false;
            btnHuy.Location = new System.Drawing.Point(286, 360);
            btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(103, 43);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDangKy
            // 
            AcceptButton = btnDangKy;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnHuy;
            ClientSize = new System.Drawing.Size(480, 440);
            Controls.Add(lblTieuDe);
            Controls.Add(lblPhuDe);
            Controls.Add(lblHoTen);
            Controls.Add(lblSDT);
            Controls.Add(lblEmail);
            Controls.Add(lblMatKhau);
            Controls.Add(lblXacNhanMK);
            Controls.Add(txtHoTen);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtMatKhau);
            Controls.Add(txtXacNhanMK);
            Controls.Add(btnDangKy);
            Controls.Add(btnHuy);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormDangKy";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacNhanMK;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
