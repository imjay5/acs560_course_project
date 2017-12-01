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
            lblExamId.Text = "Exam ";
            lblExamId.Location = new Point(44, lblY);
            lblExamId.Size = new Size(10, 20);
            addDisplayProperties(lblExamId);

            Label lblExamTitle = new Label();
            lblExamTitle.Text = "Exam Title";
            lblExamTitle.Location = new Point(60, lblY);
            lblExamTitle.Size = new Size(180, 20);
            addDisplayProperties(lblExamTitle);

            Label lblNoQuestions = new Label();
            lblNoQuestions.Text = "# questions";
            lblNoQuestions.Location = new Point(250, lblY);
            lblNoQuestions.Size = new Size(30, 20);
            addDisplayProperties(lblNoQuestions);

            Label lblGradeA = new Label();
            lblGradeA.Text = "# Grade A";
            lblGradeA.Location = new Point(290, lblY);
            lblGradeA.Size = new Size(30, 20);
            addDisplayProperties(lblGradeA);

            Label lblGradeB = new Label();
            lblGradeB.Text = "# Grade B";
            lblGradeB.Location = new Point(330, lblY);
            lblGradeB.Size = new Size(30, 20);
            addDisplayProperties(lblGradeB);

            Label lblGradeC = new Label();
            lblGradeC.Text = "# Grade C";
            lblGradeC.Location = new Point(370, lblY);
            lblGradeC.Size = new Size(30, 20);
            addDisplayProperties(lblGradeC);

            for (int i = 0; i < examsList.Count(); i++)
            {
                lblY += 35;

                Label lblExamIdValue = new Label();
                lblExamIdValue.Text = (i + 1).ToString();
                lblExamIdValue.Location = new Point(44, lblY);
                lblExamIdValue.Size = new Size(10, 20);
                addDisplayProperties(lblExamIdValue);

                Label lblExamTitleValue = new Label();
                lblExamTitleValue.Text = examsList[i].exam_title.ToString();
                lblExamTitleValue.Location = new Point(60, lblY);
                lblExamTitleValue.Size = new Size(180, 20);
                addDisplayProperties(lblExamTitleValue);

                Label lblNoQuestionsValue = new Label();
                lblNoQuestionsValue.Text = examsList[i].no_of_question.ToString();
                lblNoQuestionsValue.Location = new Point(250, lblY);
                lblNoQuestionsValue.Size = new Size(30, 20);
                addDisplayProperties(lblNoQuestionsValue);

                Label lblGradeAValue = new Label();
                lblGradeAValue.Text = examsList[i].gradeA.ToString();
                lblGradeAValue.Location = new Point(290, lblY);
                lblGradeAValue.Size = new Size(30, 20);
                addDisplayProperties(lblGradeAValue);

                Label lblGradeBValue = new Label();
                lblGradeBValue.Text = examsList[i].gradeB.ToString();
                lblGradeBValue.Location = new Point(330, lblY);
                lblGradeBValue.Size = new Size(30, 20);
                addDisplayProperties(lblGradeBValue);

                Label lblGradeCValue = new Label();
                lblGradeCValue.Text = examsList[i].gradeC.ToString();
                lblGradeCValue.Location = new Point(370, lblY);
                lblGradeCValue.Size = new Size(30, 20);
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
