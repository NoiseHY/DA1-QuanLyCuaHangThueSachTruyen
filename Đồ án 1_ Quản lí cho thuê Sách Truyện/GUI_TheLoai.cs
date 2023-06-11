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
    public partial class GUI_TheLoai : Form
    {
        BUS_TheLoai BUS_TheLoai = new BUS_TheLoai();
        public GUI_TheLoai()
        {
            InitializeComponent();
        }

        private void GUI_TheLoai_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = BUS_TheLoai.getTL();
        }

        private void dtgvHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtID.Text = dtgvHT[0, hang].Value.ToString();
            txtName.Text = dtgvHT[1, hang].Value.ToString();
            txtMta.Text = dtgvHT[2, hang].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm thể loại với mã {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO_TheLoai dTO_TheLoai = new DTO_TheLoai(txtID.Text, txtName.Text, txtMta.Text);
                if (BUS_TheLoai.ktra(dTO_TheLoai.maTL) == 1)
                {
                    MessageBox.Show("Mã thể loại đã trùng !!");
                }
                else if (BUS_TheLoai.ktraT(dTO_TheLoai.tenTl)==1)
                {
                    MessageBox.Show("Đã có thể loại này rồi !!");
                }
                else
                {
                    if (BUS_TheLoai.themTL(dTO_TheLoai) == true)
                    {
                        MessageBox.Show("Thêm thể loại thành công !!");
                        dtgvHT.DataSource = BUS_TheLoai.getTL();

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
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Sửa thể loại {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO_TheLoai dTO_TheLoai = new DTO_TheLoai(txtID.Text, txtName.Text, txtMta.Text);
                if (BUS_TheLoai.suaTL(dTO_TheLoai))
                {
                    MessageBox.Show("Sửa thành công thể loại");
                    dtgvHT.DataSource = BUS_TheLoai.getTL();
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
                txtName.Enabled = true;
            }
        }

        private void dtgvHT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa thể loại {0} không ??", txtName.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (BUS_TheLoai.xoaTL(txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công !");
                    dtgvHT.DataSource = BUS_TheLoai.getTL();
                }
            }

        }

        private void dtgvHT_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtID.Text = dtgvHT[0, hang].Value.ToString();
                txtName.Text = dtgvHT[1, hang].Value.ToString();
                txtMta.Text = dtgvHT[2, hang].Value.ToString();
                txtID.Enabled = false;
                txtName.Enabled = false;
            }
            catch
            {

            }
        }
    }
}
