namespace exam_portal
{
    partial class frmAdminHome
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
            this.btnCreateExam = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlExams = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCreateExam.Location = new System.Drawing.Point(827, 134);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(179, 42);
            this.btnCreateExam.TabIndex = 0;
            this.btnCreateExam.Text = "Create Exam";
            this.btnCreateExam.UseVisualStyleBackColor = false;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblHeading.Location = new System.Drawing.Point(373, 134);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(68, 24);
            this.lblHeading.TabIndex = 18;
            this.lblHeading.Text = "Home";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblTop.Location = new System.Drawing.Point(333, 70);
            this.lblTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(185, 34);
            this.lblTop.TabIndex = 17;
            this.lblTop.Text = "Exam Portal";
            // 
            // pnlExams
            // 
            this.pnlExams.AutoScroll = true;
            this.pnlExams.Location = new System.Drawing.Point(118, 199);
            this.pnlExams.Name = "pnlExams";
            this.pnlExams.Size = new System.Drawing.Size(1078, 351);
            this.pnlExams.TabIndex = 20;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnReport.Location = new System.Drawing.Point(1017, 134);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(179, 42);
            this.btnReport.TabIndex = 21;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1208, 602);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.pnlExams);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.btnCreateExam);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmAdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlExams;
        private System.Windows.Forms.Button btnReport;
    }
}