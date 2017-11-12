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
        public frmCreateQuestions()
        {
            InitializeComponent();
            question_label = lblQuestion.Text;
            lblQuestion.Text = lblQuestion.Text + (ques.count+1);
            prgBarAvg.Maximum = prgBarDiff.Maximum = PassingValues.NoOfQuestion;
            PassingValues.NoOfAverageQuestions = PassingValues.NoOfDifficultQuestions = 0;
            prgBarAvg.Value = prgBarDiff.Value = 0;
        }
        
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Please select answer");
                return;
            }
            if (listBxDiffLevel.Text == string.Empty)
            {
                MessageBox.Show("Please select difficulty level");
                return;
            }
            var allEqual = new[] { txtOptionA.Text, txtOptionB.Text, txtOptionC.Text, txtOptionD.Text }.Distinct().Count() == 1;
            Console.WriteLine(allEqual);
            if (txtOptionA == txtOptionB || txtOptionB == txtOptionC || txtOptionC == txtOptionD || txtOptionD == txtOptionA || txtOptionA == txtOptionC || txtOptionB == txtOptionD)
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
            /*
            if (PassingValues.NoOfAverageQuestions == ques.count && ques.difficulty_level == "Average")
            {
                //msg that no more average questions can be added
                MessageBox.Show("You have already added required number of average questions");
                return;
            }
            if (PassingValues.NoOfDifficultQuestions == ques.count && ques.difficulty_level == "Difficult")
            {
                //msg that no more difficult questions can be added
                MessageBox.Show("You have already added required number of difficult questions");
                return;
            }*/
            string response = ques.addQuestionJson(ques);
            if (response == "success")
            {
                ques.count = ques.count + 1;
                if (ques.count < (PassingValues.NoOfQuestion*2))
                {
                    clear();
                } else
                {
                    frmCreateExam createExam = new frmCreateExam();
                    createExam.Closed += (s, args) => this.Close();
                    createExam.Show();
                    this.Hide();
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
            lblQuestion.Text = question_label + (ques.count + 1);
            prgBarAvg.Value = PassingValues.NoOfAverageQuestions;
            update_progress_bar(prgBarAvg, "Average");
            prgBarDiff.Value = PassingValues.NoOfDifficultQuestions;
            update_progress_bar(prgBarDiff,"Difficult");
            if ((ques.count - 1) == (PassingValues.NoOfQuestion*2))
            {
                if (PassingValues.NoOfAverageQuestions == PassingValues.NoOfQuestion && PassingValues.NoOfDifficultQuestions == PassingValues.NoOfQuestion)
                {
                    btnAddQuestion.Text = "Submit";
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
    }
}
