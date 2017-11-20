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
    public partial class frmTakeExam : Form
    {
        public frmTakeExam()
        {
            InitializeComponent();
            

            for (int j = 0; j < (PassingQuesList.quesList.Count); j++)
            {
                if (PassingQuesList.quesList[j].difficulty_level == "Average")
                {
                    avgList.Add(PassingQuesList.quesList[j]);
                }
                else
                {
                    diffList.Add(PassingQuesList.quesList[j]);
                }
            }

            rTxtQuestion.Text = avgList[0].question;
            txtOptionA.Text = avgList[0].option_a;
            txtOptionB.Text = avgList[0].option_b;
            txtOptionC.Text = avgList[0].option_c;
            txtOptionD.Text = avgList[0].option_d;
            lblFlag.Text = avgList[0].difficulty_level;
        }
       
        public string userAnswer;
        public int avgCount = 0;
        public int diffCount = 0;
        public int i = 0;
        public int score = 0;
        List<QuestionList> avgList = new List<QuestionList>();
        List<QuestionList> diffList = new List<QuestionList>();


        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (radioBtnA.Checked)
            {
                userAnswer = "A";
            }
            else if (radioBtnB.Checked)
            {
                userAnswer = "B";
            }
            else if(radioBtnC.Checked)
            {
                userAnswer = "C";
            }
            else if(radioBtnD.Checked)
            {
                userAnswer = "D";
            }
            else
            {
                MessageBox.Show("Select atleast one option");
                return;
            }

            GradeScore.averageCount = avgCount;
            GradeScore.difficultCount = diffCount;

            radioBtnA.Checked = radioBtnB.Checked = radioBtnC.Checked = radioBtnD.Checked = false;

            if (i >= (PassingQuesList.quesList.Count /2 ) -1)
            {
                frmGradeReport gradeReport = new frmGradeReport();
                this.Hide();
                gradeReport.Show();
                MessageBox.Show("AvgCount is " + avgCount + "DiffCount is " + diffCount);
            }

            if (userAnswer == avgList[i].answer && lblFlag.Text == "Average")
            {
                rTxtQuestion.Text = diffList[i].question;
                txtOptionA.Text = diffList[i].option_a;
                txtOptionB.Text = diffList[i].option_b;
                txtOptionC.Text = diffList[i].option_c;
                txtOptionD.Text = diffList[i].option_d;
                lblFlag.Text = "Difficult";
                avgCount++;
            }

            else if (userAnswer == diffList[i].answer && lblFlag.Text == "Difficult" && i < (PassingQuesList.quesList.Count / 2) - 1)
            {
                rTxtQuestion.Text = diffList[i + 1].question;
                txtOptionA.Text = diffList[i + 1].option_a;
                txtOptionB.Text = diffList[i + 1].option_b;
                txtOptionC.Text = diffList[i + 1].option_c;
                txtOptionD.Text = diffList[i + 1].option_d;
                lblFlag.Text = "Difficult";
                diffCount++;
            }
            else if(i < (PassingQuesList.quesList.Count / 2) - 1)
            {
                rTxtQuestion.Text = avgList[i + 1].question;
                txtOptionA.Text = avgList[i + 1].option_a;
                txtOptionB.Text = avgList[i + 1].option_b;
                txtOptionC.Text = avgList[i + 1].option_c;
                txtOptionD.Text = avgList[i + 1].option_d;
                lblFlag.Text = "Average";
            }
            i++;
        }
        
    }
    public static class GradeScore
    {
        public static int averageCount { get; set; }
        public static int difficultCount { get; set; }

    }
}
