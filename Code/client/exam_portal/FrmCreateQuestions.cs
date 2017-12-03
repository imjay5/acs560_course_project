/**************************************************************
 * 
 * Form for Admin to Add Questions to Exam
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
    public partial class frmCreateQuestions : Form
    {
        Question ques = new Question();
        string question_label;
        string mode = "new";
        
        public frmCreateQuestions()
        {
            InitializeComponent();
            question_label = lblQuestion.Text;
            lblQuestion.Text = lblQuestion.Text + " " + ques.count;
            prgBarAvg.Maximum = prgBarDiff.Maximum = PassingValues.NoOfQuestion;
            PassingValues.NoOfAverageQuestions = PassingValues.NoOfDifficultQuestions = 0;
            prgBarAvg.Value = prgBarDiff.Value = 0;
        }
        
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            string response = "";
            if (rTxtQuestion.Text == string.Empty)
            {
                MessageBox.Show("Please enter question");
                return;
            }
            if (txtOptionA.Text == string.Empty || txtOptionB.Text == string.Empty || txtOptionC.Text == string.Empty || txtOptionD.Text == string.Empty)
            {
                MessageBox.Show("Please enter options");
                return;
            }
            if (listBxAnswer.Text == string.Empty)
            {
                MessageBox.Show("Please select correct answer");
                return;
            }
            if (listBxDiffLevel.Text == string.Empty)
            {
                MessageBox.Show("Please select difficulty level");
                return;
            }
        
            var allEqual = new[] { txtOptionA.Text, txtOptionB.Text, txtOptionC.Text, txtOptionD.Text }.Distinct().Count() == 1;
            if (txtOptionA.Text == txtOptionB.Text || txtOptionB.Text == txtOptionC.Text || txtOptionC.Text == txtOptionD.Text || txtOptionD.Text == txtOptionA.Text || txtOptionA.Text == txtOptionC.Text || txtOptionB.Text == txtOptionD.Text)
            {
                MessageBox.Show("Please select different answer for each option");
                return;
            }
            ques.question = rTxtQuestion.Text;
            ques.option_a = txtOptionA.Text;
            ques.option_b = txtOptionB.Text;
            ques.option_c = txtOptionC.Text;
            ques.option_d = txtOptionD.Text;
            ques.answer = listBxAnswer.Text;
            ques.difficulty_level = listBxDiffLevel.Text;
           
            if (PassingValues.NoOfAverageQuestions == PassingValues.NoOfQuestion && ques.difficulty_level == "Average")
            {
                MessageBox.Show("You have already added required number of average questions");
                return;
            }
            if (PassingValues.NoOfDifficultQuestions == PassingValues.NoOfQuestion && ques.difficulty_level == "Difficult")
            {
                MessageBox.Show("You have already added required number of difficult questions");
                return;
            }
            response = ques.createQuestionJson(ques);              
            if (response == "success")
            {
                ques.count = ques.count + 1;
                if (ques.count < (PassingValues.NoOfQuestion * 2))
                {
                    clear();
                }
                else
                {
                    Exam exam = new Exam();
                    exam.status = "Complete";
                    exam.updateExamStatusJson(exam);
                    goToAdminHome();
                }
            }
        }

        private void clear()
        {
            rTxtQuestion.Text = string.Empty;
            txtOptionA.Text = string.Empty;
            txtOptionB.Text = string.Empty;
            txtOptionC.Text = string.Empty;
            txtOptionD.Text = string.Empty;
            listBxAnswer.ClearSelected();
            listBxDiffLevel.ClearSelected();
            updateDisplay();
            if ((ques.count - 1) == (PassingValues.NoOfQuestion*2))
            {
                if (PassingValues.NoOfAverageQuestions == PassingValues.NoOfQuestion && PassingValues.NoOfDifficultQuestions == PassingValues.NoOfQuestion)
                {
                    btnQuestion.Text = "Submit";
                }            
            }
        }

        private void update_progress_bar(ProgressBar pg, string text)
        {
            int percent = (int)(((double)(pg.Value - pg.Minimum) / (double)(pg.Maximum - pg.Minimum)) * 100);
            if (text == "Average")
            {
                lblAvg.Text = percent.ToString() + "%";
            }else
            {
                lblDiff.Text = percent.ToString() + "%";
            }
        }
  
        private void updateDisplay()
        {
            lblQuestion.Text = question_label + " " + ques.count;
            prgBarAvg.Value = PassingValues.NoOfAverageQuestions;
            update_progress_bar(prgBarAvg, "Average");
            prgBarDiff.Value = PassingValues.NoOfDifficultQuestions;
            update_progress_bar(prgBarDiff, "Difficult");
        }

        private void goToAdminHome()
        {
            //PassingValues.QuestionId = 0;
            frmAdminHome adminHome = new frmAdminHome();
            adminHome.Closed += (s, args) => this.Close();
            adminHome.Show();
            this.Hide();
        }
    }
}
