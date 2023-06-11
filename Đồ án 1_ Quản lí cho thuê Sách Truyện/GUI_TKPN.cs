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
    public partial class GUI_TKPN : Form
    {
        BUS_TKPN BUS_TKPN = new BUS_TKPN();
        public GUI_TKPN()
        {
            InitializeComponent();
        }
        

        private void btTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Đang tìm kiếm hóa đơn nhập{0}", txtTk.Text));
            DTO_TKPN dTO_TKPN = new DTO_TKPN(txtTk.Text, dtNgay.Value.Date);

            if (cbMa.Checked)
            {
                dtgvHT.DataSource = BUS_TKPN.getID(dTO_TKPN);
            }
            else if (cbNgay.Checked)
            {
                dtgvHT.DataSource = BUS_TKPN.getNgay(dTO_TKPN);
            }
            else if (cbCT.Checked)
            {
                dtgvHT.DataSource = BUS_TKPN.getCT(dTO_TKPN);
            }
            else if (cbMasach.Checked)
            {
                dtgvHT.DataSource = BUS_TKPN.getSach(dTO_TKPN);
            }
            else if (cbGia.Checked)
            {
                float number;
                bool isNumber = float.TryParse(txtTk.Text, out number);
                if (isNumber)
                {
                    // Nếu là số nguyên, thực hiện các thao tác cần thiết
                    // ...
                    dtgvHT.DataSource = BUS_TKPN.getGia(number);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!");
                }

            }
            else if (cbNCC.Checked)
            {
                dtgvHT.DataSource = BUS_TKPN.getNCC(dTO_TKPN);
            }
            else if (cbTC.Checked)
            {              
                dtgvHT.DataSource = BUS_TKPN.getTC();
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_TKPN_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = BUS_TKPN.getTC();
        }
    }
}
