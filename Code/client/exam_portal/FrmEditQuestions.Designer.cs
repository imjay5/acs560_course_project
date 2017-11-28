namespace exam_portal
{
    partial class frmEditQuestions
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
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(307, 424);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(191, 23);
            this.btnDeleteQuestion.TabIndex = 1;
            this.btnDeleteQuestion.Text = "Delete Selected Question";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Enabled = false;
            this.btnAddQuestion.Location = new System.Drawing.Point(539, 424);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(163, 23);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Add New Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(749, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(195, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Update Selected Question";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1001, 471);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1143, 471);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(65, 379);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(95, 23);
            this.btnAddRow.TabIndex = 6;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(165, 379);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteRow.TabIndex = 7;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.AutoScroll = true;
            this.pnlQuestions.Location = new System.Drawing.Point(65, 38);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(1236, 335);
            this.pnlQuestions.TabIndex = 0;
            // 
            // frmEditQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 538);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.pnlQuestions);
            this.Name = "frmEditQuestions";
            this.Text = "FrmEditQuestions";
            this.Load += new System.EventHandler(this.FrmEditQuestions_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Panel pnlQuestions;
    }
}