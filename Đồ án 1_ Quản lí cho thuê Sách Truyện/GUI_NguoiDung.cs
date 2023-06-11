using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_NguoiDung : Form
    {
        BUS_NguoiDung bUS_NguoiDung = new BUS_NguoiDung();

        public GUI_NguoiDung()
        {
            InitializeComponent();
        }

        private void GUI_NguoiDung_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = bUS_NguoiDung.getNguoiDung();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int ktra = KiemTra();
            if(ktra == 1)
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm người dùng {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // truyền dữ liệ từ GUI sang DTO
                    DTO_NguoiDung nguoiDung = new DTO_NguoiDung(txtID.Text, txtName.Text, txtMk.Text, txtHvT.Text, txtNb.Text, txtAdress.Text, txtEmail.Text, txtQuyen.Text);
                    if (bUS_NguoiDung.ktra(nguoiDung.maND) == 1)
                    {
                        MessageBox.Show("Mã người dùng đã trùng !!");

                    }
                    else
                    {
                        if(bUS_NguoiDung.ktraND(nguoiDung.tenND) == 1)
                        {
                            MessageBox.Show("Mã tên người dùng đã trùng");

                        }
                        else
                        {
                            if (bUS_NguoiDung.themND(nguoiDung) == true)
                            {
                                MessageBox.Show("Thêm người dùng thành công !!");
                                dtgvHT.DataSource = bUS_NguoiDung.getNguoiDung();
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại");
                            }
                        }
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int ktra = KiemTra();
            if(ktra == 1)
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Sửa người dùng {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DTO_NguoiDung nguoiDung = new DTO_NguoiDung(txtID.Text, txtName.Text, txtMk.Text, txtHvT.Text, txtNb.Text, txtAdress.Text, txtEmail.Text, txtQuyen.Text);
                    if (bUS_NguoiDung.suaND(nguoiDung) == true)
                    {
                        MessageBox.Show("Sửa thành công người dùng");
                        dtgvHT.DataSource = bUS_NguoiDung.getNguoiDung();
                    }
                }

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Xóa người dùng {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                if(bUS_NguoiDung.xoaND(txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công người dùng");
                    dtgvHT.DataSource = bUS_NguoiDung.getNguoiDung();
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in grHT.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Text = "";
                }
                if (ctr is ComboBox)
                {
                    (ctr as ComboBox).Text = "";
                }
                txtID.Enabled = true;
            }
        }

        private void dtgvHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtID.Text = dtgvHT[0, hang].Value.ToString();
                txtName.Text = dtgvHT[1, hang].Value.ToString();
                txtMk.Text = dtgvHT[2, hang].Value.ToString();
                txtEmail.Text = dtgvHT[3, hang].Value.ToString();
                txtHvT.Text = dtgvHT[4, hang].Value.ToString();
                txtNb.Text = dtgvHT[5, hang].Value.ToString();
                txtAdress.Text = dtgvHT[6, hang].Value.ToString();
                txtQuyen.Text = dtgvHT[7, hang].Value.ToString();
                txtID.Enabled = false;
            }
            catch
            {

            }
        }

        

        private void txtNb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNb_Validating(object sender, CancelEventArgs e)
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
        int KiemTra()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã người dùng");
                return 0;
            }
            if (string.IsNullOrEmpty(txtHvT.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên");
                return 0;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng");
                return 0;
            }
            if (string.IsNullOrEmpty(txtMk.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu ");
                return 0;
            }
            if (string.IsNullOrEmpty(txtAdress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return 0;
            }
            if (string.IsNullOrEmpty(txtNb.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return 0;
            }
            if (string.IsNullOrEmpty(txtQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã quyền");
                return 0;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email");
                return 0;
            }
            // Trả về 1 nếu các điều kiện kiểm tra đều thành công
            return 1;
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

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
