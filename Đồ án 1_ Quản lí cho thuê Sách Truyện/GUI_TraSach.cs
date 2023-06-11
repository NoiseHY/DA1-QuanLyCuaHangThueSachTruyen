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
using System.Xml.Linq;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_TraSach : Form
    {
        string ma;
        string maDG;
        BUS_TraSach BUS_TraSach = new BUS_TraSach();
        public GUI_TraSach()
        {
            InitializeComponent();
        }
        public GUI_TraSach( string maDG)
        {
            InitializeComponent();
            this.maDG = maDG;
        }
        private void GUI_TraSach_Load(object sender, EventArgs e)
        {
            dtgvTT.DataSource = BUS_TraSach.getSachMuon(maDG);
            txtID.Text = maDG;
        }

        private void btTra_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có muốn trả sách cho độc giả {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int slt;
                if (!int.TryParse(txtslt.Text, out slt))
                {
                    MessageBox.Show("Vui lòng nhập số lượng trả");
                    return;
                }

                DataTable dt = BUS_TraSach.getsltra(txtMa.Text);
                if (dt.Rows.Count > 0)
                {
                    int sluongt = Convert.ToInt32(dt.Rows[0]["soluongSachMuon"]);
                    if (slt <= sluongt)
                    {
                        DTO_TraSach dTO_TraSach = new DTO_TraSach(txtMa.Text, slt);
                        if (BUS_TraSach.sua(dTO_TraSach))
                        {
                            MessageBox.Show(string.Format("Trả thành công {0} quyển sách", txtslt.Text));
                            BUS_TraSach.CapNhatSoLuong(dTO_TraSach);
                            dtgvTT.DataSource = BUS_TraSach.getSachMuon(maDG);
                        }
                        else
                        {
                            MessageBox.Show("Trả sách thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng trả vượt quá số lượng sách mượn");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sách mượn");
                }
            }
        }


        private void dtgvTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMa.Text = dtgvTT[0, hang].Value.ToString();
                txtslctra.Text = dtgvTT[3, hang].Value.ToString();
                txtID.Enabled = false;
                txtMa.Enabled = false;
                txtslctra.Enabled = false;
            }
            catch { }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            txtslctra.Enabled = true;
            txtMa.Text = "";
            txtslt.Text = "";
            
        }
    }
}
