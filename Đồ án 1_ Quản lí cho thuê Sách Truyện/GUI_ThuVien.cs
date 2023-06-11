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
    public partial class GUI_ThuVien : Form
    {
        BUS_ThuVien busthuVien = new BUS_ThuVien();
        public GUI_ThuVien()
        {
            InitializeComponent();
        }

        private void GUI_ThuVien_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = busthuVien.getSach();
            
            // Hiển thị mã của thể loại
            cbbTL.DataSource = busthuVien.getTL();
            cbbTL.DisplayMember = "theloaiID";
            // Hiển thị tên của thể loại
            txtTL.Text = busthuVien.gettenTL(cbbTL.Text).Rows[0][1].ToString();
            
            // Hiển thị mã của tác giả
            cbbTG.DataSource = busthuVien.getTG();
            cbbTG.DisplayMember = "tacgiaID";
            // Hiển thị tên của tác giả
            txtTG.Text = busthuVien.gettenTG(cbbTG.Text).Rows[0][1].ToString();
            
            // Hiển thị mã của nhà xuất bản
            cbbNXB.DataSource = busthuVien.getNXB();
            cbbNXB.DisplayMember = "nhaxuatbanID";
            // Hiển thị tên của nhà xuất bản
            txtNXB.Text = busthuVien.gettenNXB(cbbNXB.Text).Rows[0][1].ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm sách {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                float cost;
                if (!float.TryParse(txtCost.Text, out cost))
                {
                    MessageBox.Show("Giá trị giá tiền không hợp lệ.");
                    return;
                }

                int nb;
                if (!int.TryParse(txtNb.Text, out nb))
                {
                    MessageBox.Show("Giá trị số lượng không hợp lệ.");
                    return;
                }

                // Kiểm tra và xử lý các giá trị khác tương tự như trên

                // Sau khi kiểm tra đúng định dạng, tạo đối tượng DTO_ThuVien
                DTO_ThuVien thuVien = new DTO_ThuVien(txtID.Text, txtName.Text, txtNumber.Text, cost, DateTime.Parse(dtDate.Value.ToShortDateString()), nb, txtLanguage.Text, cbbTL.Text, cbbTG.Text, cbbNXB.Text);
                if (busthuVien.ktra(thuVien.maTL) == 1)
                {
                    MessageBox.Show("Mã sách đã trùng !!");
                }
                else
                {
                    if (busthuVien.themSach(thuVien) == true)
                    {
                        MessageBox.Show("Thêm sách thành công !!");
                        dtgvHT.DataSource = busthuVien.getSach();
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
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Sửa sách ID {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO_ThuVien thuVien = new DTO_ThuVien(txtID.Text, txtName.Text, txtNumber.Text, float.Parse(txtCost.Text), DateTime.Parse(dtDate.Value.ToShortDateString()), int.Parse(txtNb.Text), txtLanguage.Text, cbbTL.Text, cbbTG.Text, cbbNXB.Text);
                if (busthuVien.suaSach(thuVien))
                {
                    MessageBox.Show("Sửa thành công sách");
                    dtgvHT.DataSource = busthuVien.getSach();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa sách {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busthuVien.xoaSach(txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công !");
                    dtgvHT.DataSource = busthuVien.getSach();
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
                txtNb.Text = dtgvHT[2, hang].Value.ToString();
                txtCost.Text = dtgvHT[3, hang].Value.ToString();
                dtDate.Text = dtgvHT[4, hang].Value.ToString();
                txtNumber.Text = dtgvHT[5, hang].Value.ToString();
                cbbTL.Text = dtgvHT[6, hang].Value.ToString();
                cbbTG.Text = dtgvHT[7, hang].Value.ToString();
                cbbNXB.Text = dtgvHT[8, hang].Value.ToString();
                txtLanguage.Text = dtgvHT[9, hang].Value.ToString();
                txtID.Enabled = false;
            }
            catch
            {

            }
        }
      
        private void cbbTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = busthuVien.gettenTL(cbbTL.Text);
            if (dt.Rows.Count > 0)
            {
                txtTL.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                // Xử lý nếu bảng dữ liệu trả về không có bất kỳ hàng nào.
            }
        }

        private void cbbTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = busthuVien.gettenTG(cbbTG.Text);
            if (dt.Rows.Count > 0)
            {
                txtTG.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                // Xử lý nếu bảng dữ liệu trả về không có bất kỳ hàng nào.
            }
        }

        private void cbbNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = busthuVien.gettenNXB(cbbNXB.Text);
            if (dt.Rows.Count > 0)
            {
                txtNXB.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                // Xử lý nếu bảng dữ liệu trả về không có bất kỳ hàng nào.
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in grHT.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox textBox = (TextBox)ctr;
                    textBox.Text = "";
                }
                else if (ctr is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)ctr;
                    dateTimePicker.Value = DateTime.Now;
                }
            }
            txtID.Enabled = true;
        }

        private void txtNb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        int KiemTra()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách");
                return 0;
            }
            if (string.IsNullOrEmpty(txtNb.Text))
            {
                MessageBox.Show("Vui lòng nhập số trang");
                return 0;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách");
                return 0;
            }
            if (string.IsNullOrEmpty(txtLanguage.Text))
            {
                MessageBox.Show("Vui lòng nhập ngôn ngữ ");
                return 0;
            }
            if (string.IsNullOrEmpty(cbbTL.Text))
            {
                MessageBox.Show("Vui lòng chọn thể loại");
                return 0;
            }
            if (string.IsNullOrEmpty(cbbTG.Text))
            {
                MessageBox.Show("Vui lòng chọn tác giả");
                return 0;
            }
            if (string.IsNullOrEmpty(cbbNXB.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản");
                return 0;
            }
           
            // Trả về 1 nếu các điều kiện kiểm tra đều thành công
            return 1;
        }
        private bool ktra(DateTime date)
        {
            // Kiểm tra logic để xác định tính hợp lệ của ngày

            // Kiểm tra xem ngày sinh có nằm trong khoảng thời gian hợp lệ hay không
            DateTime currentDate = DateTime.Now;
            DateTime minDate = currentDate.AddYears(-100);
            DateTime maxDate = currentDate.AddYears(0);

            if (date >= minDate && date <= maxDate)
                return true;

            return false;
        }
        private void dtDate_Validating(object sender, CancelEventArgs e)
        {
            string dateOfBirth = dtDate.Text;
            DateTime parsedDate;

            if (DateTime.TryParse(dateOfBirth, out parsedDate))
            {
                // Kiểm tra xem ngày có hợp lệ hay không
                if (ktra(parsedDate))
                {
                    e.Cancel = false;
                    erDateOfBirth.SetError(dtDate, "");
                }
                else
                {
                    e.Cancel = true;
                    dtDate.Focus();
                    erDateOfBirth.SetError(dtDate, "Ngày không hợp lệ");
                }
            }
            else
            {
                e.Cancel = true;
                dtDate.Focus();
                erDateOfBirth.SetError(dtDate, "Vui lòng nhập ngày đúng định dạng");
            }
        }
    }
}
