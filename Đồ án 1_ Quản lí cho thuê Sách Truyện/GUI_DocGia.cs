using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Data.SqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_DocGia : Form
    {
        BUS_DocGia busDocgia = new BUS_DocGia();
        public GUI_DocGia()
        {
            InitializeComponent();
        }

        private void GUI_DocGia_Load(object sender, EventArgs e)
        {
            dtgvHT.DataSource = busDocgia.getDocGia();
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
                else if (ctr is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)ctr;
                    dateTimePicker.Value = DateTime.Now;
                }
                txtID.Enabled = true;
            }
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn thêm độc giả {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int ktra = KiemTra();
                if(ktra == 1)
                {
                    DTO_DocGia docgia = new DTO_DocGia(txtID.Text, txtName.Text, txtAdress.Text, txtEmail.Text, txtNb.Text, DateTime.Parse(dtDate.Value.ToShortDateString()));
                    if (busDocgia.ktra(docgia.maDocgia) == 1)
                    {
                        MessageBox.Show("Mã độc giả đã trùng !!");
                    }
                    else
                    {
                        if (busDocgia.themDocgia(docgia) == true)
                        {
                            MessageBox.Show("Thêm độc giả thành công !!");
                            dtgvHT.DataSource = busDocgia.getDocGia();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                }
                
            }
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            int ktra = KiemTra();
            if (ktra == 1)
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn Sửa độc giả {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DTO_DocGia docgia = new DTO_DocGia(txtID.Text, txtName.Text, txtAdress.Text, txtEmail.Text, txtNb.Text, DateTime.Parse(dtDate.Value.ToShortDateString()));
                    if (busDocgia.suaDocgia(docgia))
                    {
                        MessageBox.Show("Sửa thành công độc giả");
                        dtgvHT.DataSource = busDocgia.getDocGia();
                    }
                }
            }
            
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa độc giả {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (busDocgia.xoaDocgia(txtID.Text) == true)
                {
                    MessageBox.Show("Xóa thành công !");
                    dtgvHT.DataSource = busDocgia.getDocGia();
                }
            }
        }

        private void btOut_Click_1(object sender, EventArgs e)
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
                txtAdress.Text = dtgvHT[2, hang].Value.ToString();
                txtEmail.Text = dtgvHT[3, hang].Value.ToString();
                txtNb.Text = dtgvHT[4, hang].Value.ToString();
                dtDate.Text = dtgvHT[5, hang].Value.ToString();
                txtID.Enabled = false;
            }
            catch
            {
                
            }
            
        }

        private void txtNb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNb_Validating(object sender, CancelEventArgs e)
        {
            if (txtNb.Text.Length == 10 && txtNb.Text.StartsWith("0"))
            {
                e.Cancel = false;
                erSdt.SetError(txtNb, "");
            }
            else
            {
                e.Cancel = true;
                txtNb.Focus();
                erSdt.SetError(txtNb, "Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0");
            }
        }
        private bool IsValidDateOfBirth(DateTime date)
        {
            // Kiểm tra logic để xác định tính hợp lệ của ngày sinh

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

            // Kiểm tra xem ngày sinh có hợp lệ hay không
            if (DateTime.TryParse(dateOfBirth, out parsedDate))
            {
                if (IsValidDateOfBirth(parsedDate))
                {
                    e.Cancel = false;
                    erDateOfBirth.Clear(); // Xóa thông báo lỗi
                }
                else
                {
                    e.Cancel = true;
                    dtDate.Focus();
                    erDateOfBirth.SetError(dtDate, "Ngày sinh không hợp lệ");
                }
            }
            else
            {
                e.Cancel = true;
                dtDate.Focus();
                erDateOfBirth.SetError(dtDate, "Lỗi");
            }
        }




        int KiemTra()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
                return 0;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email");
                return 0;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên độc giả");
                return 0;
            }          
            if (string.IsNullOrEmpty(txtAdress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return 0;
            }
            if (string.IsNullOrEmpty(txtNb.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return 0;
            }
            
            // Trả về 1 nếu các điều kiện kiểm tra đều thành công
            return 1;
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            erDateOfBirth.Clear();
        }
        private bool ktraEmail(string email)
        {
            // Kiểm tra logic để xác định tính hợp lệ của email

            if (string.IsNullOrEmpty(email))
                return false;

            // Kiểm tra xem email có chứa ký tự @ và ít nhất một dấu chấm
            if (!email.Contains("@") || !email.Contains("."))
                return false;

            // Kiểm tra xem dấu chấm cuối cùng có nằm sau ký tự @ hay không
            if (email.LastIndexOf(".") < email.IndexOf("@"))
                return false;

            return true;
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;

            if (ktraEmail(email))
            {
                e.Cancel = false;
                erEmail.SetError(txtEmail, "");
            }
            else
            {
                e.Cancel = true;
                txtEmail.Focus();
                erEmail.SetError(txtEmail, "Email không hợp lệ");
            }
        }
    }
}
