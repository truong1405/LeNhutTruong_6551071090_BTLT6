using System;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapChuong5
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;
            Control loiDauTien = null;

            Action<Control, string> datLoi = (ctl, msg) =>
            {
                errorProvider1.SetError(ctl, msg);
                if (msg != "")
                {
                    hopLe = false;
                    if (loiDauTien == null) loiDauTien = ctl;
                }
            };

            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "")
                datLoi(txtHoTen, "Họ tên không được để trống");
            else if (hoTen.Length < 3)
                datLoi(txtHoTen, "Họ tên phải có tối thiểu 3 ký tự");
            else
                datLoi(txtHoTen, "");

            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10 || !sdt.All(char.IsDigit) || !sdt.StartsWith("0"))
                datLoi(txtSDT, "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0");
            else
                datLoi(txtSDT, "");

            string email = txtEmail.Text.Trim();
            int viTriAt = email.IndexOf('@');
            if (viTriAt <= 0 || email.IndexOf('.', viTriAt + 1) <= viTriAt + 1
                || email.EndsWith("."))
                datLoi(txtEmail, "Email không đúng định dạng");
            else
                datLoi(txtEmail, "");

            if (txtMatKhau.Text.Length < 6)
                datLoi(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự");
            else
                datLoi(txtMatKhau, "");

            if (txtXacNhanMK.Text != txtMatKhau.Text)
                datLoi(txtXacNhanMK, "Xác nhận mật khẩu không khớp");
            else
                datLoi(txtXacNhanMK, "");

            if (loiDauTien != null) loiDauTien.Focus();
            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            Close();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
