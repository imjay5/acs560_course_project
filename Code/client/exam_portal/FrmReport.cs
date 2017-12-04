/**************************************************************
 * 
 * Form for Admin to see report of each of the Exam
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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            List<Exam> examsList = exam.getReportJson();
            int lblY = 36;
            
            Label lblExamId = new Label();
            lblExamId.Text = "#";
            lblExamId.Location = new Point(44, lblY);
            lblExamId.Size = new Size(40, 20);
            addDisplayProperties(lblExamId);
            lblExamId.ForeColor = Color.Teal;
            lblExamId.Font = new Font("Consolas", 10, FontStyle.Underline);

            Label lblExamTitle = new Label();
            lblExamTitle.Text = "Exam Title";
            lblExamTitle.Location = new Point(90, lblY);
            lblExamTitle.Size = new Size(180, 20);
            addDisplayProperties(lblExamTitle);
            lblExamTitle.ForeColor = Color.Teal;
            lblExamTitle.Font = new Font("Consolas", 10, FontStyle.Underline);

            /*Label lblNoQuestions = new Label();
            lblNoQuestions.Text = "# questions";
            lblNoQuestions.Location = new Point(250, lblY);
            lblNoQuestions.Size = new Size(30, 20);
            addDisplayProperties(lblNoQuestions);
            lblExamId.ForeColor = Color.Teal;
            lblExamId.Font = new Font("Consolas", 10, FontStyle.Underline);*/

            Label lblGradeA = new Label();
            lblGradeA.Text = "#Grade A";
            lblGradeA.Location = new Point(280, lblY);
            lblGradeA.Size = new Size(78, 20);
            addDisplayProperties(lblGradeA);
            lblGradeA.ForeColor = Color.Teal;
            lblGradeA.Font = new Font("Consolas", 10, FontStyle.Underline);

            Label lblGradeB = new Label();
            lblGradeB.Text = "#Grade B";
            lblGradeB.Location = new Point(370, lblY);
            lblGradeB.Size = new Size(78, 20);
            addDisplayProperties(lblGradeB);
            lblGradeB.ForeColor = Color.Teal;
            lblGradeB.Font = new Font("Consolas", 10, FontStyle.Underline);

            Label lblGradeC = new Label();
            lblGradeC.Text = "#Grade C";
            lblGradeC.Location = new Point(460, lblY);
            lblGradeC.Size = new Size(78, 20);
            addDisplayProperties(lblGradeC);
            lblGradeC.ForeColor = Color.Teal;
            lblGradeC.Font = new Font("Consolas", 10, FontStyle.Underline);

            for (int i = 0; i < examsList.Count(); i++)
            {
                lblY += 35;

                Label lblExamIdValue = new Label();
                lblExamIdValue.Text = (i + 1).ToString();
                lblExamIdValue.Location = new Point(44, lblY);
                lblExamIdValue.Size = new Size(40, 20);
                addDisplayProperties(lblExamIdValue);

                Label lblExamTitleValue = new Label();
                lblExamTitleValue.Text = examsList[i].exam_title.ToString();
                lblExamTitleValue.Location = new Point(90, lblY);
                lblExamTitleValue.Size = new Size(180, 20);
                addDisplayProperties(lblExamTitleValue);

                /*Label lblNoQuestionsValue = new Label();
                lblNoQuestionsValue.Text = examsList[i].no_of_question.ToString();
                lblNoQuestionsValue.Location = new Point(250, lblY);
                lblNoQuestionsValue.Size = new Size(30, 20);
                addDisplayProperties(lblNoQuestionsValue);*/

                Label lblGradeAValue = new Label();
                lblGradeAValue.Text = examsList[i].gradeA.ToString();
                lblGradeAValue.Location = new Point(280, lblY);
                lblGradeAValue.Size = new Size(78, 20);
                addDisplayProperties(lblGradeAValue);

                Label lblGradeBValue = new Label();
                lblGradeBValue.Text = examsList[i].gradeB.ToString();
                lblGradeBValue.Location = new Point(370, lblY);
                lblGradeBValue.Size = new Size(78, 20);
                addDisplayProperties(lblGradeBValue);

                Label lblGradeCValue = new Label();
                lblGradeCValue.Text = examsList[i].gradeC.ToString();
                lblGradeCValue.Location = new Point(460, lblY);
                lblGradeCValue.Size = new Size(78, 20);
                addDisplayProperties(lblGradeCValue);
            }
        }

        private void addDisplayProperties(Control obj)
        {
            obj.BringToFront();
            obj.Font = new Font("Consolas", 10, FontStyle.Regular);
            pnlReport.Controls.Add(obj);
        }

        
    }
}
