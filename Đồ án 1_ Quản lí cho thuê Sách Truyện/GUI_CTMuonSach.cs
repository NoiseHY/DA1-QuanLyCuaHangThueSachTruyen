using BLL;
using CrystalDecisions.CrystalReports.Engine;
using Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.InPhieuMuon;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using DataTable = System.Data.DataTable;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_CTMuonSach : Form
    {
        string ma;
        string maDG;
        BUS_CTMuonSach BUS_CTMuonSach = new BUS_CTMuonSach();
        public GUI_CTMuonSach()
        {
            InitializeComponent();
        }
        public GUI_CTMuonSach(string ma, string maDG)
        {
            InitializeComponent();
            this.ma = ma;
            this.maDG = maDG;
        }
        private void dtgvSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtID.Text = dtgvSachMuon[0, hang].Value.ToString();
                txtMaSach.Text = dtgvSachMuon[2, hang].Value.ToString();
                txtslMuon.Text = dtgvSachMuon[3, hang].Value.ToString();
                txtID.Enabled = false;
                txtDG.Enabled = false;
                txtMaSach.Enabled = false;
            }
            catch { }
        }
        void load()
        {
            txtDG.Text = maDG;
            dtgvSachMuon.DataSource = BUS_CTMuonSach.getSachMuon(ma);
            dtgvTV.DataSource = BUS_CTMuonSach.getTV();
        }
        private void GUI_CTMuonSach_Load(object sender, EventArgs e)
        {
            load();
        }

        

        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable dt = BUS_CTMuonSach.getsl(txtMaSach.Text);
            if (dt.Rows.Count > 0)
            {
                int slMuon = int.Parse(txtslMuon.Text);
                string soluong = dt.Rows[0]["soluong"].ToString();
                int sluongm = Convert.ToInt32(soluong);
                if (slMuon < sluongm)
                {
                    DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm sách mượn {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int slm;
                        if (!int.TryParse(txtslMuon.Text, out slm))
                        {
                            MessageBox.Show("Vui lòng nhập số lượng mượn");
                            return;
                        }

                        DTO_CTMuonSach dTO_CTMuonSach = new DTO_CTMuonSach(txtID.Text, ma, txtMaSach.Text, slm);
                        if (BUS_CTMuonSach.ktra(dTO_CTMuonSach.ma) == 1)
                        {
                            MessageBox.Show("Mã sách mượn đã trùng !!");
                        }
                        else
                        {
                            if (BUS_CTMuonSach.them(dTO_CTMuonSach) == true)
                            {
                                MessageBox.Show("Thêm sách mượn thành công !!");
                                BUS_CTMuonSach.capnhatsl(dTO_CTMuonSach);
                                load();
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại");
                            }
                        }
                    }
                }
                else if (slMuon == sluongm)
                {
                    MessageBox.Show("Số lượng sách mượn đã đạt tối đa");
                }
                else
                {
                    MessageBox.Show("Không đủ số lượng sách mượn");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa sách mượn {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (BUS_CTMuonSach.xoa(txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công !");
                    load();
                }
            }

        }
        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaSach.Text = dtgvTV[0, hang].Value.ToString();

            }
            catch { }
        }

        private void txtslMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;   
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtMaSach.Enabled = true;
            txtID.Text = "";
        }

        private void btInPhieu_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu ");
            }
            else
            {
                // Khởi tạo đối tượng report
                cryInPhieuMuon rpt = new cryInPhieuMuon();

                // Gán dữ liệu vào report
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtID"]).Text = ma;
                ((TextObject)rpt.ReportDefinition.ReportObjects["txtDG"]).Text = maDG;


                // Thực hiện truy vấn để lấy dữ liệu
                DataTable dt = BUS_CTMuonSach.InReport(ma);

                // Thêm dữ liệu vào report
                rpt.SetDataSource(dt);

                // Làm mới report --> để rpt rỗng
                rpt.Refresh();

                // Khởi tạo đối tượng form chứa report
                GUI_InPhieuNhap frm = new GUI_InPhieuNhap();
                frm.cryInPhieuMuon.ReportSource = rpt; // Đổ dữ liệu từ dt
                frm.ShowDialog();

            }
        }
    }
}
