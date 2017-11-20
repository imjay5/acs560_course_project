using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace exam_portal
{
    public partial class frmUserHome : Form
    {
        public frmUserHome()
        {
            InitializeComponent();
        }

        Client c = new Client();
        //ExamDetails exam = new ExamDetails();

        public List<Response1> resList;
        public List<QuestionList> questionList;



        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            this.Hide();
            loginForm.Show();
            Application.Exit();
        }

        private void btnSeeAvlExams_Click(object sender, EventArgs e)
        {
            //frmTakeExam takeExamForm = new frmTakeExam();
            //this.Hide();
            //takeExamForm.Show();

            //string ans = JsonConvert.SerializeObject(exam, Formatting.Indented);
            string response = c.send_data(null, "selectExam");
            //MessageBox.Show(ans);
            MessageBox.Show(response);
            //var examSet = JsonConvert.DeserializeObject<Wrapper>(response).ExamSet;
            resList = JsonConvert.DeserializeObject<List<Response1>>(response);
            //MessageBox.Show(res.msg);

            for(int i=0; i<resList.Count();i++){ 
                Label lbl = new Label();
                lbl.Text = resList[i].exam_id.ToString();
                lbl.ForeColor = Color.White;
                lbl.Location = new Point(100, 200 + (50 * i));
                this.Controls.Add(lbl);
                lbl.BringToFront();

                Label lbl2 = new Label();
                lbl2.Text = resList[i].exam_title;
                lbl2.ForeColor = Color.White;
                lbl2.Location = new Point(250, 200 + (50 * i));
                this.Controls.Add(lbl2);
                lbl2.BringToFront();

                /*Button btn = new Button();
                btn.Text = "Take Exam";
                btn.BackColor = Color.DarkKhaki;
                btn.ForeColor = Color.Black;
                btn.Location = new Point(400, 200 + (50 * i));
                this.Controls.Add(btn);
                btn.BringToFront();
                btn.Click += new EventHandler(btn_Click);*/
                
            }
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            string response = c.send_data(null, "takeExam");            
            MessageBox.Show(response);            
            questionList = JsonConvert.DeserializeObject<List<QuestionList>>(response);
            PassingQuesList.quesList = questionList;

            frmStartExam startExam = new frmStartExam();
            this.Hide();
            startExam.Show();
        }
    }


    public class Response1
    {
        public int exam_id;
        public string exam_title;        
    }

    public class QuestionList
    {
        public int question_id;
        public string question;
        public string option_a;
        public string option_b;
        public string option_c;
        public string option_d;
        public string answer;
        public string difficulty_level;

    }

    public static class PassingQuesList
    {
        public static List<QuestionList> quesList { get; set; }

    }
    }
