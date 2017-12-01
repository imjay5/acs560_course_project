/**************************************************************
 * 
 * Form for Admin to Create Exam
 *
 * 	                Version History
 *   Author          Type of change          Description
 *   Kanika			 Addition				 Created File
 *   Kanika          Addition                Added methods for Edit Exam functionality
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

        private void btnExam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            if (checkValidations())
            {
                exam.exam_title = txtTitle.Text;
                exam.no_of_question = int.Parse(txtQuestions.Text);
                PassingValues.NoOfQuestion = exam.no_of_question;
                if (chkBxTimer.Checked == true)
                {
                    exam.timer_enabled = true;
                    exam.timer_duration = int.Parse(txtTimerVal.Text);
                }
                else
                {
                    exam.timer_enabled = false;
                }
                if (PassingValues.Action == "AddExam")
                {
                    exam.examJson(exam, "AddExam");
                    frmCreateQuestions createQuestions = new frmCreateQuestions();
                    createQuestions.Closed += (s, args) => this.Close();
                    createQuestions.Show();
                    this.Hide();
                }
                else
                {
                    exam.exam_id = PassingValues.ExamId;
                    if (exam.no_of_question != int.Parse(txtQuestions.Text))
                    {
                        exam.status = "Inactive";  
                    } 
                    exam.examJson(exam, "UpdateExam");
                    frmAdminHome adminHome = new frmAdminHome();
                    adminHome.Closed += (s, args) => this.Close();
                    adminHome.Show();
                    this.Hide();
                }
            }
        }

        private void chkBxTimer_CheckedChanged(object sender, EventArgs e)
        {
            txtTimerVal.Enabled = chkBxTimer.Checked;
        }

        private void txtQuestions_Leave(object sender, EventArgs e)
        {
            int totalQ = int.Parse(txtQuestions.Text);
            lblMsg.Text = "Please add " + totalQ + " difficult and " + totalQ + " average questions for this exam.";
        }

        private void frmCreateExam_Load(object sender, EventArgs e)
        {
            string action = PassingValues.Action;
            switch (action)
            {
                case "AddExam":
                    btnExam.Text = "Create Exam";
                    break;
                case "EditExam":
                    btnExam.Text = "Save & Close";
                    btnGoToQuestions.Visible = true;
                    Exam exam = new Exam();
                    exam.exam_id = PassingValues.ExamId;
                    exam = exam.getExamJson(exam);
                    populateFields(exam);
                    break;
            }
        }

        private bool checkValidations()
        {
            if (txtTitle.Text == string.Empty)
            {
                MessageBox.Show("Please enter Exam Title");
                return false;
            }
            if (txtQuestions.Text == string.Empty)
            {
                MessageBox.Show("Please enter number of questions");
                return false;
            }
            else
            {
                int no_ques;
                if (!int.TryParse(txtQuestions.Text, out no_ques))
                {
                    MessageBox.Show("Please enter only numbers");
                    return false;
                }
                if (int.Parse(txtQuestions.Text) > 20)
                {
                    MessageBox.Show("Number of questions should be less than 20");
                    return false;
                }
            }
            if (chkBxTimer.Checked == true)
            {
                if (txtTimerVal.Text == string.Empty)
                {
                    MessageBox.Show("Please enter timer value");
                    return false;
                }
            }
            return true;
        }
        
        private void populateFields(Exam exam_data)
        {
            txtTitle.Text = exam_data.exam_title;
            txtQuestions.Text = exam_data.no_of_question.ToString();
            if (exam_data.timer_enabled == true)
            {
                chkBxTimer.Checked = true;
                txtTimerVal.Text = exam_data.timer_duration.ToString();
            }
            else
            {
                chkBxTimer.Checked = false;
            }
        }

        private void btnGoToQuestions_Click(object sender, EventArgs e)
        {
            PassingValues.NoOfQuestion = int.Parse(txtQuestions.Text);
            frmEditQuestions editQuestions = new frmEditQuestions();
            editQuestions.Closed += (s, args) => this.Close();
            editQuestions.Show();
            this.Hide();
        }
    }
}
