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
    public partial class GUI_TimKiemSach : Form
    {
        BUS_TimKiemSach BUS_TimKiemSach = new BUS_TimKiemSach();
        public GUI_TimKiemSach()
        {
            InitializeComponent();
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Đang tìm kiếm sách{0}", txtTk.Text));
            DTO_TimKiemSach dTO_TimKiemSach = new DTO_TimKiemSach(txtTk.Text, DateTime.Parse(dtNgay.Value.ToShortDateString()));
            if (cbMa.Checked )
            {
                dtgvHT.DataSource = BUS_TimKiemSach.getSach(dTO_TimKiemSach);
            }
            else if (cbNgay.Checked)
            {
                dtgvHT.DataSource = BUS_TimKiemSach.getNgay(dTO_TimKiemSach);
            }
            else if (cbNN.Checked)
            {
                dtgvHT.DataSource = BUS_TimKiemSach.getNN(dTO_TimKiemSach);
            }
            else if (cbName.Checked)
            {
                dtgvHT.DataSource = BUS_TimKiemSach.getTen(dTO_TimKiemSach);
            }
            else if (cbTL.Checked)
            {
                dtgvHT.DataSource = BUS_TimKiemSach.getTL(dTO_TimKiemSach);
            }
            else if (cbNXB.Checked)
            {
                dtgvHT.DataSource = BUS_TimKiemSach.getNXB(dTO_TimKiemSach);
            }
            else if (cbTG.Checked)
            {
                dtgvHT.DataSource = BUS_TimKiemSach.getTG(dTO_TimKiemSach);
            }
            else if (cbSotrang.Checked)
            {
                float number;
                bool isNumber = float.TryParse(txtTk.Text, out number);
                if (isNumber)
                {
                    // Nếu là số nguyên, thực hiện các thao tác cần thiết
                    // ...
                    dtgvHT.DataSource = BUS_TimKiemSach.getST(number);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!");
                }

            }
            else if (cbSL.Checked)
            {
                int number;
                bool isNumber = int.TryParse(txtTk.Text, out number);
                if (isNumber)
                {
                    // Nếu là số nguyên, thực hiện các thao tác cần thiết
                    // ...
                    dtgvHT.DataSource = BUS_TimKiemSach.getSl(number);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!");
                }
            }
            else if (cbTC.Checked)
            {
                dtgvHT.DataSource = BUS_TimKiemSach.getTC();
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_TimKiemSach_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = BUS_TimKiemSach.getTC();
        }
    }
}
