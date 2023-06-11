namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_TTNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TTNguoiDung));
            this.grChitiet = new System.Windows.Forms.GroupBox();
            this.btOut = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNb = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.tx = new System.Windows.Forms.Label();
            this.lbNamenv = new System.Windows.Forms.Label();
            this.erSdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.erEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.erUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.grChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erSdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // grChitiet
            // 
            this.grChitiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grChitiet.Controls.Add(this.btOut);
            this.grChitiet.Controls.Add(this.btSua);
            this.grChitiet.Controls.Add(this.txtID);
            this.grChitiet.Controls.Add(this.label2);
            this.grChitiet.Controls.Add(this.txtNb);
            this.grChitiet.Controls.Add(this.txtAdress);
            this.grChitiet.Controls.Add(this.txtEmail);
            this.grChitiet.Controls.Add(this.txtName);
            this.grChitiet.Controls.Add(this.lbNumber);
            this.grChitiet.Controls.Add(this.lbAdress);
            this.grChitiet.Controls.Add(this.tx);
            this.grChitiet.Controls.Add(this.lbNamenv);
            this.grChitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grChitiet.Font = new System.Drawing.Font("Open Sans", 12F);
            this.grChitiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grChitiet.Location = new System.Drawing.Point(0, 0);
            this.grChitiet.Name = "grChitiet";
            this.grChitiet.Size = new System.Drawing.Size(1138, 694);
            this.grChitiet.TabIndex = 7;
            this.grChitiet.TabStop = false;
            this.grChitiet.Text = "Thông tin chi tiết :";
            // 
            // btOut
            // 
            this.btOut.Cursor = System.Windows.Forms.Cursors.No;
            this.btOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOut.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btOut.Image = global::Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.Properties.Resources.log_in;
            this.btOut.Location = new System.Drawing.Point(581, 549);
            this.btOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(204, 92);
            this.btOut.TabIndex = 48;
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
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(329, 549);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(215, 92);
            this.btSua.TabIndex = 47;
            this.btSua.Text = "Sửa ";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.txtID.ForeColor = System.Drawing.Color.Blue;
            this.txtID.Location = new System.Drawing.Point(240, 114);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(304, 54);
            this.txtID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã người dùng";
            // 
            // txtNb
            // 
            this.txtNb.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.txtNb.ForeColor = System.Drawing.Color.Blue;
            this.txtNb.Location = new System.Drawing.Point(240, 439);
            this.txtNb.Name = "txtNb";
            this.txtNb.Size = new System.Drawing.Size(304, 54);
            this.txtNb.TabIndex = 4;
            this.txtNb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            this.txtNb.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumber_Validating);
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.txtAdress.ForeColor = System.Drawing.Color.Blue;
            this.txtAdress.Location = new System.Drawing.Point(751, 274);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(367, 54);
            this.txtAdress.TabIndex = 3;
            this.txtAdress.Validating += new System.ComponentModel.CancelEventHandler(this.erDC_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.txtEmail.ForeColor = System.Drawing.Color.Blue;
            this.txtEmail.Location = new System.Drawing.Point(751, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 54);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.Location = new System.Drawing.Point(243, 270);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 54);
            this.txtName.TabIndex = 0;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.lbNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNumber.Location = new System.Drawing.Point(12, 445);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(190, 48);
            this.lbNumber.TabIndex = 4;
            this.lbNumber.Text = "Số điện thoại";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.lbAdress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAdress.Location = new System.Drawing.Point(588, 276);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(110, 48);
            this.lbAdress.TabIndex = 3;
            this.lbAdress.Text = "Địa chỉ";
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.tx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tx.Location = new System.Drawing.Point(585, 116);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(94, 48);
            this.tx.TabIndex = 1;
            this.tx.Text = "Email";
            // 
            // lbNamenv
            // 
            this.lbNamenv.AutoSize = true;
            this.lbNamenv.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Light", 18F);
            this.lbNamenv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNamenv.Location = new System.Drawing.Point(12, 276);
            this.lbNamenv.Name = "lbNamenv";
            this.lbNamenv.Size = new System.Drawing.Size(220, 48);
            this.lbNamenv.TabIndex = 0;
            this.lbNamenv.Text = "Tên người dùng";
            // 
            // erSdt
            // 
            this.erSdt.ContainerControl = this;
            // 
            // erEmail
            // 
            this.erEmail.ContainerControl = this;
            // 
            // erUserName
            // 
            this.erUserName.ContainerControl = this;
            // 
            // erAddress
            // 
            this.erAddress.ContainerControl = this;
            // 
            // GUI_TTNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Controls.Add(this.grChitiet);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_TTNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin người dùng ";
            this.Load += new System.EventHandler(this.GUI_TTNguoiDung_Load);
            this.grChitiet.ResumeLayout(false);
            this.grChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erSdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grChitiet;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNb;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbNamenv;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.ErrorProvider erSdt;
        private System.Windows.Forms.ErrorProvider erEmail;
        private System.Windows.Forms.ErrorProvider erUserName;
        private System.Windows.Forms.ErrorProvider erAddress;
    }
}