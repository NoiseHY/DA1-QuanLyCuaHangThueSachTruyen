using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_TTNguoiDung : Form
    {
        string username = "";
        BUS_TTNguoiDung BUS_TTNguoiDung = new BUS_TTNguoiDung();
        public GUI_TTNguoiDung()
        {
            InitializeComponent();
        }
        public GUI_TTNguoiDung(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        void loadData()
        {
            txtID.Text = BUS_TTNguoiDung.getTT(username).Rows[0]["tenNguoidung"].ToString();
            txtName.Text = BUS_TTNguoiDung.getTT(username).Rows[0]["tenDaydu"].ToString();
            txtEmail.Text = BUS_TTNguoiDung.getTT(username).Rows[0]["email"].ToString();
            txtNb.Text = BUS_TTNguoiDung.getTT(username).Rows[0]["sodienthoai"].ToString();
            txtAdress.Text = BUS_TTNguoiDung.getTT(username).Rows[0]["diachi"].ToString();
        }
        private void GUI_TTNguoiDung_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Sửa không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO_TTNguoiDung dTO_TTNguoiDung = new DTO_TTNguoiDung(txtID.Text,txtName.Text, txtEmail.Text, txtNb.Text, txtAdress.Text);
                if (BUS_TTNguoiDung.suaTT(dTO_TTNguoiDung))
                {
                    MessageBox.Show("Sửa thành công thông tin người dùng!");
                    loadData();
                }
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtNb.Text.Length == 10 && txtNb.Text.StartsWith("0"))
            {
                e.Cancel = false;
                erSdt.SetError(txtNb, "");
            }
            else
            {
                e.Cancel = true;
                txtNb.Focus();
                erSdt.SetError(txtNb, "Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0");
            }
        }
        private bool ktraEmail(string email)
        {
            // Kiểm tra logic để xác định tính hợp lệ của email

            if (string.IsNullOrEmpty(email))
                return false;

            // Kiểm tra xem email có chứa ký tự @ và ít nhất một dấu chấm
            if (!email.Contains("@") || !email.Contains("."))
                return false;

            // Kiểm tra xem dấu chấm cuối cùng có nằm sau ký tự @ hay không
            if (email.LastIndexOf(".") < email.IndexOf("@"))
                return false;

            return true;
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;

            if (ktraEmail(email))
            {
                e.Cancel = false;
                erEmail.SetError(txtEmail, "");
            }
            else
            {
                e.Cancel = true;
                txtEmail.Focus();
                erEmail.SetError(txtEmail, "Email không hợp lệ");
            }
        }

        private void erDC_Validating(object sender, CancelEventArgs e)
        {
            string address = txtAdress.Text;

            if (!string.IsNullOrEmpty(address))
            {
                e.Cancel = false;
                erAddress.SetError(txtAdress, "");
            }
            else
            {
                e.Cancel = true;
                txtAdress.Focus();
                erAddress.SetError(txtAdress, "Vui lòng nhập địa chỉ");
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string userName = txtName.Text;

            if (!string.IsNullOrEmpty(userName))
            {
                e.Cancel = false;
                erUserName.SetError(txtName, "");
            }
            else
            {
                e.Cancel = true;
                txtName.Focus();
                erUserName.SetError(txtName, "Vui lòng nhập tên người dùng");
            }
        }
    }
}
