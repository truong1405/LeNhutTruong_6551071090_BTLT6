namespace BaiTapChuong5
{
    partial class FormDatPhong
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
            lblHoTen = new System.Windows.Forms.Label();
            lblCCCD = new System.Windows.Forms.Label();
            lblNgayNhan = new System.Windows.Forms.Label();
            lblNgayTra = new System.Windows.Forms.Label();
            lblSoNguoiLon = new System.Windows.Forms.Label();
            lblSoTreEm = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            txtCCCD = new System.Windows.Forms.TextBox();
            txtNgayNhan = new System.Windows.Forms.TextBox();
            txtNgayTra = new System.Windows.Forms.TextBox();
            txtSoNguoiLon = new System.Windows.Forms.TextBox();
            txtSoTreEm = new System.Windows.Forms.TextBox();
            btnDatPhong = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new System.Drawing.Point(69, 20);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(54, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new System.Drawing.Point(69, 100);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new System.Drawing.Size(68, 20);
            lblCCCD.TabIndex = 1;
            lblCCCD.Text = "Số CCCD";
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new System.Drawing.Point(69, 180);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new System.Drawing.Size(225, 20);
            lblNgayNhan.TabIndex = 2;
            lblNgayNhan.Text = "Ngày nhận phòng (dd/MM/yyyy)";
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new System.Drawing.Point(69, 260);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new System.Drawing.Size(211, 20);
            lblNgayTra.TabIndex = 3;
            lblNgayTra.Text = "Ngày trả phòng (dd/MM/yyyy)";
            // 
            // lblSoNguoiLon
            // 
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location = new System.Drawing.Point(69, 340);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new System.Drawing.Size(138, 20);
            lblSoNguoiLon.TabIndex = 4;
            lblSoNguoiLon.Text = "Số người lớn (1 - 4)";
            // 
            // lblSoTreEm
            // 
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location = new System.Drawing.Point(69, 420);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new System.Drawing.Size(117, 20);
            lblSoTreEm.TabIndex = 5;
            lblSoTreEm.Text = "Số trẻ em (0 - 3)";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new System.Drawing.Point(69, 47);
            txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(342, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new System.Drawing.Point(69, 127);
            txtCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new System.Drawing.Size(342, 27);
            txtCCCD.TabIndex = 1;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new System.Drawing.Point(69, 207);
            txtNgayNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new System.Drawing.Size(342, 27);
            txtNgayNhan.TabIndex = 2;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new System.Drawing.Point(69, 287);
            txtNgayTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new System.Drawing.Size(342, 27);
            txtNgayTra.TabIndex = 3;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new System.Drawing.Point(69, 367);
            txtSoNguoiLon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new System.Drawing.Size(342, 27);
            txtSoNguoiLon.TabIndex = 4;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new System.Drawing.Point(69, 447);
            txtSoTreEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new System.Drawing.Size(342, 27);
            txtSoTreEm.TabIndex = 5;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDatPhong.ForeColor = System.Drawing.Color.White;
            btnDatPhong.Location = new System.Drawing.Point(69, 513);
            btnDatPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new System.Drawing.Size(343, 51);
            btnDatPhong.TabIndex = 6;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 627);
            Controls.Add(lblHoTen);
            Controls.Add(lblCCCD);
            Controls.Add(lblNgayNhan);
            Controls.Add(lblNgayTra);
            Controls.Add(lblSoNguoiLon);
            Controls.Add(lblSoTreEm);
            Controls.Add(txtHoTen);
            Controls.Add(txtCCCD);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtNgayTra);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtSoTreEm);
            Controls.Add(btnDatPhong);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormDatPhong";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblSoNguoiLon;
        private System.Windows.Forms.Label lblSoTreEm;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtSoNguoiLon;
        private System.Windows.Forms.TextBox txtSoTreEm;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
