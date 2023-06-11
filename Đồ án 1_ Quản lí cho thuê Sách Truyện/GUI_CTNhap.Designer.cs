namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_CTNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_CTNhap));
            this.grHT2 = new System.Windows.Forms.GroupBox();
            this.cbbMasach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvHT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btXoact = new System.Windows.Forms.Button();
            this.btInHD = new System.Windows.Forms.Button();
            this.grHT2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grHT2
            // 
            this.grHT2.Controls.Add(this.cbbMasach);
            this.grHT2.Controls.Add(this.label3);
            this.grHT2.Controls.Add(this.txtCT);
            this.grHT2.Controls.Add(this.label4);
            this.grHT2.Controls.Add(this.label6);
            this.grHT2.Controls.Add(this.txtGia);
            this.grHT2.Controls.Add(this.label5);
            this.grHT2.Controls.Add(this.txtSl);
            this.grHT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grHT2.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.grHT2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grHT2.Location = new System.Drawing.Point(4, 0);
            this.grHT2.Name = "grHT2";
            this.grHT2.Size = new System.Drawing.Size(522, 336);
            this.grHT2.TabIndex = 2;
            this.grHT2.TabStop = false;
            this.grHT2.Text = "Chi tiết hóa đơn nhập";
            // 
            // cbbMasach
            // 
            this.cbbMasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMasach.FormattingEnabled = true;
            this.cbbMasach.Location = new System.Drawing.Point(206, 116);
            this.cbbMasach.Name = "cbbMasach";
            this.cbbMasach.Size = new System.Drawing.Size(223, 40);
            this.cbbMasach.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã chi tiết HĐ ";
            // 
            // txtCT
            // 
            this.txtCT.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtCT.Location = new System.Drawing.Point(206, 48);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(223, 39);
            this.txtCT.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã sách ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(20, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giá bán ";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtGia.Location = new System.Drawing.Point(206, 270);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(223, 39);
            this.txtGia.TabIndex = 1;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(20, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số lượng ";
            // 
            // txtSl
            // 
            this.txtSl.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSl.Location = new System.Drawing.Point(206, 193);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(223, 39);
            this.txtSl.TabIndex = 0;
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvHT);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1138, 215);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // dtgvHT
            // 
            this.dtgvHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.dtgvHT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHT.Location = new System.Drawing.Point(3, 35);
            this.dtgvHT.Name = "dtgvHT";
            this.dtgvHT.RowHeadersWidth = 51;
            this.dtgvHT.RowTemplate.Height = 24;
            this.dtgvHT.Size = new System.Drawing.Size(1132, 177);
            this.dtgvHT.TabIndex = 0;
            this.dtgvHT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHT_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvSach);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(532, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 476);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Sách cần nhập (<10)";
            // 
            // dtgvSach
            // 
            this.dtgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.dtgvSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSach.Location = new System.Drawing.Point(3, 35);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.RowHeadersWidth = 51;
            this.dtgvSach.RowTemplate.Height = 24;
            this.dtgvSach.Size = new System.Drawing.Size(600, 438);
            this.dtgvSach.TabIndex = 0;
            this.dtgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellClick);
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btThem.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.import;
            this.btThem.Location = new System.Drawing.Point(142, 358);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(112, 118);
            this.btThem.TabIndex = 68;
            this.btThem.Text = "Nhập sách";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRefresh.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.synchronize;
            this.btRefresh.Location = new System.Drawing.Point(9, 358);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(112, 118);
            this.btRefresh.TabIndex = 69;
            this.btRefresh.Text = "Làm mới dữ liệu";
            this.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btXoact
            // 
            this.btXoact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoact.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btXoact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btXoact.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.minimize;
            this.btXoact.Location = new System.Drawing.Point(274, 358);
            this.btXoact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoact.Name = "btXoact";
            this.btXoact.Size = new System.Drawing.Size(112, 118);
            this.btXoact.TabIndex = 67;
            this.btXoact.Text = "Xóa";
            this.btXoact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btXoact.UseVisualStyleBackColor = true;
            this.btXoact.Click += new System.EventHandler(this.btXoact_Click);
            // 
            // btInHD
            // 
            this.btInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInHD.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btInHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btInHD.Image = ((System.Drawing.Image)(resources.GetObject("btInHD.Image")));
            this.btInHD.Location = new System.Drawing.Point(413, 358);
            this.btInHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btInHD.Name = "btInHD";
            this.btInHD.Size = new System.Drawing.Size(112, 118);
            this.btInHD.TabIndex = 67;
            this.btInHD.Text = "In hóa đơn";
            this.btInHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btInHD.UseVisualStyleBackColor = true;
            this.btInHD.Click += new System.EventHandler(this.btInHD_Click);
            // 
            // GUI_CTNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btInHD);
            this.Controls.Add(this.btXoact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grHT2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_CTNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_CTNhap";
            this.Load += new System.EventHandler(this.GUI_CTNhap_Load);
            this.grHT2.ResumeLayout(false);
            this.grHT2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grHT2;
        private System.Windows.Forms.ComboBox cbbMasach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvHT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btXoact;
        private System.Windows.Forms.Button btInHD;
    }
}