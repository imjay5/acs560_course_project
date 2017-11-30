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

            frmLogin frm = new frmLogin();
            frm.AddExitButtons();
            
        }

        Client c = new Client();
        Question ques = new Question();

        public List<Exam> examList;
        public List<Question> questionList;
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            this.Hide();
            loginForm.Show();
            Application.Exit();
        }

        private void btnSeeAvlExams_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.user_id = PassingValues.userID;
            string ans = JsonConvert.SerializeObject(user, Formatting.Indented);
            string response = c.send_data(ans, "selectExam");
            examList = JsonConvert.DeserializeObject<List<Exam>>(response);

            for(int i=0; i< examList.Count();i++){ 
                Label lbl = new Label();
                lbl.Text = examList[i].exam_id.ToString();
                lbl.ForeColor = Color.White;
                lbl.Size = new Size(30, 23);
                lbl.BackColor = Color.Orange;
                lbl.Location = new Point(100, 320 + (25 * i));
                lbl.Font = new Font("Consolas", 10, FontStyle.Regular);
                this.Controls.Add(lbl);
                lbl.BringToFront();

                Label lbl2 = new Label();
                lbl2.Text = examList[i].exam_title;
                lbl2.Font = new Font("Consolas", 10, FontStyle.Regular);
                lbl2.ForeColor = Color.White;
                lbl2.BackColor = Color.Orange;
                lbl2.Size = new Size(180, 23);
                lbl2.Location = new Point(150, 320 + (25 * i));
                lbl2.Font = new Font("Consolas", 10, FontStyle.Regular);
                this.Controls.Add(lbl2);
                lbl2.BringToFront();

                Button btn = new Button();
                btn.Text = "Take Exam";
                btn.Name = examList[i].exam_id.ToString();
                btn.BackColor = Color.AliceBlue;
                btn.Font = new Font("Arial", 10, FontStyle.Regular);
                btn.ForeColor = Color.Black;
                btn.Size = new Size(90, 23);
                btn.Location = new Point(300, 320 + (25 * i));
                this.Controls.Add(btn);
                btn.BringToFront();
                btn.Click += new EventHandler(button_Click);
                
            }            
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Exam exam = new Exam();
            exam.exam_id = Int32.Parse(button.Name);
            //MessageBox.Show(exam.exam_id.ToString());

            string ans = JsonConvert.SerializeObject(exam, Formatting.Indented);
            string response = c.send_data(ans, "takeExam");
            //MessageBox.Show(response);
            questionList = JsonConvert.DeserializeObject<List<Question>>(response);
            PassingValues.quesList = questionList;
            PassingValues.ExamId = exam.exam_id;

            frmStartExam startExam = new frmStartExam();
            this.Hide();
            startExam.Show();
        }

        private void btnTakenExams_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.user_id = PassingValues.userID;
            string ans = JsonConvert.SerializeObject(user, Formatting.Indented);
            string response = c.send_data(ans, "takenExams");
            //MessageBox.Show(response);
            try
            {
                examList = JsonConvert.DeserializeObject<List<Exam>>(response);

                for (int i = 0; i < examList.Count(); i++)
                {
                    Label lbl = new Label();
                    lbl.Text = examList[i].exam_id.ToString();
                    lbl.ForeColor = Color.White;
                    lbl.BackColor = Color.Orange;
                    lbl.Size = new Size(30, 23);
                    lbl.Font = new Font("Consolas", 10, FontStyle.Regular);
                    lbl.Location = new Point(450, 320 + (25 * i));
                    this.Controls.Add(lbl);
                    lbl.BringToFront();

                    Label lbl2 = new Label();
                    lbl2.Text = examList[i].exam_title;
                    lbl2.ForeColor = Color.White;
                    lbl2.BackColor = Color.Orange;
                    lbl2.Size = new Size(180, 23);
                    lbl2.Font = new Font("Consolas", 10, FontStyle.Regular);
                    lbl2.Location = new Point(500, 320 + (25 * i));
                    this.Controls.Add(lbl2);
                    lbl2.BringToFront();

                    Label lbl3 = new Label();
                    lbl3.Text = examList[i].grade;
                    lbl3.ForeColor = Color.White;
                    lbl3.BackColor = Color.Orange;
                    lbl3.Size = new Size(30, 23);
                    lbl3.Font = new Font("Consolas", 10, FontStyle.Regular);
                    lbl3.Location = new Point(700, 320 + (25 * i));
                    this.Controls.Add(lbl3);
                    lbl3.BringToFront();
                }
            }
            catch(Exception)
            {
                
                MessageBox.Show("You haven't taken any exams yet");
            }

            
        }       
    }
    

    
}
