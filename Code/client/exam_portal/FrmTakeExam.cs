using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace exam_portal
{
    public partial class frmTakeExam : Form
    {
        public frmTakeExam()
        {
            InitializeComponent();

            for (int j = 0; j < (PassingValues.quesList.Count); j++)
                {
                if (PassingValues.quesList[j].difficulty_level == "Average")
                {
                    avgList.Add(PassingValues.quesList[j]);
                }
                else
                {
                    diffList.Add(PassingValues.quesList[j]);
                }
            }

            

            lblQstnNbr.Text = "1 .";
            lblQues.Text = avgList[0].question;
            lblOptA.Text = avgList[0].option_a;
            lblOptB.Text = avgList[0].option_b;
            lblOptC.Text = avgList[0].option_c;
            lblOptD.Text = avgList[0].option_d;
            lblFlag.Text = avgList[0].difficulty_level;
        }
       
        public string userAnswer;
        public int avgCount = 0;
        public int diffCount = 1;
        public int i = 0;
        public int score = 0;
        public string grade;
        List<Question> avgList = new List<Question>();
        List<Question> diffList = new List<Question>();

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


            

            radioBtnA.Checked = radioBtnB.Checked = radioBtnC.Checked = radioBtnD.Checked = false;
            if (i >= (PassingValues.quesList.Count / 2) - 2)
            {
                btnNext.Text = "Submit";
            }

            if (i >= (PassingValues.quesList.Count / 2 ) -1)
            {
                btnNext.Text = "Submit";
                PassingValues.grade = calculateScore();
                updateDB();
                frmGradeReport gradeReport = new frmGradeReport();
                this.Hide();
                gradeReport.Show();
            }

            lblQstnNbr.Text = (i + 2).ToString() + " .";
            int diffI = 0;

            if (userAnswer == avgList[i].answer && lblFlag.Text == "Average")
            {
                lblQues.Text = diffList[i].question;
                lblOptA.Text = diffList[i].option_a;
                lblOptB.Text = diffList[i].option_b;
                lblOptC.Text = diffList[i].option_c;
                lblOptD.Text = diffList[i].option_d;
                lblFlag.Text = "Difficult";
                avgCount++;
                diffI++;
            }

            else if (userAnswer == diffList[diffI].answer && lblFlag.Text == "Difficult" && i < (PassingValues.quesList.Count / 2)-1)
            {
                lblQues.Text = diffList[i + 1].question;
                lblOptA.Text = diffList[i + 1].option_a;
                lblOptB.Text = diffList[i + 1].option_b;
                lblOptC.Text = diffList[i + 1].option_c;
                lblOptD.Text = diffList[i + 1].option_d;
                lblFlag.Text = "Difficult";
                diffCount++;
                
            }

            else if(i < (PassingValues.quesList.Count / 2)-1)
            {
                lblQues.Text = avgList[i + 1].question;
                lblOptA.Text = avgList[i + 1].option_a;
                lblOptB.Text = avgList[i + 1].option_b;
                lblOptC.Text = avgList[i + 1].option_c;
                lblOptD.Text = avgList[i + 1].option_d;
                lblFlag.Text = "Average";
                
            }
            i++;
            
        }

        public string calculateScore()
        {
            int totalQues = PassingValues.quesList.Count / 2;
            int maxScore = 2 + (totalQues - 1) * 4;

            //MessageBox.Show("AvgCount is " + avgCount + "DiffCount is " + diffCount);

            score = avgCount * 2 + diffCount * 4;

            if (score >= 0.85 * maxScore)
            {
                grade = "A";
            }
            else if (score >= 0.6 * maxScore && score < 0.85 * maxScore)
            {
                grade = "B";
            }
            else
            {
                grade = "C";
            }
            return grade;
        }

        public void updateDB()
        {
            UserGrades userGrades = new UserGrades();
            Client c = new Client();
            userGrades.user_id = PassingValues.userID;
            userGrades.exam_id = PassingValues.ExamId;
            userGrades.grade = PassingValues.grade;
            string ans = JsonConvert.SerializeObject(userGrades, Formatting.Indented);
            string response = c.send_data(ans, "updateGrades");
            User res = JsonConvert.DeserializeObject<User>(response);
            //MessageBox.Show(response);
        }
        
    }
    
    public class UserGrades
    {
        public int user_id;
        public int exam_id;
        public string grade;
    }
}
