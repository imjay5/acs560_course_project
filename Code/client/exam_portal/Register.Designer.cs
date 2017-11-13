namespace exam_portal
{
    partial class Register
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblRPwd = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPwd = new System.Windows.Forms.TextBox();
            this.txtBoxRPwd = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(235, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 23);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Black;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(235, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 23);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Black;
            this.lblPwd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPwd.Location = new System.Drawing.Point(235, 254);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(159, 23);
            this.lblPwd.TabIndex = 8;
            this.lblPwd.Text = "Enter Password";
            this.lblPwd.Click += new System.EventHandler(this.lblPwd_Click);
            // 
            // lblRPwd
            // 
            this.lblRPwd.AutoSize = true;
            this.lblRPwd.BackColor = System.Drawing.Color.Black;
            this.lblRPwd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPwd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRPwd.Location = new System.Drawing.Point(235, 305);
            this.lblRPwd.Name = "lblRPwd";
            this.lblRPwd.Size = new System.Drawing.Size(184, 23);
            this.lblRPwd.TabIndex = 9;
            this.lblRPwd.Text = "Confirm Password";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(455, 141);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(159, 27);
            this.txtBoxName.TabIndex = 10;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(455, 196);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(159, 27);
            this.txtBoxEmail.TabIndex = 11;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.txtBoxEmail_TextChanged);
            // 
            // txtBoxPwd
            // 
            this.txtBoxPwd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPwd.Location = new System.Drawing.Point(455, 250);
            this.txtBoxPwd.Name = "txtBoxPwd";
            this.txtBoxPwd.Size = new System.Drawing.Size(159, 27);
            this.txtBoxPwd.TabIndex = 12;
            this.txtBoxPwd.TextChanged += new System.EventHandler(this.txtBoxPwd_TextChanged);
            // 
            // txtBoxRPwd
            // 
            this.txtBoxRPwd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRPwd.Location = new System.Drawing.Point(455, 301);
            this.txtBoxRPwd.Name = "txtBoxRPwd";
            this.txtBoxRPwd.Size = new System.Drawing.Size(159, 27);
            this.txtBoxRPwd.TabIndex = 13;
            this.txtBoxRPwd.TextChanged += new System.EventHandler(this.txtBoxRPwd_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(398, 390);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 32);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 602);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxRPwd);
            this.Controls.Add(this.txtBoxPwd);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblRPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblRPwd;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPwd;
        private System.Windows.Forms.TextBox txtBoxRPwd;
        private System.Windows.Forms.Button btnRegister;
    }
}