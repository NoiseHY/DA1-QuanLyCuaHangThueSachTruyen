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
    public partial class GUI_TKTG : Form
    {
        BUS_TKTG BUS_TKTG = new BUS_TKTG();
        public GUI_TKTG()
        {
            InitializeComponent();
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Đang tìm kiếm tác giả {0}", txtTk.Text));
            DTO_TKTG dTO_TKTG = new DTO_TKTG(txtTk.Text);
            if (cbMa.Checked)
            {
                dtgvHT.DataSource = BUS_TKTG.getTG(dTO_TKTG);
            }
            else if (cbName.Checked)
            {
                dtgvHT.DataSource = BUS_TKTG.getTen(dTO_TKTG);
            }
            else if (cbbQT.Checked)
            {
                dtgvHT.DataSource = BUS_TKTG.getQt(dTO_TKTG);
            }
            else if (cbbNS.Checked)
            {
                int number;
                bool isNumber = int.TryParse(txtTk.Text, out number);
                if (isNumber)
                {
                    // Nếu là số nguyên, thực hiện các thao tác cần thiết
                    // ...
                    dtgvHT.DataSource = BUS_TKTG.getNamS(number);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!");
                }

            }
            else if (cbbNammat.Checked)
            {
                int number;
                bool isNumber = int.TryParse(txtTk.Text, out number);
                if (isNumber)
                {
                    // Nếu là số nguyên, thực hiện các thao tác cần thiết
                    // ...
                    dtgvHT.DataSource = BUS_TKTG.getNamM(number);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!");
                }
            }
            else if (cbTC.Checked)
            {
                dtgvHT.DataSource = BUS_TKTG.getTC();
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_TKTG_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = BUS_TKTG.getTC();
        }
    }
}
