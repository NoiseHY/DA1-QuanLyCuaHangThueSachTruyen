namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện
{
    partial class GUI_TraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TraSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvTT = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtslctra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtslt = new System.Windows.Forms.TextBox();
            this.btTra = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvTT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(916, 380);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách mượn";
            // 
            // dtgvTT
            // 
            this.dtgvTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.dtgvTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTT.Location = new System.Drawing.Point(3, 36);
            this.dtgvTT.Name = "dtgvTT";
            this.dtgvTT.RowHeadersWidth = 51;
            this.dtgvTT.RowTemplate.Height = 24;
            this.dtgvTT.Size = new System.Drawing.Size(910, 340);
            this.dtgvTT.TabIndex = 38;
            this.dtgvTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTT_CellClick);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(202, 401);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(289, 39);
            this.txtID.TabIndex = 45;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(25, 408);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(123, 32);
            this.lbID.TabIndex = 46;
            this.lbID.Text = "Mã độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "Số lượng cần trả";
            // 
            // txtslctra
            // 
            this.txtslctra.Enabled = false;
            this.txtslctra.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtslctra.Location = new System.Drawing.Point(202, 551);
            this.txtslctra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtslctra.Name = "txtslctra";
            this.txtslctra.Size = new System.Drawing.Size(289, 39);
            this.txtslctra.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Số lượng trả";
            // 
            // txtslt
            // 
            this.txtslt.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtslt.Location = new System.Drawing.Point(202, 634);
            this.txtslt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtslt.Name = "txtslt";
            this.txtslt.Size = new System.Drawing.Size(289, 39);
            this.txtslt.TabIndex = 45;
            // 
            // btTra
            // 
            this.btTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTra.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btTra.Image = ((System.Drawing.Image)(resources.GetObject("btTra.Image")));
            this.btTra.Location = new System.Drawing.Point(526, 489);
            this.btTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(130, 123);
            this.btTra.TabIndex = 54;
            this.btTra.Text = "Trả sách";
            this.btTra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btTra.UseVisualStyleBackColor = true;
            this.btTra.Click += new System.EventHandler(this.btTra_Click);
            // 
            // btOut
            // 
            this.btOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOut.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.btOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btOut.Image = ((System.Drawing.Image)(resources.GetObject("btOut.Image")));
            this.btOut.Location = new System.Drawing.Point(701, 489);
            this.btOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(130, 123);
            this.btOut.TabIndex = 54;
            this.btOut.Text = "Quay lại";
            this.btOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(25, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mã phiếu mượn";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("#9Slide03 Josefin Sans Bold", 12F, System.Drawing.FontStyle.Bold);
            this.txtMa.Location = new System.Drawing.Point(202, 482);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(289, 39);
            this.txtMa.TabIndex = 45;
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.Location = new System.Drawing.Point(507, 401);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(32, 36);
            this.btRefresh.TabIndex = 68;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // GUI_TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 694);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.btTra);
            this.Controls.Add(this.txtslt);
            this.Controls.Add(this.txtslctra);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_TraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.GUI_TraSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvTT;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtslctra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtslt;
        private System.Windows.Forms.Button btTra;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btRefresh;
    }
}