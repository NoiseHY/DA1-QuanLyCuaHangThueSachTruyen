using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;
using OfficeOpenXml;
using Exel = Microsoft.Office.Interop.Excel;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_CTNhap : Form
    {
        BUS_CTNhap BUS_CTNhap = new BUS_CTNhap();
        string ma;
        public GUI_CTNhap()
        {
            InitializeComponent();
        }
        public GUI_CTNhap(string ma)
        {
            this.ma = ma;
            InitializeComponent();
        }
        private void GUI_CTNhap_Load(object sender, EventArgs e)
        {
            //
            cbbMasach.DataSource = BUS_CTNhap.getMasach();
            cbbMasach.DisplayMember = "sachID";
            //
            dtgvHT.DataSource = BUS_CTNhap.getData(ma);
            //
            dtgvSach.DataSource = BUS_CTNhap.getSach();
        }
        float tinhtongtien()
        {
            if (txtSl.Text.Length > 0 && txtGia.Text.Length > 0)
            {
                int sl;
                float gia;
                float tt;
                bool isSlValid = int.TryParse(txtSl.Text, out sl);
                bool isGiaValid = float.TryParse(txtGia.Text, out gia);

                if (isSlValid && isGiaValid)
                {
                    tt = sl * gia;
                    return tt;
                }
            }

            return 0;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm chi tiết hóa đơn nhập {0} không ??", txtCT.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                int sl;
                if (!int.TryParse(txtSl.Text, out sl))
                {
                    MessageBox.Show("Giá trị số lượng không hợp lệ.");
                    return;
                }
                int gia;
                if (!int.TryParse(txtGia.Text, out gia))
                {
                    MessageBox.Show("Giá trị của giá không hợp lệ.");
                    return;
                }
                DateTime ngayHT = DateTime.Now;
                DTO_CTNhap dTO_CTNhap = new DTO_CTNhap(txtCT.Text, ma, cbbMasach.Text, sl, gia);
                if (BUS_CTNhap.ktractNhap(dTO_CTNhap.maNhap) == 1)
                {
                    MessageBox.Show("Mã phiếu nhập đã trùng !!");
                }
                else
                {
                    if (BUS_CTNhap.themctNhap(dTO_CTNhap) == true)
                    {
                        MessageBox.Show("Thêm chi tiết hóa đơn nhập thành công !!");
                        BUS_CTNhap.cnSL(cbbMasach.Text, sl);
                        BUS_CTNhap.cnTT(ma, tinhtongtien());
                        MessageBox.Show("Số lượng và tổng tiền đã được cập nhật thành công.");
                        dtgvHT.DataSource = BUS_CTNhap.getData(ma);
                        dtgvSach.DataSource = BUS_CTNhap.getSach();

                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }

        }

        private void btXoact_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa chi tiết hóa đơn nhập có mã hóa đơn {0} không ??", txtCT.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (BUS_CTNhap.xoactNhap(txtCT.Text) == true)
                {
                    MessageBox.Show("Xóa thành công !");
                    dtgvHT.DataSource = BUS_CTNhap.getData(ma);
                    dtgvSach.DataSource = BUS_CTNhap.getSach();

                }
            }

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in grHT2.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Text = "";
                }
                txtCT.Enabled = true;
                cbbMasach.Enabled = true;
            }

        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbbMasach.Text = dtgvSach[0, hang].Value.ToString();
            cbbMasach.Enabled = false;
        }
        //
        private void ExportExcel(string path)
        {
            Exel.Application application = new Exel.Application();
            application.Workbooks.Add(Type.Missing);
            Exel.Worksheet worksheet = application.ActiveSheet;

            // Thêm tiêu đề "Chi tiết hóa đơn nhập" vào ô A1
            worksheet.Cells[1, 8] = "Chi tiết hóa đơn nhập :  " + ma;

            // Tạo tiêu đề cột từ cột H trở đi
            for (int i = 0; i < dtgvHT.Columns.Count; i++)
            {
                worksheet.Cells[3, i + 8] = dtgvHT.Columns[i].HeaderText; 
            }
            for (int i = 0; i < dtgvHT.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvHT.Columns.Count; j++)
                {
                    worksheet.Cells[i + 4, j + 8] = dtgvHT.Rows[i].Cells[j].Value; 
                }
            }

            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;

            application.Quit();
        }


        private void btInHD_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất Excel";
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công :" + ex.Message);

                }
            }
        }

        private void dtgvHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtCT.Text = dtgvHT[0, hang].Value.ToString();
                cbbMasach.Text = dtgvHT[2, hang].Value.ToString();
                txtSl.Text = dtgvHT[3, hang].Value.ToString();
                txtGia.Text = dtgvHT[4, hang].Value.ToString();
                txtCT.Enabled = false;
            }
            catch
            {

            }
        }
    }
}
