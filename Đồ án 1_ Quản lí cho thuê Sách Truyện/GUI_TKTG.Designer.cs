namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_TKTG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TKTG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTC = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btOut = new System.Windows.Forms.Button();
            this.btTK = new System.Windows.Forms.Button();
            this.dtgvHT = new System.Windows.Forms.DataGridView();
            this.cbbNammat = new System.Windows.Forms.CheckBox();
            this.cbbNS = new System.Windows.Forms.CheckBox();
            this.cbbQT = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbMa = new System.Windows.Forms.CheckBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTC);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btOut);
            this.groupBox1.Controls.Add(this.btTK);
            this.groupBox1.Controls.Add(this.dtgvHT);
            this.groupBox1.Controls.Add(this.cbbNammat);
            this.groupBox1.Controls.Add(this.cbbNS);
            this.groupBox1.Controls.Add(this.cbbQT);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.cbMa);
            this.groupBox1.Controls.Add(this.txtTk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 694);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm tác giả";
            // 
            // cbTC
            // 
            this.cbTC.AutoSize = true;
            this.cbTC.Checked = true;
            this.cbTC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTC.ForeColor = System.Drawing.Color.Blue;
            this.cbTC.Location = new System.Drawing.Point(557, 184);
            this.cbTC.Name = "cbTC";
            this.cbTC.Size = new System.Drawing.Size(93, 36);
            this.cbTC.TabIndex = 8;
            this.cbTC.Text = "Tất cả";
            this.cbTC.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(689, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 282);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btOut
            // 
            this.btOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOut.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btOut.Image = ((System.Drawing.Image)(resources.GetObject("btOut.Image")));
            this.btOut.Location = new System.Drawing.Point(355, 250);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(196, 50);
            this.btOut.TabIndex = 5;
            this.btOut.Text = "Thoát";
            this.btOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btTK
            // 
            this.btTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTK.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btTK.Image = ((System.Drawing.Image)(resources.GetObject("btTK.Image")));
            this.btTK.Location = new System.Drawing.Point(118, 250);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(196, 50);
            this.btTK.TabIndex = 6;
            this.btTK.Text = "Tìm kiếm";
            this.btTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // dtgvHT
            // 
            this.dtgvHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.dtgvHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvHT.Location = new System.Drawing.Point(3, 317);
            this.dtgvHT.Name = "dtgvHT";
            this.dtgvHT.RowHeadersWidth = 51;
            this.dtgvHT.RowTemplate.Height = 24;
            this.dtgvHT.Size = new System.Drawing.Size(1132, 374);
            this.dtgvHT.TabIndex = 3;
            // 
            // cbbNammat
            // 
            this.cbbNammat.AutoSize = true;
            this.cbbNammat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbNammat.ForeColor = System.Drawing.Color.Blue;
            this.cbbNammat.Location = new System.Drawing.Point(557, 124);
            this.cbbNammat.Name = "cbbNammat";
            this.cbbNammat.Size = new System.Drawing.Size(122, 36);
            this.cbbNammat.TabIndex = 2;
            this.cbbNammat.Text = "Năm mất";
            this.cbbNammat.UseVisualStyleBackColor = true;
            // 
            // cbbNS
            // 
            this.cbbNS.AutoSize = true;
            this.cbbNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbNS.ForeColor = System.Drawing.Color.Blue;
            this.cbbNS.Location = new System.Drawing.Point(289, 124);
            this.cbbNS.Name = "cbbNS";
            this.cbbNS.Size = new System.Drawing.Size(124, 36);
            this.cbbNS.TabIndex = 2;
            this.cbbNS.Text = "Năm sinh";
            this.cbbNS.UseVisualStyleBackColor = true;
            // 
            // cbbQT
            // 
            this.cbbQT.AutoSize = true;
            this.cbbQT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbQT.ForeColor = System.Drawing.Color.Blue;
            this.cbbQT.Location = new System.Drawing.Point(287, 184);
            this.cbbQT.Name = "cbbQT";
            this.cbbQT.Size = new System.Drawing.Size(126, 36);
            this.cbbQT.TabIndex = 2;
            this.cbbQT.Text = "Quốc tịch";
            this.cbbQT.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbName.ForeColor = System.Drawing.Color.Blue;
            this.cbName.Location = new System.Drawing.Point(18, 184);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(142, 36);
            this.cbName.TabIndex = 2;
            this.cbName.Text = "Tên tác giả";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // cbMa
            // 
            this.cbMa.AutoSize = true;
            this.cbMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMa.ForeColor = System.Drawing.Color.Blue;
            this.cbMa.Location = new System.Drawing.Point(18, 124);
            this.cbMa.Name = "cbMa";
            this.cbMa.Size = new System.Drawing.Size(138, 36);
            this.cbMa.TabIndex = 2;
            this.cbMa.Text = "Mã tác giả";
            this.cbMa.UseVisualStyleBackColor = true;
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(118, 41);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(565, 39);
            this.txtTk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa ";
            // 
            // GUI_TKTG
            // 
            this.AcceptButton = this.btTK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_TKTG";
            this.Text = "Tìm kiếm tác giả";
            this.Load += new System.EventHandler(this.GUI_TKTG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.CheckBox cbMa;
        private System.Windows.Forms.CheckBox cbbNammat;
        private System.Windows.Forms.CheckBox cbbNS;
        private System.Windows.Forms.CheckBox cbbQT;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.DataGridView dtgvHT;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbTC;
    }
}