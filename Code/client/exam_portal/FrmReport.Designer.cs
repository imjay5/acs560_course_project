namespace exam_portal
{
    partial class frmReport
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
            this.pnlReport = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlReport
            // 
            this.pnlReport.AutoScroll = true;
            this.pnlReport.Location = new System.Drawing.Point(49, 87);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(1160, 373);
            this.pnlReport.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 524);
            this.Controls.Add(this.pnlReport);
            this.Name = "frmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReport;
    }
}