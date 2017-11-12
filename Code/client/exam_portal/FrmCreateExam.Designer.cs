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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.txtQuestions = new System.Windows.Forms.TextBox();
            this.chkBxTimer = new System.Windows.Forms.CheckBox();
            this.lblTimerReq = new System.Windows.Forms.Label();
            this.txtTimerVal = new System.Windows.Forms.TextBox();
            this.lblTimerVal = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(97, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Exam Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(289, 72);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 32);
            this.txtTitle.TabIndex = 1;
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.Location = new System.Drawing.Point(97, 135);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(109, 48);
            this.lblQuestions.TabIndex = 2;
            this.lblQuestions.Text = "No of \r\nQuestions";
            // 
            // txtQuestions
            // 
            this.txtQuestions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestions.Location = new System.Drawing.Point(289, 135);
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.Size = new System.Drawing.Size(100, 32);
            this.txtQuestions.TabIndex = 3;
            this.txtQuestions.Leave += new System.EventHandler(this.txtQuestions_Leave);
            // 
            // chkBxTimer
            // 
            this.chkBxTimer.AutoSize = true;
            this.chkBxTimer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxTimer.Location = new System.Drawing.Point(289, 230);
            this.chkBxTimer.Name = "chkBxTimer";
            this.chkBxTimer.Size = new System.Drawing.Size(64, 28);
            this.chkBxTimer.TabIndex = 4;
            this.chkBxTimer.Text = "Yes";
            this.chkBxTimer.UseVisualStyleBackColor = true;
            this.chkBxTimer.CheckedChanged += new System.EventHandler(this.chkBxTimer_CheckedChanged);
            // 
            // lblTimerReq
            // 
            this.lblTimerReq.AutoSize = true;
            this.lblTimerReq.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerReq.Location = new System.Drawing.Point(97, 231);
            this.lblTimerReq.Name = "lblTimerReq";
            this.lblTimerReq.Size = new System.Drawing.Size(178, 24);
            this.lblTimerReq.TabIndex = 5;
            this.lblTimerReq.Text = "Timer Required?";
            // 
            // txtTimerVal
            // 
            this.txtTimerVal.Enabled = false;
            this.txtTimerVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimerVal.Location = new System.Drawing.Point(289, 282);
            this.txtTimerVal.Name = "txtTimerVal";
            this.txtTimerVal.Size = new System.Drawing.Size(100, 32);
            this.txtTimerVal.TabIndex = 6;
            // 
            // lblTimerVal
            // 
            this.lblTimerVal.AutoSize = true;
            this.lblTimerVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerVal.Location = new System.Drawing.Point(97, 285);
            this.lblTimerVal.Name = "lblTimerVal";
            this.lblTimerVal.Size = new System.Drawing.Size(162, 48);
            this.lblTimerVal.TabIndex = 7;
            this.lblTimerVal.Text = "Timer Duration\r\n(in minutes)\r\n";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(253, 368);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(208, 44);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Exam";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(266, 160);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 9;
            // 
            // frmCreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 520);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTimerVal);
            this.Controls.Add(this.txtTimerVal);
            this.Controls.Add(this.lblTimerReq);
            this.Controls.Add(this.chkBxTimer);
            this.Controls.Add(this.txtQuestions);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreateExam";
            this.Text = "Create Exam";
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
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblMsg;
    }
}

