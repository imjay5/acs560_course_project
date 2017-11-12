namespace exam_portal
{
    partial class FrmAdminHome
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
            this.SuspendLayout();
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.Location = new System.Drawing.Point(216, 79);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(179, 42);
            this.btnCreateExam.TabIndex = 0;
            this.btnCreateExam.Text = "Create Exam";
            this.btnCreateExam.UseVisualStyleBackColor = true;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // FrmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 282);
            this.Controls.Add(this.btnCreateExam);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAdminHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateExam;
    }
}