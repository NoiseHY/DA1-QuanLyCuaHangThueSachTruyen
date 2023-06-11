namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_DocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtNb = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbNb = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.grHT = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.erSdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvHT = new System.Windows.Forms.DataGridView();
            this.btOut = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.erDateOfBirth = new System.Windows.Forms.ErrorProvider(this.components);
            this.erEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.grHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erSdt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).BeginInit();
            this.SuspendLayout();
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
            this.label1.TabIndex = 32;
            // 
            // dtDate
            // 
            this.dtDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtDate.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(815, 159);
            this.dtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(279, 39);
            this.dtDate.TabIndex = 6;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            this.dtDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtDate_Validating);
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAdress.ForeColor = System.Drawing.Color.Blue;
            this.txtAdress.Location = new System.Drawing.Point(175, 162);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(327, 39);
            this.txtAdress.TabIndex = 3;
            // 
            // txtNb
            // 
            this.txtNb.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtNb.ForeColor = System.Drawing.Color.Blue;
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
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.Location = new System.Drawing.Point(175, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 39);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtID.ForeColor = System.Drawing.Color.Blue;
            this.txtID.Location = new System.Drawing.Point(175, 33);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(327, 39);
            this.txtID.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDate.Location = new System.Drawing.Point(655, 167);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(120, 32);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "Ngày sinh ";
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
            this.lbName.Size = new System.Drawing.Size(134, 32);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Tên độc giả ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(18, 42);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(130, 32);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "Mã độc giả ";
            // 
            // grHT
            // 
            this.grHT.Controls.Add(this.txtEmail);
            this.grHT.Controls.Add(this.lbEmail);
            this.grHT.Controls.Add(this.dtDate);
            this.grHT.Controls.Add(this.txtAdress);
            this.grHT.Controls.Add(this.txtNb);
            this.grHT.Controls.Add(this.txtName);
            this.grHT.Controls.Add(this.txtID);
            this.grHT.Controls.Add(this.lbDate);
            this.grHT.Controls.Add(this.lbNb);
            this.grHT.Controls.Add(this.lbAdress);
            this.grHT.Controls.Add(this.lbName);
            this.grHT.Controls.Add(this.lbID);
            this.grHT.Dock = System.Windows.Forms.DockStyle.Top;
            this.grHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grHT.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grHT.Location = new System.Drawing.Point(0, 0);
            this.grHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grHT.Name = "grHT";
            this.grHT.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grHT.Size = new System.Drawing.Size(1138, 229);
            this.grHT.TabIndex = 33;
            this.grHT.TabStop = false;
            this.grHT.Text = "Thông tin chi tiết";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Blue;
            this.txtEmail.Location = new System.Drawing.Point(812, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 39);
            this.txtEmail.TabIndex = 4;
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
            // erSdt
            // 
            this.erSdt.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvHT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 318);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // dtgvHT
            // 
            this.dtgvHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.dtgvHT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
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
            this.dtgvHT.Size = new System.Drawing.Size(1132, 280);
            this.dtgvHT.TabIndex = 4;
            this.dtgvHT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHT_CellClick);
            // 
            // btOut
            // 
            this.btOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOut.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btOut.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.log_in;
            this.btOut.Location = new System.Drawing.Point(929, 265);
            this.btOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(196, 73);
            this.btOut.TabIndex = 20;
            this.btOut.Text = "Thoát";
            this.btOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btXoa.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.minimize__1_;
            this.btXoa.Location = new System.Drawing.Point(698, 265);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(196, 73);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "Xóa ";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btRefresh.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.synchronize;
            this.btRefresh.Location = new System.Drawing.Point(13, 265);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(196, 75);
            this.btRefresh.TabIndex = 21;
            this.btRefresh.Text = "Làm mới dữ liệu";
            this.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click_1);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSua.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.minimize;
            this.btSua.Location = new System.Drawing.Point(453, 265);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(196, 75);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa ";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btThem.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.import;
            this.btThem.Location = new System.Drawing.Point(228, 265);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(196, 75);
            this.btThem.TabIndex = 17;
            this.btThem.Text = "Thêm ";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // erDateOfBirth
            // 
            this.erDateOfBirth.ContainerControl = this;
            // 
            // erEmail
            // 
            this.erEmail.ContainerControl = this;
            // 
            // GUI_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grHT);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Độc giả";
            this.Load += new System.EventHandler(this.GUI_DocGia_Load);
            this.grHT.ResumeLayout(false);
            this.grHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erSdt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtNb;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbNb;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox grHT;
        private System.Windows.Forms.ErrorProvider erSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvHT;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ErrorProvider erDateOfBirth;
        private System.Windows.Forms.ErrorProvider erEmail;
    }
}

