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
            lblUserName.Text = PassingValues.name + ",";
        }

        Client c = new Client();
        Question ques = new Question();

        public List<Exam> examList;
        public List<Question> questionList;

        private void frmUserHome_Load(object sender, EventArgs e)
        {
            seeAvlExams();
            seeTakenExams();
        }

        private void seeAvlExams()
        {
            User user = new User();
            user.user_id = PassingValues.userID;
            string ans = JsonConvert.SerializeObject(user, Formatting.Indented);
            string response = c.send_data(ans, "selectExam");

            try
            {
                examList = JsonConvert.DeserializeObject<List<Exam>>(response);

                Label lblEx = new Label();
                lblEx.Text = "#";
                lblEx.ForeColor = Color.Black;
                lblEx.BackColor = Color.Transparent;
                lblEx.Size = new Size(30, 23);
                lblEx.Location = new Point(100, 285);
                lblEx.Font = new Font("Consolas", 10, FontStyle.Underline);
                this.Controls.Add(lblEx);
                lblEx.BringToFront();

                Label lblTitle = new Label();
                lblTitle.Text = "Exam Title";
                lblTitle.ForeColor = Color.Black;
                lblTitle.BackColor = Color.Transparent;
                lblTitle.Size = new Size(180, 23);
                lblTitle.Location = new Point(150, 285);
                lblTitle.Font = new Font("Consolas", 10, FontStyle.Underline);
                this.Controls.Add(lblTitle);
                lblTitle.BringToFront();

                for (int i = 0; i < examList.Count(); i++)
                {
                    Label lblExamID = new Label();
                    lblExamID.Text = (i + 1).ToString();
                    lblExamID.ForeColor = Color.Black;
                    lblExamID.BackColor = Color.Transparent;
                    lblExamID.Size = new Size(30, 23);
                    lblExamID.Location = new Point(100, 320 + (25 * i));
                    lblExamID.Font = new Font("Consolas", 10, FontStyle.Regular);
                    this.Controls.Add(lblExamID);
                    lblExamID.BringToFront();

                    Label lblExamTitle = new Label();
                    lblExamTitle.Text = examList[i].exam_title;
                    lblExamTitle.Font = new Font("Consolas", 10, FontStyle.Regular);
                    lblExamTitle.ForeColor = Color.Black;
                    lblExamTitle.BackColor = Color.Transparent;
                    lblExamTitle.Size = new Size(180, 23);
                    lblExamTitle.Location = new Point(150, 320 + (25 * i));
                    lblExamTitle.Font = new Font("Consolas", 10, FontStyle.Regular);
                    this.Controls.Add(lblExamTitle);
                    lblExamTitle.BringToFront();

                    Button btnTakeExam = new Button();
                    btnTakeExam.Text = "Take Exam";
                    btnTakeExam.Name = examList[i].exam_id.ToString();
                    btnTakeExam.BackColor = Color.AliceBlue;
                    btnTakeExam.Font = new Font("Arial", 10, FontStyle.Regular);
                    btnTakeExam.ForeColor = Color.Black;
                    btnTakeExam.Size = new Size(90, 23);
                    btnTakeExam.Location = new Point(300, 320 + (25 * i));
                    this.Controls.Add(btnTakeExam);
                    btnTakeExam.BringToFront();
                    btnTakeExam.Click += new EventHandler(btnTakeExam_Click);

                }
            }
            catch (Exception)
            {
                Label lblMsg = new Label();
                lblMsg.Text = "There are no available exams at the moment..!!";
                lblMsg.ForeColor = Color.Black;
                lblMsg.BackColor = Color.Transparent;
                lblMsg.Size = new Size(500, 23);
                lblMsg.Location = new Point(100, 285);
                lblMsg.Font = new Font("Consolas", 8, FontStyle.Italic);
                this.Controls.Add(lblMsg);
                lblMsg.BringToFront();
            }
        }

        protected void btnTakeExam_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Exam exam = new Exam();
            exam.exam_id = Int32.Parse(button.Name);
            string ans = JsonConvert.SerializeObject(exam, Formatting.Indented);
            string response = c.send_data(ans, "takeExam");
            questionList = JsonConvert.DeserializeObject<List<Question>>(response);
            PassingValues.quesList = questionList;
            PassingValues.ExamId = exam.exam_id;
            frmStartExam startExam = new frmStartExam();
            this.Hide();
            startExam.Show();
        }

        private void seeTakenExams()
        {
            User user = new User();
            user.user_id = PassingValues.userID;
            string ans = JsonConvert.SerializeObject(user, Formatting.Indented);
            string response = c.send_data(ans, "takenExams");
            try
            {
                examList = JsonConvert.DeserializeObject<List<Exam>>(response);

                Label lblEx = new Label();
                lblEx.Text = "#";
                lblEx.ForeColor = Color.Black;
                lblEx.BackColor = Color.Transparent;
                lblEx.Size = new Size(30, 23);
                lblEx.Location = new Point(450, 285);
                lblEx.Font = new Font("Consolas", 10, FontStyle.Underline);
                this.Controls.Add(lblEx);
                lblEx.BringToFront();

                Label lblTitle = new Label();
                lblTitle.Text = "Exam Title";
                lblTitle.ForeColor = Color.Black;
                lblTitle.BackColor = Color.Transparent;
                lblTitle.Size = new Size(180, 23);
                lblTitle.Location = new Point(500, 285);
                lblTitle.Font = new Font("Consolas", 10, FontStyle.Underline);
                this.Controls.Add(lblTitle);
                lblTitle.BringToFront();

                Label lblGrd = new Label();
                lblGrd.Text = "Grade";
                lblGrd.ForeColor = Color.Black;
                lblGrd.BackColor = Color.Transparent;
                lblGrd.Size = new Size(100, 23);
                lblGrd.Location = new Point(682, 285);
                lblGrd.Font = new Font("Consolas", 10, FontStyle.Underline);
                this.Controls.Add(lblGrd);
                lblGrd.BringToFront();


                for (int i = 0; i < examList.Count(); i++)
                {
                    Label lblExamID = new Label();
                    lblExamID.Text = (i + 1).ToString();
                    lblExamID.ForeColor = Color.Black;
                    lblExamID.BackColor = Color.Transparent;
                    lblExamID.Size = new Size(30, 23);
                    lblExamID.Font = new Font("Consolas", 10, FontStyle.Regular);
                    lblExamID.Location = new Point(450, 320 + (25 * i));
                    this.Controls.Add(lblExamID);
                    lblExamID.BringToFront();

                    Label lblExamTitle = new Label();
                    lblExamTitle.Text = examList[i].exam_title;
                    lblExamTitle.ForeColor = Color.Black;
                    lblExamTitle.BackColor = Color.Transparent;
                    lblExamTitle.Size = new Size(180, 23);
                    lblExamTitle.Font = new Font("Consolas", 10, FontStyle.Regular);
                    lblExamTitle.Location = new Point(500, 320 + (25 * i));
                    this.Controls.Add(lblExamTitle);
                    lblExamTitle.BringToFront();

                    Label lblGrade = new Label();
                    lblGrade.Text = examList[i].grade;
                    lblGrade.ForeColor = Color.Black;
                    lblGrade.BackColor = Color.Transparent;
                    lblGrade.Size = new Size(30, 23);
                    lblGrade.Font = new Font("Consolas", 10, FontStyle.Regular);
                    lblGrade.Location = new Point(700, 320 + (25 * i));
                    this.Controls.Add(lblGrade);
                    lblGrade.BringToFront();
                }
            }
            catch (Exception)
            {
                Label lblMsg = new Label();
                lblMsg.Text = "You haven't taken any exams yet..!!";
                lblMsg.ForeColor = Color.Black;
                lblMsg.BackColor = Color.Transparent;
                lblMsg.Size = new Size(250, 23);
                lblMsg.Location = new Point(450, 285);
                lblMsg.Font = new Font("Consolas", 8, FontStyle.Italic);
                this.Controls.Add(lblMsg);
                lblMsg.BringToFront();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.Show();
        }
    }

}
