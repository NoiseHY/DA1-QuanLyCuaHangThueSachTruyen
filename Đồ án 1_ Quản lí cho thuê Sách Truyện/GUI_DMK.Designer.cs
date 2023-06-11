namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_DMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DMK));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOut = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.txtNhapLaimk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMkm = new System.Windows.Forms.TextBox();
            this.blMk = new System.Windows.Forms.Label();
            this.txtNLmkc = new System.Windows.Forms.TextBox();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.erPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.erConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btOut);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.txtNhapLaimk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMkm);
            this.groupBox1.Controls.Add(this.blMk);
            this.groupBox1.Controls.Add(this.txtNLmkc);
            this.groupBox1.Controls.Add(this.txtMKC);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1138, 694);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // btOut
            // 
            this.btOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOut.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.btOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btOut.Image = ((System.Drawing.Image)(resources.GetObject("btOut.Image")));
            this.btOut.Location = new System.Drawing.Point(548, 582);
            this.btOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(212, 81);
            this.btOut.TabIndex = 6;
            this.btOut.Text = "Thoát";
            this.btOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSua.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.minimize;
            this.btSua.Location = new System.Drawing.Point(297, 582);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(223, 81);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Đổi";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // txtNhapLaimk
            // 
            this.txtNhapLaimk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapLaimk.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.txtNhapLaimk.Location = new System.Drawing.Point(548, 474);
            this.txtNhapLaimk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhapLaimk.Name = "txtNhapLaimk";
            this.txtNhapLaimk.Size = new System.Drawing.Size(489, 59);
            this.txtNhapLaimk.TabIndex = 4;
            this.txtNhapLaimk.Validating += new System.ComponentModel.CancelEventHandler(this.txtNhapLaimk_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(121, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 52);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMkm
            // 
            this.txtMkm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMkm.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.txtMkm.Location = new System.Drawing.Point(548, 359);
            this.txtMkm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMkm.Name = "txtMkm";
            this.txtMkm.Size = new System.Drawing.Size(489, 59);
            this.txtMkm.TabIndex = 3;
            this.txtMkm.Validating += new System.ComponentModel.CancelEventHandler(this.txtMkm_Validating);
            // 
            // blMk
            // 
            this.blMk.AutoSize = true;
            this.blMk.BackColor = System.Drawing.Color.White;
            this.blMk.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.blMk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blMk.Location = new System.Drawing.Point(121, 376);
            this.blMk.Name = "blMk";
            this.blMk.Size = new System.Drawing.Size(218, 52);
            this.blMk.TabIndex = 30;
            this.blMk.Text = "Mật khẩu mới";
            // 
            // txtNLmkc
            // 
            this.txtNLmkc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNLmkc.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.txtNLmkc.Location = new System.Drawing.Point(548, 241);
            this.txtNLmkc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNLmkc.Name = "txtNLmkc";
            this.txtNLmkc.Size = new System.Drawing.Size(489, 59);
            this.txtNLmkc.TabIndex = 2;
            // 
            // txtMKC
            // 
            this.txtMKC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKC.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.txtMKC.Location = new System.Drawing.Point(548, 143);
            this.txtMKC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.Size = new System.Drawing.Size(489, 59);
            this.txtMKC.TabIndex = 1;
            this.txtMKC.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.txtID.Location = new System.Drawing.Point(548, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(489, 59);
            this.txtID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(121, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 52);
            this.label2.TabIndex = 28;
            this.label2.Text = "Xác nhận mật khẩu cũ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbName.Location = new System.Drawing.Point(121, 160);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(199, 52);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "Mật khẩu cũ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.White;
            this.lbID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 19.8F);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(121, 56);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(240, 52);
            this.lbID.TabIndex = 27;
            this.lbID.Text = "Mã người dùng";
            // 
            // erPassword
            // 
            this.erPassword.ContainerControl = this;
            // 
            // erConfirmPassword
            // 
            this.erConfirmPassword.ContainerControl = this;
            // 
            // GUI_DMK
            // 
            this.AcceptButton = this.btSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_DMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.GUI_DMK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erConfirmPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMkm;
        private System.Windows.Forms.Label blMk;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtNhapLaimk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtNLmkc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider erPassword;
        private System.Windows.Forms.ErrorProvider erConfirmPassword;
    }
}