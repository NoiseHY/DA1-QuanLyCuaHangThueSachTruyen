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
    public partial class GUI_DangNhap : Form
    {
       BUS_DangNhap BUS_DangNhap = new BUS_DangNhap();
        
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtDangNhap.Text;
            string password = txtMatKhau.Text;

            // Kiểm tra thông tin đăng nhập và lấy thông tin người dùng
            DataTable dt = BUS_DangNhap.getData(username, password);

            if (dt.Rows.Count > 0)
            {
                string roleId = dt.Rows[0]["tenphanQuyen"].ToString();

                // Kiểm tra vai trò của người dùng
                if (roleId == "Admin")
                {
                    // Thực hiện các hành động dành cho vai trò "Admin"
                    MessageBox.Show("Xin chào, bạn là quản trị viên!");
                    this.Hide();
                    // Ví dụ: Mở form quản trị viên
                    GUI_Menu adminForm = new GUI_Menu(username, roleId, password);
                    adminForm.ShowDialog();
                    this.Close();
                }
                else if (roleId == "Thủ thư")
                {
                    // Thực hiện các hành động dành cho vai trò 
                    MessageBox.Show("Xin chào, bạn là thủ thư!");
                    this.Hide();
                    GUI_Menu userForm = new GUI_Menu(username, roleId, password);
                    userForm.ShowDialog();
                    //this.Hide();
                    // Đóng form đăng nhập (nếu cần)
                    this.Close();
                }
                else if (roleId == "Quản lí ")
                {
                    // Thực hiện các hành động dành cho vai trò 
                    MessageBox.Show("Xin chào, bạn là quản lí!");
                    this.Hide();
                    GUI_Menu userForm = new GUI_Menu(username, roleId, password);
                    userForm.ShowDialog();
                    this.Close();
                    // Đóng form đăng nhập (nếu cần)
                    
                }
                else
                {
                    // Vai trò không hợp lệ, hiển thị thông báo hoặc xử lý khác tùy thuộc vào yêu cầu của bạn
                    MessageBox.Show("Vai trò không hợp lệ!");
                }
            }
            else
            {
                // Thông tin đăng nhập không đúng, hiển thị thông báo hoặc xử lý khác tùy thuộc vào yêu cầu của bạn
                MessageBox.Show("Thông tin đăng nhập không đúng!");
            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btHT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thuộc về sinh viên : Nguyễn Công Nam, giảng viên hướng dẫn : Đào Anh Hiển");
        }

        
    }
}
