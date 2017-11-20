namespace exam_portal
{
    partial class frmUserHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSeeAvlExams = new System.Windows.Forms.Button();
            this.btnTakeExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(102, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello User,";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblHeading.Location = new System.Drawing.Point(347, 84);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(56, 19);
            this.lblHeading.TabIndex = 20;
            this.lblHeading.Text = "Home";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblTop.Location = new System.Drawing.Point(306, 18);
            this.lblTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(146, 27);
            this.lblTop.TabIndex = 19;
            this.lblTop.Text = "Exam Portal";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(551, 84);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 30);
            this.btnLogout.TabIndex = 41;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSeeAvlExams
            // 
            this.btnSeeAvlExams.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSeeAvlExams.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAvlExams.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeeAvlExams.Location = new System.Drawing.Point(298, 148);
            this.btnSeeAvlExams.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeAvlExams.Name = "btnSeeAvlExams";
            this.btnSeeAvlExams.Size = new System.Drawing.Size(285, 30);
            this.btnSeeAvlExams.TabIndex = 42;
            this.btnSeeAvlExams.Text = "See all Available Exams";
            this.btnSeeAvlExams.UseVisualStyleBackColor = false;
            this.btnSeeAvlExams.Click += new System.EventHandler(this.btnSeeAvlExams_Click);
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnTakeExam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeExam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTakeExam.Location = new System.Drawing.Point(466, 322);
            this.btnTakeExam.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(152, 30);
            this.btnTakeExam.TabIndex = 43;
            this.btnTakeExam.Text = "Take Exam";
            this.btnTakeExam.UseVisualStyleBackColor = false;
            this.btnTakeExam.Click += new System.EventHandler(this.btnTakeExam_Click);
            // 
            // frmUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(822, 602);
            this.Controls.Add(this.btnTakeExam);
            this.Controls.Add(this.btnSeeAvlExams);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.label1);
            this.Name = "frmUserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSeeAvlExams;
        private System.Windows.Forms.Button btnTakeExam;
    }
}