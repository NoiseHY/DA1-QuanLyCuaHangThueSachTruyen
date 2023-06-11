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
    public partial class GUI_TKSachMuon : Form
    {
        BUS_TKSachMuon BUS_TKSachMuon = new BUS_TKSachMuon();
        public GUI_TKSachMuon()
        {
            InitializeComponent();
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Đang tìm kiếm phiếu mượn{0}", txtTk.Text));
            DTO_TKSachMuon dTO_TKSachMuon = new DTO_TKSachMuon(txtTk.Text, DateTime.Parse(dtMuon.Text), DateTime.Parse(dtTra.Text));   
            if (cbMa.Checked)
            {
                dtgvHT.DataSource = BUS_TKSachMuon.get(dTO_TKSachMuon);
            }
            else if (cbNgayM.Checked)
            {
                dtgvHT.DataSource = BUS_TKSachMuon.getNgayM(dTO_TKSachMuon);
            }
            else if (cbNgayT.Checked)
            {
                dtgvHT.DataSource = BUS_TKSachMuon.getNgayT(dTO_TKSachMuon);
            }
            else if (cbDG.Checked)
            {
                dtgvHT.DataSource = BUS_TKSachMuon.getDG(dTO_TKSachMuon);
            }
            else if (cbCT.Checked)
            {
                dtgvHT.DataSource = BUS_TKSachMuon.get(dTO_TKSachMuon);
            }
            else if (cbMaSach.Checked)
            {
                dtgvHT.DataSource = BUS_TKSachMuon.getMasach(dTO_TKSachMuon);
            }           
            else if (cbSLm.Checked)
            {
                int number;
                bool isNumber = int.TryParse(txtTk.Text, out number);
                if (isNumber)
                {
                    // Nếu là số nguyên, thực hiện các thao tác cần thiết
                    // ...
                    dtgvHT.DataSource = BUS_TKSachMuon.getSlm(number);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!");
                }

            }
            else if (cbSLt.Checked)
            {
                int number;
                bool isNumber = int.TryParse(txtTk.Text, out number);
                if (isNumber)
                {
                    // Nếu là số nguyên, thực hiện các thao tác cần thiết
                    // ...
                    dtgvHT.DataSource = BUS_TKSachMuon.getSlt(number);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!");
                }
            }
            else if (cbTC.Checked)
            {
                dtgvHT.DataSource = BUS_TKSachMuon.getTC();
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_TKSachMuon_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = BUS_TKSachMuon.getTC();
        }
    }
}
