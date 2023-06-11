namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_NhaXuatBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvHT = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtNb = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbNb = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.erSdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.grHT = new System.Windows.Forms.GroupBox();
            this.btOut = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.erEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erSdt)).BeginInit();
            this.grHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvHT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 340);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
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
            this.dtgvHT.Size = new System.Drawing.Size(1132, 302);
            this.dtgvHT.TabIndex = 4;
            this.dtgvHT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHT_CellClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(812, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 39);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEmail.Location = new System.Drawing.Point(655, 42);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(75, 32);
            this.lbEmail.TabIndex = 18;
            this.lbEmail.Text = "Email ";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAdress.Location = new System.Drawing.Point(207, 167);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(327, 39);
            this.txtAdress.TabIndex = 3;
            // 
            // txtNb
            // 
            this.txtNb.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtNb.Location = new System.Drawing.Point(815, 93);
            this.txtNb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNb.Name = "txtNb";
            this.txtNb.Size = new System.Drawing.Size(279, 39);
            this.txtNb.TabIndex = 5;
            this.txtNb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNb_KeyPress);
            this.txtNb.Validating += new System.ComponentModel.CancelEventHandler(this.txtNb_Validating);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(207, 106);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 39);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(207, 39);
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
            this.lbNb.Location = new System.Drawing.Point(655, 101);
            this.lbNb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNb.Name = "lbNb";
            this.lbNb.Size = new System.Drawing.Size(148, 32);
            this.lbNb.TabIndex = 15;
            this.lbNb.Text = "Số điện thoại ";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbAdress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAdress.Location = new System.Drawing.Point(18, 180);
            this.lbAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(90, 32);
            this.lbAdress.TabIndex = 13;
            this.lbAdress.Text = "Địa chỉ ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbName.Location = new System.Drawing.Point(18, 109);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(185, 32);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Tên nhà xuất bản";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(18, 42);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(181, 32);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "Mã nhà xuất bản";
            // 
            // erSdt
            // 
            this.erSdt.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(854, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 40;
            // 
            // grHT
            // 
            this.grHT.Controls.Add(this.btOut);
            this.grHT.Controls.Add(this.btSua);
            this.grHT.Controls.Add(this.btRefresh);
            this.grHT.Controls.Add(this.btXoa);
            this.grHT.Controls.Add(this.btThem);
            this.grHT.Controls.Add(this.txtEmail);
            this.grHT.Controls.Add(this.lbEmail);
            this.grHT.Controls.Add(this.txtAdress);
            this.grHT.Controls.Add(this.txtNb);
            this.grHT.Controls.Add(this.txtName);
            this.grHT.Controls.Add(this.txtID);
            this.grHT.Controls.Add(this.lbNb);
            this.grHT.Controls.Add(this.lbAdress);
            this.grHT.Controls.Add(this.lbName);
            this.grHT.Controls.Add(this.lbID);
            this.grHT.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.grHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grHT.Location = new System.Drawing.Point(10, 5);
            this.grHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grHT.Name = "grHT";
            this.grHT.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grHT.Size = new System.Drawing.Size(1117, 341);
            this.grHT.TabIndex = 41;
            this.grHT.TabStop = false;
            this.grHT.Text = "Thông tin chi tiết";
            // 
            // btOut
            // 
            this.btOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOut.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btOut.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.log_in;
            this.btOut.Location = new System.Drawing.Point(924, 255);
            this.btOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(185, 65);
            this.btOut.TabIndex = 43;
            this.btOut.Text = "Thoát";
            this.btOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSua.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.minimize;
            this.btSua.Location = new System.Drawing.Point(465, 257);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(196, 63);
            this.btSua.TabIndex = 41;
            this.btSua.Text = "Sửa ";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRefresh.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.synchronize;
            this.btRefresh.Location = new System.Drawing.Point(8, 257);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(222, 63);
            this.btRefresh.TabIndex = 44;
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
            this.btXoa.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.minimize__1_;
            this.btXoa.Location = new System.Drawing.Point(691, 257);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(185, 63);
            this.btXoa.TabIndex = 42;
            this.btXoa.Text = "Xóa ";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btThem.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.import;
            this.btThem.Location = new System.Drawing.Point(256, 256);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(185, 63);
            this.btThem.TabIndex = 40;
            this.btThem.Text = "Thêm ";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // erEmail
            // 
            this.erEmail.ContainerControl = this;
            // 
            // GUI_NhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grHT);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_NhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_NhaXuatBan";
            this.Load += new System.EventHandler(this.GUI_NhaXuatBan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erSdt)).EndInit();
            this.grHT.ResumeLayout(false);
            this.grHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvHT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtNb;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbNb;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grHT;
        private System.Windows.Forms.ErrorProvider erSdt;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ErrorProvider erEmail;
    }
}