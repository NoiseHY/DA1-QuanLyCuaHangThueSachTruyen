namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabSachNhap = new System.Windows.Forms.TabPage();
            this.dtHT2 = new System.Windows.Forms.DateTimePicker();
            this.btNhap = new System.Windows.Forms.Button();
            this.chartTKNhap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btTK = new System.Windows.Forms.Button();
            this.chartSachmuon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtNam = new System.Windows.Forms.DateTimePicker();
            this.erDateOfBirth = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabSachNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKNhap)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSachmuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erDateOfBirth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSachNhap
            // 
            this.tabSachNhap.Controls.Add(this.dtHT2);
            this.tabSachNhap.Controls.Add(this.btNhap);
            this.tabSachNhap.Controls.Add(this.chartTKNhap);
            this.tabSachNhap.Location = new System.Drawing.Point(4, 36);
            this.tabSachNhap.Name = "tabSachNhap";
            this.tabSachNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabSachNhap.Size = new System.Drawing.Size(1130, 654);
            this.tabSachNhap.TabIndex = 1;
            this.tabSachNhap.Text = "Thống kê tiền nhập sách";
            this.tabSachNhap.UseVisualStyleBackColor = true;
            // 
            // dtHT2
            // 
            this.dtHT2.CustomFormat = "yyyy";
            this.dtHT2.Font = new System.Drawing.Font("Open Sans", 16.2F);
            this.dtHT2.Location = new System.Drawing.Point(623, 603);
            this.dtHT2.Margin = new System.Windows.Forms.Padding(4);
            this.dtHT2.Name = "dtHT2";
            this.dtHT2.Size = new System.Drawing.Size(363, 44);
            this.dtHT2.TabIndex = 37;
            this.dtHT2.Validating += new System.ComponentModel.CancelEventHandler(this.dtHT2_Validating);
            // 
            // btNhap
            // 
            this.btNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhap.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btNhap.Image = ((System.Drawing.Image)(resources.GetObject("btNhap.Image")));
            this.btNhap.Location = new System.Drawing.Point(990, 593);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(134, 44);
            this.btNhap.TabIndex = 19;
            this.btNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // chartTKNhap
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTKNhap.ChartAreas.Add(chartArea1);
            this.chartTKNhap.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartTKNhap.Legends.Add(legend1);
            this.chartTKNhap.Location = new System.Drawing.Point(3, 3);
            this.chartTKNhap.Name = "chartTKNhap";
            this.chartTKNhap.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tiền nhập / tháng";
            this.chartTKNhap.Series.Add(series1);
            this.chartTKNhap.Size = new System.Drawing.Size(1124, 558);
            this.chartTKNhap.TabIndex = 18;
            this.chartTKNhap.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabSachNhap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 694);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtNam);
            this.tabPage1.Controls.Add(this.btTK);
            this.tabPage1.Controls.Add(this.chartSachmuon);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê sách mượn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btTK
            // 
            this.btTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTK.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btTK.Image = ((System.Drawing.Image)(resources.GetObject("btTK.Image")));
            this.btTK.Location = new System.Drawing.Point(1003, 593);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(119, 44);
            this.btTK.TabIndex = 17;
            this.btTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // chartSachmuon
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSachmuon.ChartAreas.Add(chartArea2);
            this.chartSachmuon.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartSachmuon.Legends.Add(legend2);
            this.chartSachmuon.Location = new System.Drawing.Point(3, 3);
            this.chartSachmuon.Name = "chartSachmuon";
            this.chartSachmuon.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số lượng mượn";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Số lượng trả";
            this.chartSachmuon.Series.Add(series2);
            this.chartSachmuon.Series.Add(series3);
            this.chartSachmuon.Size = new System.Drawing.Size(1124, 558);
            this.chartSachmuon.TabIndex = 15;
            this.chartSachmuon.Text = "chart1";
            // 
            // dtNam
            // 
            this.dtNam.CustomFormat = "yyyy";
            this.dtNam.Font = new System.Drawing.Font("Open Sans", 16.2F);
            this.dtNam.Location = new System.Drawing.Point(633, 593);
            this.dtNam.Margin = new System.Windows.Forms.Padding(4);
            this.dtNam.Name = "dtNam";
            this.dtNam.Size = new System.Drawing.Size(363, 44);
            this.dtNam.TabIndex = 38;
            this.dtNam.Validating += new System.ComponentModel.CancelEventHandler(this.dtNam_Validating);
            // 
            // erDateOfBirth
            // 
            this.erDateOfBirth.ContainerControl = this;
            // 
            // GUI_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_ThongKe";
            this.Text = "GUI_ThongKe";
            this.Load += new System.EventHandler(this.GUI_ThongKe_Load);
            this.tabSachNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTKNhap)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSachmuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erDateOfBirth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabSachNhap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSachmuon;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKNhap;
        private System.Windows.Forms.DateTimePicker dtHT2;
        private System.Windows.Forms.DateTimePicker dtNam;
        private System.Windows.Forms.ErrorProvider erDateOfBirth;
    }
}