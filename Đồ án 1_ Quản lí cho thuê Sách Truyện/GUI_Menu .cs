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
    public partial class GUI_Menu : Form
    {
        string username = "";
        string password = "";
        string role = "";
        public GUI_Menu()
        {
            InitializeComponent();
            custome();
        }
        public GUI_Menu(string username,string role ,string password)
        {
            InitializeComponent();          
            custome();
            this.username = username;
            this.password = password;
            this.role = role;
        }
        private void custome()
        {
            pnHTNguoiDung.Visible = false;
            pnHTDanhMuc.Visible = false;
            pnHTQuanli.Visible = false;
            pnHTTimKiem.Visible = false;
        }
        private void hideMenu()
        {
            if (pnHTNguoiDung.Visible == true)
                pnHTNguoiDung.Visible = false;
            if(pnHTDanhMuc.Visible == true)
                pnHTDanhMuc.Visible=false;
            if(pnHTTimKiem.Visible == true)
                pnHTTimKiem.Visible=false;
            if(pnHTQuanli.Visible == true)
                pnHTQuanli.Visible=false;
        }
        private void showMenu(Panel menu)
        {
            if(menu.Visible == false)
            {
                hideMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            showMenu(pnHTNguoiDung);
        }

        private void btManagers_Click(object sender, EventArgs e)
        {
            showMenu(pnHTQuanli);
        }

        private void btDanhMuc_Click(object sender, EventArgs e)
        {
            showMenu(pnHTDanhMuc);
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            showMenu(pnHTTimKiem);
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            // Nếu form khởi tạo rồi thì cho đóng
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childform;
            childform.TopLevel = false;

            // Xóa đi hiển thị to nhỏ, đóng form
            childform.FormBorderStyle = FormBorderStyle.None;

            // Lấp đầy panel   
            childform.Dock = DockStyle.Fill;
            pnHT.Controls.Add(childform);
            pnHT.Tag = childform;

            // Đưa form lên đầu danh sách, tránh trường hợp form sau che khuất form trước
            childform.BringToFront();

            // Hiển thị form
            childform.Show();

        }

        private void btTTTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_TTNguoiDung(username));
            hideMenu();
        }

        private void btDMK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_DMK(username, password));
            hideMenu();
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_NguoiDung());
            hideMenu();
        }

        private void btOut1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_DocGia());
            hideMenu();
        }

        private void btSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_ThuVien());
            hideMenu();
        }

        private void btMuonSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_MuonSach());
            hideMenu();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_PhieuNhap());
            hideMenu();
        }

        private void btTheLoai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_TheLoai());
            hideMenu();
        }

        private void btTacgia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_TacGia());
            hideMenu();
        }

        private void btNXB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_NhaXuatBan());
            hideMenu();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_NhaCungCap());
            hideMenu();
        }

        private void btTKNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_TKPN());
            hideMenu();
        }

        private void btTKTGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_TKTG());
            hideMenu();
        }

        private void btTKSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_TimKiemSach());
            hideMenu();
        }

        private void btMuon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_TKSachMuon());
            hideMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_ThongKe());
            hideMenu();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_DangNhap dangNhap = new GUI_DangNhap();
            dangNhap.ShowDialog();
            this.Dispose();
        }
        private void GUI_Menu_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void GUI_Menu_Load(object sender, EventArgs e)
        {
            if(role == "Thủ thư")
            {
                btQL.Enabled = false;
                btNCC.Enabled = false;  
                btNXB.Enabled = false;
            }
            if (role == "Quản lí ")
            {
                btManagers.Enabled = false;
                btDGia.Enabled = false;
                btSach.Enabled = false;
                btMuonSach.Enabled =false;
                btNhap.Enabled = false;
                btTheLoai.Enabled = false;
                btTacgia.Enabled = false;
            }
        }
    }
}
