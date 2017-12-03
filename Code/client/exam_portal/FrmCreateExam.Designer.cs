namespace exam_portal
{
    partial class frmCreateExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateExam));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.txtQuestions = new System.Windows.Forms.TextBox();
            this.chkBxTimer = new System.Windows.Forms.CheckBox();
            this.lblTimerReq = new System.Windows.Forms.Label();
            this.txtTimerVal = new System.Windows.Forms.TextBox();
            this.lblTimerVal = new System.Windows.Forms.Label();
            this.btnExam = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnGoToQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(140, 206);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Exam Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(278, 206);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(292, 27);
            this.txtTitle.TabIndex = 1;
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.ForeColor = System.Drawing.Color.Black;
            this.lblQuestions.Location = new System.Drawing.Point(140, 254);
            this.lblQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(79, 38);
            this.lblQuestions.TabIndex = 2;
            this.lblQuestions.Text = "No of \r\nQuestions";
            // 
            // txtQuestions
            // 
            this.txtQuestions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestions.Location = new System.Drawing.Point(278, 254);
            this.txtQuestions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuestions.MaxLength = 2;
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.Size = new System.Drawing.Size(76, 27);
            this.txtQuestions.TabIndex = 3;
            this.txtQuestions.Leave += new System.EventHandler(this.txtQuestions_Leave);
            // 
            // chkBxTimer
            // 
            this.chkBxTimer.AutoSize = true;
            this.chkBxTimer.BackColor = System.Drawing.Color.Transparent;
            this.chkBxTimer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxTimer.ForeColor = System.Drawing.Color.Black;
            this.chkBxTimer.Location = new System.Drawing.Point(278, 317);
            this.chkBxTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBxTimer.Name = "chkBxTimer";
            this.chkBxTimer.Size = new System.Drawing.Size(53, 23);
            this.chkBxTimer.TabIndex = 4;
            this.chkBxTimer.Text = "Yes";
            this.chkBxTimer.UseVisualStyleBackColor = false;
            this.chkBxTimer.CheckedChanged += new System.EventHandler(this.chkBxTimer_CheckedChanged);
            // 
            // lblTimerReq
            // 
            this.lblTimerReq.AutoSize = true;
            this.lblTimerReq.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerReq.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerReq.ForeColor = System.Drawing.Color.Black;
            this.lblTimerReq.Location = new System.Drawing.Point(140, 318);
            this.lblTimerReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerReq.Name = "lblTimerReq";
            this.lblTimerReq.Size = new System.Drawing.Size(127, 19);
            this.lblTimerReq.TabIndex = 5;
            this.lblTimerReq.Text = "Timer Required?";
            // 
            // txtTimerVal
            // 
            this.txtTimerVal.Enabled = false;
            this.txtTimerVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimerVal.Location = new System.Drawing.Point(278, 376);
            this.txtTimerVal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimerVal.Name = "txtTimerVal";
            this.txtTimerVal.Size = new System.Drawing.Size(76, 27);
            this.txtTimerVal.TabIndex = 6;
            // 
            // lblTimerVal
            // 
            this.lblTimerVal.AutoSize = true;
            this.lblTimerVal.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerVal.ForeColor = System.Drawing.Color.Black;
            this.lblTimerVal.Location = new System.Drawing.Point(140, 363);
            this.lblTimerVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerVal.Name = "lblTimerVal";
            this.lblTimerVal.Size = new System.Drawing.Size(117, 38);
            this.lblTimerVal.TabIndex = 7;
            this.lblTimerVal.Text = "Timer Duration\r\n(in minutes)\r\n";
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExam.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Location = new System.Drawing.Point(256, 427);
            this.btnExam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(156, 36);
            this.btnExam.TabIndex = 8;
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblMsg.Location = new System.Drawing.Point(275, 283);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 9;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(283, 155);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(114, 19);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "Create Exam";
            // 
            // btnGoToQuestions
            // 
            this.btnGoToQuestions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGoToQuestions.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnGoToQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToQuestions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToQuestions.Location = new System.Drawing.Point(428, 427);
            this.btnGoToQuestions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoToQuestions.Name = "btnGoToQuestions";
            this.btnGoToQuestions.Size = new System.Drawing.Size(156, 36);
            this.btnGoToQuestions.TabIndex = 12;
            this.btnGoToQuestions.Text = "Go To Questions";
            this.btnGoToQuestions.UseVisualStyleBackColor = false;
            this.btnGoToQuestions.Visible = false;
            this.btnGoToQuestions.Click += new System.EventHandler(this.btnGoToQuestions_Click);
            // 
            // frmCreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 602);
            this.Controls.Add(this.btnGoToQuestions);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.lblTimerVal);
            this.Controls.Add(this.txtTimerVal);
            this.Controls.Add(this.lblTimerReq);
            this.Controls.Add(this.chkBxTimer);
            this.Controls.Add(this.txtQuestions);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCreateExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Exam";
            this.Load += new System.EventHandler(this.frmCreateExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.TextBox txtQuestions;
        private System.Windows.Forms.CheckBox chkBxTimer;
        private System.Windows.Forms.Label lblTimerReq;
        private System.Windows.Forms.TextBox txtTimerVal;
        private System.Windows.Forms.Label lblTimerVal;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnGoToQuestions;
    }
}

