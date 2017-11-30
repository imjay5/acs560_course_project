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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminHome));
            this.btnCreateExam = new System.Windows.Forms.Button();
            this.pnlExams = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlExams.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateExam.Location = new System.Drawing.Point(175, 13);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(179, 42);
            this.btnCreateExam.TabIndex = 0;
            this.btnCreateExam.Text = "Create Exam";
            this.btnCreateExam.UseVisualStyleBackColor = false;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // pnlExams
            // 
            this.pnlExams.AutoScroll = true;
            this.pnlExams.BackColor = System.Drawing.Color.Transparent;
            this.pnlExams.Controls.Add(this.btnReport);
            this.pnlExams.Controls.Add(this.btnCreateExam);
            this.pnlExams.Location = new System.Drawing.Point(121, 182);
            this.pnlExams.Name = "pnlExams";
            this.pnlExams.Size = new System.Drawing.Size(683, 400);
            this.pnlExams.TabIndex = 20;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReport.Location = new System.Drawing.Point(360, 13);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 594);
            this.Controls.Add(this.pnlExams);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmAdminHome_Load);
            this.pnlExams.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.Panel pnlExams;
        private System.Windows.Forms.Button btnReport;
    }
}