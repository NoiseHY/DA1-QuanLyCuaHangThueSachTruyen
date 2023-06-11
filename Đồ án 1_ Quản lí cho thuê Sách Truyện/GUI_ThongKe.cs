using BLL;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.AxHost;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    public partial class GUI_ThongKe : Form
    {
        BUS_ThongKe thongKe = new BUS_ThongKe();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }
          
       
        void tkNhap()
        {
            string nam = dtNam.Value.Year.ToString();
            DTO_ThongKe dTO_ThongKe = new DTO_ThongKe(nam);
            // Xóa dữ liệu hiện có trong biểu đồ (nếu có)
            chartTKNhap.Series.Clear();

            // Tạo loại biểu đồ (ví dụ: biểu đồ cột)
            Series series = new Series("Tổng tiền nhập");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào series
            foreach (DataRow row in thongKe.getTien(dTO_ThongKe).Rows)
            {
                string thang = row["thang"].ToString();
                double tongtien = Convert.ToDouble(row["tongtien_nhap"]);

                string xValue = thang;
                series.Points.AddXY(xValue, tongtien);
            }

            // Thêm series vào biểu đồ
            chartTKNhap.Series.Add(series);

            // Vẽ lại biểu đồ
            chartTKNhap.Invalidate();
        }
        void tkmuon()
        {
            string nam = dtHT2.Value.Year.ToString();
            DTO_ThongKe dTO_ThongKe = new DTO_ThongKe(nam);
            // Xóa dữ liệu hiện có trong biểu đồ (nếu có)
            chartSachmuon.Series.Clear();

            // Tạo loại biểu đồ (ví dụ: biểu đồ cột)
            Series seriesMuon = new Series("Số lượng mượn");
            seriesMuon.ChartType = SeriesChartType.Column;

            Series seriesTra = new Series("Số lượng trả");
            seriesTra.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào series
            foreach (DataRow row in thongKe.getSLm(dTO_ThongKe).Rows)
            {
                string thang = row["thang"].ToString();
                double soluongmuon = Convert.ToDouble(row["soluongmuon"]);
                seriesMuon.Points.AddXY(thang, soluongmuon);
            }

            foreach (DataRow row in thongKe.getSLtra(dTO_ThongKe).Rows)
            {
                string thang = row["thang"].ToString();
                double soluongtra = Convert.ToDouble(row["soluongtra"]);
                seriesTra.Points.AddXY(thang, soluongtra);
            }

            // Thêm series vào biểu đồ
            chartSachmuon.Series.Add(seriesMuon);
            chartSachmuon.Series.Add(seriesTra);

            // Vẽ lại biểu đồ
            chartSachmuon.Invalidate();
        }


        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btTK_Click(object sender, EventArgs e)
        {
            tkmuon();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            tkNhap();
        }
        
        private void dtHT2_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void dtNam_Validating(object sender, CancelEventArgs e)
        {
            

        }
    }
}
