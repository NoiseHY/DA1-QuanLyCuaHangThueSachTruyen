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
    public partial class GUI_DMK : Form
    {
        string username = "";
        string password = "";
        BUS_DMK BUS_DMK = new BUS_DMK();
        public GUI_DMK()
        {
            InitializeComponent();
        }
        public GUI_DMK(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        void loadData()
        {
            txtID.Text = username;
            txtMKC.Text = password;
        }
        
        private void btSua_Click(object sender, EventArgs e)
        {
            int ktra = KiemTra();
            if(ktra == 1)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn mật khẩu không ??", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DTO_DMK dTO_DMK = new DTO_DMK(txtID.Text, txtMKC.Text, txtNLmkc.Text, txtMkm.Text, txtNhapLaimk.Text);
                    if (BUS_DMK.checkMK(dTO_DMK) == true)
                    {
                        if (BUS_DMK.checkMKM(dTO_DMK) == true)
                        {

                            BUS_DMK.doiMK(dTO_DMK);
                            MessageBox.Show("Sửa thành công mật khẩu người dùng!");
                            loadData();
                            MessageBox.Show(string.Format("Đổi thành công mật khẩu thành {0}!", txtMkm.Text), "Vui lòng nhớ mật khẩu vừa đổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Xác nhận mật khẩu mới sai !!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu cũ sai !!!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void GUI_DMK_Load(object sender, EventArgs e)
        {
            loadData();
            
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int KiemTra()
        {
            if (string.IsNullOrEmpty(txtMkm.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
                return 0;
            }
            if (string.IsNullOrEmpty(txtNhapLaimk.Text))
            {
                MessageBox.Show("Vui lòng xác nhận nhập mật khẩu mới");
                return 0;
            }

            // Trả về 1 nếu các điều kiện kiểm tra đều thành công
            return 1;
        }

        private void txtMkm_Validating(object sender, CancelEventArgs e)
        {
            string password = txtMkm.Text;

            if (!string.IsNullOrEmpty(password))
            {
                e.Cancel = false;
                erPassword.SetError(txtMkm, "");
            }
            else
            {
                e.Cancel = true;
                txtMkm.Focus();
                erPassword.SetError(txtMkm, "Vui lòng nhập mật khẩu mới");
            }
        }

        private void txtNhapLaimk_Validating(object sender, CancelEventArgs e)
        {
            string password = txtNhapLaimk.Text;

            if (!string.IsNullOrEmpty(password))
            {
                e.Cancel = false;
                erConfirmPassword.SetError(txtNhapLaimk, "");
            }
            else
            {
                e.Cancel = true;
                txtMkm.Focus();
                erConfirmPassword.SetError(txtNhapLaimk, "Vui lòng xác nhận mật khẩu mới");
            }
        }
    }
}
