namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_TheLoai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grHT = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvHT = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMta = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.grHT.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).BeginInit();
            this.SuspendLayout();
            // 
            // grHT
            // 
            this.grHT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grHT.Controls.Add(this.btRefresh);
            this.grHT.Controls.Add(this.groupBox2);
            this.grHT.Controls.Add(this.btSua);
            this.grHT.Controls.Add(this.btXoa);
            this.grHT.Controls.Add(this.btThem);
            this.grHT.Controls.Add(this.label2);
            this.grHT.Controls.Add(this.txtMta);
            this.grHT.Controls.Add(this.txtName);
            this.grHT.Controls.Add(this.txtID);
            this.grHT.Controls.Add(this.label1);
            this.grHT.Controls.Add(this.lbID);
            this.grHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grHT.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.grHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grHT.Location = new System.Drawing.Point(0, 0);
            this.grHT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grHT.Name = "grHT";
            this.grHT.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grHT.Size = new System.Drawing.Size(1138, 694);
            this.grHT.TabIndex = 0;
            this.grHT.TabStop = false;
            this.grHT.Text = "Thể loại";
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRefresh.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.synchronize;
            this.btRefresh.Location = new System.Drawing.Point(782, 75);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(196, 75);
            this.btRefresh.TabIndex = 49;
            this.btRefresh.Text = "Làm mới dữ liệu";
            this.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvHT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1132, 220);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ";
            // 
            // dtgvHT
            // 
            this.dtgvHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.dtgvHT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHT.Location = new System.Drawing.Point(3, 35);
            this.dtgvHT.Name = "dtgvHT";
            this.dtgvHT.RowHeadersWidth = 51;
            this.dtgvHT.RowTemplate.Height = 24;
            this.dtgvHT.Size = new System.Drawing.Size(1126, 182);
            this.dtgvHT.TabIndex = 4;
            this.dtgvHT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHT_CellClick_1);
            this.dtgvHT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHT_CellContentClick);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSua.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.minimize;
            this.btSua.Location = new System.Drawing.Point(782, 293);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(196, 63);
            this.btSua.TabIndex = 46;
            this.btSua.Text = "Sửa ";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btXoa.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.minimize__1_;
            this.btXoa.Location = new System.Drawing.Point(782, 393);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(196, 63);
            this.btXoa.TabIndex = 47;
            this.btXoa.Text = "Xóa ";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btThem.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.import;
            this.btThem.Location = new System.Drawing.Point(782, 190);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(196, 68);
            this.btThem.TabIndex = 41;
            this.btThem.Text = "Thêm ";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(86, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mô tả thể loại ";
            // 
            // txtMta
            // 
            this.txtMta.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtMta.Location = new System.Drawing.Point(254, 192);
            this.txtMta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMta.Multiline = true;
            this.txtMta.Name = "txtMta";
            this.txtMta.Size = new System.Drawing.Size(390, 265);
            this.txtMta.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(254, 126);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(390, 39);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(254, 51);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(390, 39);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(86, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên thể loại ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(86, 51);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(132, 32);
            this.lbID.TabIndex = 13;
            this.lbID.Text = "Mã thể loại ";
            // 
            // GUI_TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.grHT);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_TheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể loại";
            this.Load += new System.EventHandler(this.GUI_TheLoai_Load);
            this.grHT.ResumeLayout(false);
            this.grHT.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grHT;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtMta;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvHT;
        private System.Windows.Forms.Button btRefresh;
    }
}