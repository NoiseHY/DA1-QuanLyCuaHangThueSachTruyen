namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_TacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TacGia));
            this.btRefresh = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtQuoctich = new System.Windows.Forms.TextBox();
            this.txtNs = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbNb = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.dtgvHT = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grHT = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.Location = new System.Drawing.Point(13, 311);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(207, 73);
            this.btRefresh.TabIndex = 39;
            this.btRefresh.Text = "Làm mới dữ liệu";
            this.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(687, 312);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(207, 73);
            this.btXoa.TabIndex = 37;
            this.btXoa.Text = "Xóa ";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txtQuoctich
            // 
            this.txtQuoctich.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtQuoctich.Location = new System.Drawing.Point(175, 162);
            this.txtQuoctich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuoctich.Name = "txtQuoctich";
            this.txtQuoctich.Size = new System.Drawing.Size(327, 39);
            this.txtQuoctich.TabIndex = 3;
            // 
            // txtNs
            // 
            this.txtNs.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtNs.Location = new System.Drawing.Point(175, 217);
            this.txtNs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNs.Name = "txtNs";
            this.txtNs.Size = new System.Drawing.Size(327, 39);
            this.txtNs.TabIndex = 5;
            this.txtNs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNs_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(175, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 39);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(175, 33);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(327, 39);
            this.txtID.TabIndex = 1;
            // 
            // lbNb
            // 
            this.lbNb.AutoSize = true;
            this.lbNb.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbNb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNb.Location = new System.Drawing.Point(18, 224);
            this.lbNb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNb.Name = "lbNb";
            this.lbNb.Size = new System.Drawing.Size(106, 32);
            this.lbNb.TabIndex = 15;
            this.lbNb.Text = "Năm sinh";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbAdress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAdress.Location = new System.Drawing.Point(18, 169);
            this.lbAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(108, 32);
            this.lbAdress.TabIndex = 13;
            this.lbAdress.Text = "Quốc tịch";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbName.Location = new System.Drawing.Point(18, 109);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(134, 32);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Tên độc giả ";
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(469, 311);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(207, 73);
            this.btSua.TabIndex = 36;
            this.btSua.Text = "Sửa ";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btOut
            // 
            this.btOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOut.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btOut.Image = ((System.Drawing.Image)(resources.GetObject("btOut.Image")));
            this.btOut.Location = new System.Drawing.Point(918, 311);
            this.btOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(207, 73);
            this.btOut.TabIndex = 38;
            this.btOut.Text = "Thoát";
            this.btOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
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
            this.dtgvHT.Size = new System.Drawing.Size(1132, 264);
            this.dtgvHT.TabIndex = 4;
            this.dtgvHT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHT_CellClick);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(18, 42);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(127, 32);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "Mã tác giả ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvHT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 302);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(844, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 40;
            // 
            // grHT
            // 
            this.grHT.Controls.Add(this.pictureBox1);
            this.grHT.Controls.Add(this.txtQuoctich);
            this.grHT.Controls.Add(this.txtNs);
            this.grHT.Controls.Add(this.txtName);
            this.grHT.Controls.Add(this.txtID);
            this.grHT.Controls.Add(this.lbNb);
            this.grHT.Controls.Add(this.lbAdress);
            this.grHT.Controls.Add(this.lbName);
            this.grHT.Controls.Add(this.lbID);
            this.grHT.Dock = System.Windows.Forms.DockStyle.Top;
            this.grHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grHT.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.grHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grHT.Location = new System.Drawing.Point(0, 0);
            this.grHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grHT.Name = "grHT";
            this.grHT.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grHT.Size = new System.Drawing.Size(1138, 284);
            this.grHT.TabIndex = 41;
            this.grHT.TabStop = false;
            this.grHT.Text = "Thông tin chi tiết";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 236);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(238, 311);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(207, 73);
            this.btThem.TabIndex = 35;
            this.btThem.Text = "Thêm ";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // GUI_TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grHT);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_TacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_TacGia";
            this.Load += new System.EventHandler(this.GUI_TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grHT.ResumeLayout(false);
            this.grHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtQuoctich;
        private System.Windows.Forms.TextBox txtNs;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbNb;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.DataGridView dtgvHT;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grHT;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}