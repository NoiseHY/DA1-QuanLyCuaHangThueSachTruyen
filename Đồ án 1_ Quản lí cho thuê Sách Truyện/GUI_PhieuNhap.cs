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
using System.IO;
using OfficeOpenXml;
using Exel = Microsoft.Office.Interop.Excel;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_PhieuNhap : Form
    {
        BUS_PhieuPhap phieuPhap = new BUS_PhieuPhap();
        public GUI_PhieuNhap()
        {
            InitializeComponent();
        }
        void load()
        {
            cbbID.DataSource = phieuPhap.getMaNhap();
            cbbID.DisplayMember = "phieunhapID";
            //
            cbbNCC.DataSource = phieuPhap.getMaNCC();
            cbbNCC.DisplayMember = "nhacungcapID";
            //
            txttenNCC.Text = phieuPhap.gettenNCC(cbbNCC.Text).Rows[0][1].ToString();
            //
            dtgvHT.DataSource = phieuPhap.getPhieunhap();
            //
            dtgvCT.DataSource = phieuPhap.getCT(cbbID.Text);

        }
        private void GUI_PhieuNhap_Load(object sender, EventArgs e)
        {
            load();
            
        }
        
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (cbbID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
            else if (cbbNCC.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm phiếu nhập {0} không ??", cbbID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    float tt;
                    if (!float.TryParse(txtTT.Text, out tt))
                    {
                        tt = 0;
                    }


                    DateTime ngayHT = DateTime.Now;
                    DTO_PhieuNhap dTO_Phieu = new DTO_PhieuNhap(cbbID.Text, cbbNCC.Text, ngayHT, tt);
                    if (phieuPhap.ktraNhap(dTO_Phieu.maNhap) == 1)
                    {
                        MessageBox.Show("Mã phiếu nhập đã trùng !!");
                    }
                    else
                    {
                        if (phieuPhap.themNhap(dTO_Phieu) == true)
                        {
                            MessageBox.Show("Thêm phiếu mượn thành công !!");
                            load();

                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                }

            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbbID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
            else if (cbbNCC.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa phiếu nhập có mã hóa đơn {0} không ??", cbbID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (phieuPhap.xoaNhap(cbbID.Text) == true)
                    {
                        MessageBox.Show("Xóa thành công !");
                        load();
                    }
                }

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbbID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
            else if (cbbNCC.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Sửa phiếu nhập có mã {0} không ??", cbbID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    float tt;
                    if (!float.TryParse(txtTT.Text, out tt))
                    {
                        tt = 0;
                    }


                    DateTime ngayHT = DateTime.Now;
                    DTO_PhieuNhap dTO_Phieu = new DTO_PhieuNhap(cbbID.Text, cbbNCC.Text, ngayHT, tt);
                    if (phieuPhap.suaNhap(dTO_Phieu) == true)
                    {
                        MessageBox.Show("Sửa thành công mã hóa đơn");
                        load();
                    }
                }

            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = phieuPhap.gettenNCC(cbbNCC.Text);
            if (dt.Rows.Count > 0)
            {
                txttenNCC.Text = phieuPhap.gettenNCC(cbbNCC.Text).Rows[0][1].ToString();
            }
            else
            {
                // Xử lý nếu bảng dữ liệu trả về không có bất kỳ hàng nào.
            }
        }

        private void dtgvHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cbbID.Text = dtgvHT[0, hang].Value.ToString();
                cbbNCC.Text = dtgvHT[1, hang].Value.ToString();
                txtTT.Text = dtgvHT[3, hang].Value.ToString();
                cbbID.Enabled = false;

            }
            catch
            {

            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {

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

        private void btRefresh_Click_1(object sender, EventArgs e)
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
            }
            cbbID.Enabled = true;
            dtgvHT.DataSource = phieuPhap.getPhieunhap();

        }

        private void dtgvHT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GUI_CTNhap gUI_CTNhap = new GUI_CTNhap(cbbID.Text);
            gUI_CTNhap.Show();
        }

        private void ExportExcel(string path)
        {
            Exel.Application application = new Exel.Application();
            application.Workbooks.Add(Type.Missing);
            Exel.Worksheet worksheet = application.ActiveSheet;

            // Thêm tiêu đề "Chi tiết hóa đơn nhập"
            worksheet.Cells[1, 8] = "Hóa đơn nhập :  " + cbbID.Text;

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


        private void ImportExcel(string path)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
                {
                    if (excelPackage.Workbook.Worksheets.Count > 0)
                    {
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                        DataTable dataTable = new DataTable();

                        int startColumn = excelWorksheet.Dimension.Start.Column;
                        int endColumn = excelWorksheet.Dimension.End.Column;
                        int startRow = excelWorksheet.Dimension.Start.Row;
                        int endRow = excelWorksheet.Dimension.End.Row;

                        for (int i = startColumn; i <= endColumn; i++)
                        {
                            var cellValue = excelWorksheet.Cells[startRow, i]?.Value;
                            string columnName = cellValue != null ? cellValue.ToString() : string.Empty;
                            dataTable.Columns.Add(columnName);
                        }

                        for (int i = startRow + 1; i <= endRow; i++)
                        {
                            List<string> listRows = new List<string>();

                            for (int j = startColumn; j <= endColumn; j++)
                            {
                                var cellValue = excelWorksheet.Cells[i, j]?.Value;
                                string cellData = cellValue != null ? cellValue.ToString() : string.Empty;
                                listRows.Add(cellData);
                            }

                            dataTable.Rows.Add(listRows.ToArray());
                        }

                        dtgvHT.DataSource = dataTable;
                    }
                    else
                    {
                        //Xử lý trường hợp file Excel không chứa sheet nào
                        MessageBox.Show("Tệp Excel không chứa bất kỳ trang tính nào.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình nhập:" + ex.Message);
            }
        }



        private void btXuatExel_Click(object sender, EventArgs e)
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

        private void btNhapExel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập Excel";
            openFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công :" + ex.Message);

                }
            }
        }

        private void cbbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvCT.DataSource = phieuPhap.getCT(cbbID.Text);
        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTT.Text) || txtTT.Text == "0")
                return;

            decimal number;
            if (decimal.TryParse(txtTT.Text, System.Globalization.NumberStyles.Currency, null, out number))
            {
                txtTT.Text = number.ToString("N0");
                txtTT.SelectionStart = txtTT.Text.Length;
            }

        }
    }
}
