/**************************************************************
 * 
 * Form for Admin to Create Exam
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File

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
    public partial class frmCreateExam : Form
    {
        public frmCreateExam()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            if (txtTitle.Text == string.Empty)
            {
                MessageBox.Show("Please enter Exam Title");
                return;
            }
            if (txtQuestions.Text == string.Empty)
            {
                MessageBox.Show("Please enter number of questions");
                return;
            } else
            {
                int no_ques;
                if(!int.TryParse(txtQuestions.Text, out no_ques))
                {
                    MessageBox.Show("Please enter only numbers");
                    return;
                }
                if (int.Parse(txtQuestions.Text) > 20)
                {
                    MessageBox.Show("Number of questions should be less than 20");
                    return;
                }
            }
            exam.exam_title = txtTitle.Text;
            exam.no_of_question = int.Parse(txtQuestions.Text);
            PassingValues.NoOfQuestion = exam.no_of_question;
            if (chkBxTimer.Checked == true)
            {
                exam.timer_enabled = true;
                exam.timer_duration = int.Parse(txtTimerVal.Text);
            } else
            {
                exam.timer_enabled = false;
            }
            exam.createExamJson(exam);
            frmCreateQuestions createQuestions = new frmCreateQuestions();
            createQuestions.Closed += (s, args) => this.Close();
            createQuestions.Show();
            this.Hide();
        }

        private void chkBxTimer_CheckedChanged(object sender, EventArgs e)
        {
            txtTimerVal.Enabled = chkBxTimer.Checked;
        }

        private void txtQuestions_Leave(object sender, EventArgs e)
        {
            //display message to add # questions depending on the value that user has entered
            //also display message that how many average and how many difficult questions needs to be added to this exam
            int totalQ = int.Parse(txtQuestions.Text);
            lblMsg.Text = "Please add " + totalQ + " difficult and " + totalQ + " average questions for this exam.";
        }

        private void frmCreateExam_Load(object sender, EventArgs e)
        {

        }
    }
}
