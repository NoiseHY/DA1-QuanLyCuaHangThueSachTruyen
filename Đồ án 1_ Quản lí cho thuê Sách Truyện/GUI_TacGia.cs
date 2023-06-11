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
using static System.Windows.Forms.AxHost;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_TacGia : Form
    {
        BUS_TacGia tacGia = new BUS_TacGia();
        public GUI_TacGia()
        {
            InitializeComponent();
        }

        private void GUI_TacGia_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = tacGia.getTacGia();
        }
        void cd()
        {

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
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm tác giả {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int ns;
                if (!int.TryParse(txtNs.Text, out ns))
                {
                    MessageBox.Show("Năm sinh chưa nhập");
                    return;
                }

                
                DTO_TacGia dTO_TacGia = new DTO_TacGia(txtID.Text, txtName.Text, ns, txtQuoctich.Text);
                if (tacGia.ktra(dTO_TacGia.maTG) == 1)
                {
                    MessageBox.Show("Mã tác giả đã trùng !!");
                }
                else
                {
                    if (tacGia.themTacgia(dTO_TacGia) == true)
                    {
                        MessageBox.Show("Thêm tác giả thành công !!");
                        dtgvHT.DataSource = tacGia.getTacGia();
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
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Sửa tác giả {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO_TacGia dTO_TacGia = new DTO_TacGia(txtID.Text, txtName.Text, int.Parse(txtNs.Text), txtQuoctich.Text);

                if (tacGia.suaTacgia(dTO_TacGia) == true)
                {
                    MessageBox.Show("Sửa thành công tác giả");
                    dtgvHT.DataSource = tacGia.getTacGia();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa tác giả {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (tacGia.xoaTacgia(txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công !");
                    dtgvHT.DataSource = tacGia.getTacGia();
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
                txtQuoctich.Text = dtgvHT[2, hang].Value.ToString();
                txtNs.Text = dtgvHT[3, hang].Value.ToString();
                txtID.Enabled = false;
            }
            catch
            {

            }
        }

        private void txtNs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
