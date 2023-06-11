using BLL;
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
    public partial class GUI_Info : Form
    {
        BUS_Info BUS_Info = new BUS_Info();
        public GUI_Info()
        {
            InitializeComponent();
        }

        private void GUI_Info_Load(object sender, EventArgs e)
        {
            cbbTenSach.DataSource = BUS_Info.geten();
            cbbTenSach.DisplayMember = "tenSach";
        }
    }
}
