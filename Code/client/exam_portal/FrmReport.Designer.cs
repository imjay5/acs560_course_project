﻿namespace exam_portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.pnlReport = new System.Windows.Forms.Panel();
            this.lblExamsRep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlReport
            // 
            this.pnlReport.AutoScroll = true;
            this.pnlReport.BackColor = System.Drawing.Color.Transparent;
            this.pnlReport.Location = new System.Drawing.Point(131, 217);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(594, 329);
            this.pnlReport.TabIndex = 0;
            // 
            // lblExamsRep
            // 
            this.lblExamsRep.AutoSize = true;
            this.lblExamsRep.BackColor = System.Drawing.Color.Transparent;
            this.lblExamsRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamsRep.Location = new System.Drawing.Point(372, 174);
            this.lblExamsRep.Name = "lblExamsRep";
            this.lblExamsRep.Size = new System.Drawing.Size(146, 25);
            this.lblExamsRep.TabIndex = 1;
            this.lblExamsRep.Text = "Exams Report";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 594);
            this.Controls.Add(this.lblExamsRep);
            this.Controls.Add(this.pnlReport);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Label lblExamsRep;
    }
}