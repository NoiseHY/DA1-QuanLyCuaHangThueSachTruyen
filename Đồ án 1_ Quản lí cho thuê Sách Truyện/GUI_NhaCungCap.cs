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
    public partial class GUI_NhaCungCap : Form
    {
        BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();
        public GUI_NhaCungCap()
        {
            InitializeComponent();
        }
        private void GUI_NhaCungCap_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = BUS_NhaCungCap.getNCC();
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

        private void btThem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm nhà cung cấp {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO_NhaCungCap dTO_NhaCungCap = new DTO_NhaCungCap(txtID.Text, txtName.Text, txtAdress.Text, txtNb.Text, txtEmail.Text);
                if (BUS_NhaCungCap.ktra(dTO_NhaCungCap.maNCC) == 1)
                {
                    MessageBox.Show("Mã nhà xuất bản đã trùng !!");
                }
                else
                {
                    if (BUS_NhaCungCap.them(dTO_NhaCungCap) == true)
                    {
                        MessageBox.Show("Thêm nhà xuất bản thành công !!");
                        dtgvHT.DataSource = BUS_NhaCungCap.getNCC();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Sửa nhà cung cấp {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO_NhaCungCap dTO_NhaCungCap = new DTO_NhaCungCap(txtID.Text, txtName.Text, txtAdress.Text, txtNb.Text, txtEmail.Text);

                if (BUS_NhaCungCap.sua(dTO_NhaCungCap) == true)
                {
                    MessageBox.Show("Sửa thành công nhà cung cấp");
                    dtgvHT.DataSource = BUS_NhaCungCap.getNCC();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa nhà cung cấp {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (BUS_NhaCungCap.xoa(txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công !");
                    dtgvHT.DataSource = BUS_NhaCungCap.getNCC();
                }
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtID.Text = dtgvHT[0, hang].Value.ToString();
                txtName.Text = dtgvHT[1, hang].Value.ToString();
                txtAdress.Text = dtgvHT[2, hang].Value.ToString();
                txtNb.Text = dtgvHT[3, hang].Value.ToString();
                txtEmail.Text = dtgvHT[4, hang].Value.ToString();
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
    }
}
