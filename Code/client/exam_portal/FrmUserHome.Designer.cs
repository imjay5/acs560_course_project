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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserHome));
            this.btnTakenExams = new System.Windows.Forms.Button();
            this.btnSeeAvlExams = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTakenExams
            // 
            this.btnTakenExams.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTakenExams.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakenExams.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTakenExams.Location = new System.Drawing.Point(493, 270);
            this.btnTakenExams.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakenExams.Name = "btnTakenExams";
            this.btnTakenExams.Size = new System.Drawing.Size(201, 30);
            this.btnTakenExams.TabIndex = 45;
            this.btnTakenExams.Text = "See all Taken Exams";
            this.btnTakenExams.UseVisualStyleBackColor = false;
            this.btnTakenExams.Click += new System.EventHandler(this.btnTakenExams_Click);
            // 
            // btnSeeAvlExams
            // 
            this.btnSeeAvlExams.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSeeAvlExams.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAvlExams.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeeAvlExams.Location = new System.Drawing.Point(138, 270);
            this.btnSeeAvlExams.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeAvlExams.Name = "btnSeeAvlExams";
            this.btnSeeAvlExams.Size = new System.Drawing.Size(241, 30);
            this.btnSeeAvlExams.TabIndex = 42;
            this.btnSeeAvlExams.Text = "See all Available Exams";
            this.btnSeeAvlExams.UseVisualStyleBackColor = false;
            this.btnSeeAvlExams.Click += new System.EventHandler(this.btnSeeAvlExams_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(134, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(168, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 23);
            this.lblName.TabIndex = 44;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(187, 185);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 23);
            this.lblUserName.TabIndex = 46;
            // 
            // frmUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 602);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnTakenExams);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSeeAvlExams);
            this.Controls.Add(this.label1);
            this.Name = "frmUserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakenExams;
        private System.Windows.Forms.Button btnSeeAvlExams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserName;
    }
}