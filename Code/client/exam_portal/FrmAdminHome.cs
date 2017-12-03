/**************************************************************
 * 
 * Exam Class containing method to form json to send to server and extract json returned from server
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Jaya			 Creation				 Created File
 *   Kanika          Addition                Added methods btnCreateExam_Click(), addDisplayProperties(), frmAdminHome_Load()
 *   Kanika          Addition                Added methods button_Click(), displayExamData(), btnReport_Click()
 **************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_portal
{
    public partial class frmAdminHome : Form
    {
   
        public frmAdminHome()
        {
            InitializeComponent();
        }
        
        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            frmCreateExam createExam = new frmCreateExam();
            this.Hide();
            PassingValues.Action = "AddExam";
            createExam.Show();
        }
        
        private void addDisplayProperties(Control obj)
        {
            obj.BringToFront();
            obj.Font = new Font("Consolas", 10, FontStyle.Regular);
            //obj.ForeColor = Color.White;
            pnlExams.Controls.Add(obj);
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            displayExamData();
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Exam exam = new Exam();
            exam.exam_id = Int32.Parse(button.Name);
            PassingValues.ExamId = exam.exam_id;
            if (button.Tag.ToString() == "hide")
            {
                exam.status = "Active";
                string msg = exam.updateExamStatusJson(exam);
                if (msg == "success")
                {
                    button.BackColor = Color.Green;
                    button.Text = "Published";
                    button.Tag = "publish";
                }
            } else if (button.Tag.ToString() == "edit")
            {
                PassingValues.Action = "EditExam";
                frmCreateExam createExam = new frmCreateExam();
                this.Hide();
                createExam.Show();
            } else
            {
                exam.status = "Complete";
                string msg = exam.updateExamStatusJson(exam);
                if (msg == "success")
                {
                    button.BackColor = Color.Gray;
                    button.Text = "Unpublished";
                    button.Tag = "hide";
                }
            }
        }

        private void displayExamData()
        {
            Exam exam = new Exam();
            List<Exam> examsList = exam.getAllExamsJson();
            int lblY = 86;

            Label lblExamId = new Label();
            lblExamId.Text = "Exam ";
            lblExamId.Location = new Point(60, lblY);
            lblExamId.Size = new Size(72, 24);
            addDisplayProperties(lblExamId);
            lblExamId.ForeColor = Color.Teal;
            lblExamId.Font = new Font("Consolas",10,FontStyle.Underline);

            Label lblExamTitle = new Label();
            lblExamTitle.Text = "Exam Title";
            lblExamTitle.Location = new Point(130, lblY);
            lblExamTitle.Size = new Size(180, 24);
            addDisplayProperties(lblExamTitle);
            lblExamTitle.ForeColor = Color.Teal;
            lblExamTitle.Font = new Font("Consolas", 10, FontStyle.Underline);

            Label lblNoQuestions = new Label();
            lblNoQuestions.Text = "# questions";
            lblNoQuestions.Location = new Point(320, lblY);
            lblNoQuestions.Size = new Size(10, 24);
            addDisplayProperties(lblNoQuestions);
            lblNoQuestions.ForeColor= Color.Teal;
            lblNoQuestions.Font = new Font("Consolas", 10, FontStyle.Underline);

            for (int i = 0; i < examsList.Count(); i++)
            {
                lblY += 35;

                Label lblExamIdValue = new Label();
                lblExamIdValue.Text = (i + 1).ToString();
                lblExamIdValue.Location = new Point(60, lblY);
                lblExamIdValue.Size = new Size(72, 24);
                addDisplayProperties(lblExamIdValue);

                Label lblExamTitleValue = new Label();
                lblExamTitleValue.Text = examsList[i].exam_title.ToString();
                lblExamTitleValue.Location = new Point(130, lblY);
                lblExamTitleValue.Size = new Size(180, 24);
                addDisplayProperties(lblExamTitleValue);

                Label lblNoQuestionsValue = new Label();
                lblNoQuestionsValue.Text = examsList[i].no_of_question.ToString();
                lblNoQuestionsValue.Location = new Point(320, lblY);
                lblNoQuestionsValue.Size = new Size(10, 24);
                addDisplayProperties(lblNoQuestionsValue);

                Button btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                if (examsList[i].status.ToString() == "Inactive")
                {        
                    btn.Text = "Edit";
                    btn.Tag = "edit";
                    btn.Name = examsList[i].exam_id.ToString();
                    btn.BackColor = Color.Gold;
                }
                else if (examsList[i].status.ToString() == "Complete")
                {
                    btn.Text = "Unpublished";
                    btn.Tag = "hide";
                    btn.Name = examsList[i].exam_id.ToString();
                    btn.BackColor = Color.DarkGray;
                }
                else
                {
                    btn.Text = "Published";
                    btn.Tag = "publish";
                    btn.Name = examsList[i].exam_id.ToString();
                    btn.BackColor = Color.LimeGreen;
                }
                btn.Location = new Point(400, lblY);
                btn.Size = new Size(110,26);
                this.Controls.Add(btn);
                btn.Click += new EventHandler(button_Click);
                addDisplayProperties(btn);
                //btn.Font = new Font("Consolas", 10, FontStyle.Regular);
                btn.FlatAppearance.BorderColor = Color.SteelBlue;
                btn.FlatAppearance.BorderSize = 1;
            }
        }    
        
        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
