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
    public partial class GUI_MuonSach : Form
    {
        BUS_MuonSach BLL_MuonSach = new BUS_MuonSach();
        public GUI_MuonSach()
        {
            InitializeComponent();
        }

        private void btQD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là quy định của thư viện!");
            GUI_QuyDinh gUI_QuyDinh = new GUI_QuyDinh();
            gUI_QuyDinh.ShowDialog();
        }

        private void GUI_MuonSach_Load(object sender, EventArgs e)
        {
            dtgvPhieuMuon.DataSource = BLL_MuonSach.getHD();
            //
            //
            cbbMaDG.DataSource = BLL_MuonSach.getDocGia();
            cbbMaDG.DisplayMember = "docgiaID";
            dtgvTT.DataSource = BLL_MuonSach.getTBDG(cbbMaDG.Text);
            datagridview();
            trangthai();
        }
        void trangthai()
        {
            if (BLL_MuonSach.trangthai(cbbMaDG.Text) == 0)
            {
                txtTrangThai.Text = "Bị cảnh cáo!";
                btThemPhieu.Enabled = true;
                btThemSach.Enabled = true;
                btTraSach.Enabled = true;
                btCanhCao.Enabled = true;
            }
            else if (BLL_MuonSach.trangthai(cbbMaDG.Text) == 1)
            {
                txtTrangThai.Text = "Cấm mượn sách";
                MessageBox.Show(string.Format("Độc giả {0} bị cấm mượn sách!!!", cbbMaDG.Text));
                btThemPhieu.Enabled = false;
                btThemSach.Enabled = false;
                btTraSach.Enabled = false;
                btCanhCao.Enabled = false;
            }
            else if (BLL_MuonSach.trangthai(cbbMaDG.Text) == 2)
            {
                txtTrangThai.Text = "Bình thường !";
                btThemPhieu.Enabled = true;
                btThemSach.Enabled = true;
                btTraSach.Enabled = true;
                btCanhCao.Enabled = true;
            }
        }
        void datagridview()
        {
            dtgvTT.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvTT.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvTT.Rows[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvTT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void btThemPhieu_Click(object sender, EventArgs e)
        {
            if(cbbMaDG.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
            }
            else if (txtID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn phiếu mượn {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DateTime ngayHT = DateTime.Now;
                    DTO_MuonSach dTO_MuonSach = new DTO_MuonSach(txtID.Text, cbbMaDG.Text, ngayHT, DateTime.Parse(dtDate.Text));
                    if (BLL_MuonSach.ktra(dTO_MuonSach.ma) == 1)
                    {
                        MessageBox.Show("Mã phiếu mượn đã trùng !!");
                    }
                    else
                    {
                        if (BLL_MuonSach.themHD(dTO_MuonSach) == true)
                        {
                            MessageBox.Show("Thêm phiếu mượn thành công !!");
                            dtgvTT.DataSource = BLL_MuonSach.getTBDG(cbbMaDG.Text);
                            dtgvPhieuMuon.DataSource = BLL_MuonSach.getHD();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                }

            }

        }
       
        private void btThemSach_Click(object sender, EventArgs e)
        {
            if (cbbMaDG.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
            }
            else if (txtID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có thêm sách mượn của phiếu {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    GUI_CTMuonSach gUI_CTMuonSach = new GUI_CTMuonSach(txtID.Text, cbbMaDG.Text);
                    gUI_CTMuonSach.ShowDialog();

                }

            }
        }
        //
        
        private void btCanhCao_Click(object sender, EventArgs e)
        {
            if (cbbMaDG.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
            }
            else if (txtID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có muốn cảnh cáo độc giả {0} không ??", cbbMaDG.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    BLL_MuonSach.CanhCaoVaCamMuonDocGia(cbbMaDG.Text);
                    MessageBox.Show("Cảnh cáo thành công !!");
                    dtgvTT.DataSource = BLL_MuonSach.getTBDG(cbbMaDG.Text);
                    dtgvPhieuMuon.DataSource = BLL_MuonSach.getHD();
                }

            }
        }
        private void btTraSach_Click(object sender, EventArgs e)
        {
            if (cbbMaDG.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
            }
            else if (txtID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có trả sách của độc giả {0} không ??", cbbMaDG.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    GUI_TraSach gUI_TraSach = new GUI_TraSach(cbbMaDG.Text);
                    gUI_TraSach.ShowDialog();
                }

            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbbMaDG.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
            }
            else if (txtID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa phiếu mượn {0} không ??", txtID.Text), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (BLL_MuonSach.xoa(txtID.Text) == true)
                    {
                        MessageBox.Show("Xóa thành công !");
                        dtgvTT.DataSource = BLL_MuonSach.getTBDG(cbbMaDG.Text);
                        dtgvPhieuMuon.DataSource = BLL_MuonSach.getHD();
                    }
                }


            }
        }

        private void cbbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvTT.DataSource = BLL_MuonSach.getTBDG(cbbMaDG.Text);
            trangthai();
        }

        private void dtgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtID.Text = dtgvPhieuMuon[0, hang].Value.ToString();
                cbbMaDG.Text = dtgvPhieuMuon[1, hang].Value.ToString();
                txtID.Enabled = false;
                cbbMaDG.Enabled = false;
                trangthai();
            }
            catch { }
        }
        
        int KiemTra()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
                return 0;
            }
            if (string.IsNullOrEmpty(cbbMaDG.Text))
            {
                MessageBox.Show("Vui lòng chọn mã độc giả");
                return 0;
            }

            // Trả về 1 nếu các điều kiện kiểm tra đều thành công
            return 1;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in grHT1.Controls)
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
                cbbMaDG.Enabled = true;
            }
        }
    }
}
