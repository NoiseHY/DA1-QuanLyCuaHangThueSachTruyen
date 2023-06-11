namespace Đồ_án_1__Quản_lí_cho_thuê_Sách_Truyện.InPhieuMuon
{
    partial class GUI_InPhieuNhap
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
            this.cryInPhieuMuon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryInPhieuMuon
            // 
            this.cryInPhieuMuon.ActiveViewIndex = -1;
            this.cryInPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryInPhieuMuon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryInPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryInPhieuMuon.Location = new System.Drawing.Point(0, 0);
            this.cryInPhieuMuon.Name = "cryInPhieuMuon";
            this.cryInPhieuMuon.Size = new System.Drawing.Size(800, 450);
            this.cryInPhieuMuon.TabIndex = 0;
            // 
            // GUI_InPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryInPhieuMuon);
            this.Name = "GUI_InPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_InPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cryInPhieuMuon;
    }
}