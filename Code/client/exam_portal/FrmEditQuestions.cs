/**************************************************************
 * 
 * Form for Admin to Edit Questions of the Exam that has not been published yet
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
    public partial class frmEditQuestions : Form
    {
        Question ques = new Question();
        int list_count;
        DataGridView dg;
        DataTable dt;
        
        public frmEditQuestions()
        {
            InitializeComponent();
            dg = new DataGridView();
            dt = new DataTable();
            list_count = 0;
        }

        private void FrmEditQuestions_Load(object sender, EventArgs e)
        {
            List<Question> allQuestionsList = ques.getAllQuestionsJson();
            formDataGrid(allQuestionsList);
        }

        private void addDisplayProperties(Control obj)
        {
            obj.BringToFront();
            obj.Font = new Font("Consolas",8,FontStyle.Regular);
            pnlQuestions.Controls.Add(obj);
            obj.Enabled = false;
        }

        private void formDataGrid(List<Question> questionList)
        {

            if (questionList != null)
            {
                list_count = questionList.Count();
            } else
            {
                list_count = 0;
            }
            
            DataTable dataTable = ConvertToDataTable(questionList);
            dg.AutoGenerateColumns = false;  

            DataGridViewTextBoxColumn dgtxtBoxQuestion = new DataGridViewTextBoxColumn();
            dgtxtBoxQuestion.DataPropertyName = "Question";
            dgtxtBoxQuestion.HeaderText = "Question";
            dg.Columns.Add(dgtxtBoxQuestion);

            DataGridViewTextBoxColumn dgtxtBoxOptionA = new DataGridViewTextBoxColumn();
            dgtxtBoxOptionA.DataPropertyName = "Option A";
            dgtxtBoxOptionA.HeaderText = "Option A";
            dg.Columns.Add(dgtxtBoxOptionA);

            DataGridViewTextBoxColumn dgtxtBoxOptionB = new DataGridViewTextBoxColumn();
            dgtxtBoxOptionB.DataPropertyName = "Option B";
            dgtxtBoxOptionB.HeaderText = "Option B";
            dg.Columns.Add(dgtxtBoxOptionB);

            DataGridViewTextBoxColumn dgtxtBoxOptionC = new DataGridViewTextBoxColumn();
            dgtxtBoxOptionC.DataPropertyName = "Option C";
            dgtxtBoxOptionC.HeaderText = "Option C";
            dg.Columns.Add(dgtxtBoxOptionC);

            DataGridViewTextBoxColumn dgtxtBoxOptionD = new DataGridViewTextBoxColumn();
            dgtxtBoxOptionD.DataPropertyName = "Option D";
            dgtxtBoxOptionD.HeaderText = "Option D";
            dg.Columns.Add(dgtxtBoxOptionD);

            List<String> answerValues = new List<String> { "A" , "B", "C", "D"};
            List<String> diffLevelValues = new List<String> { "Average", "Difficult" };

            DataGridViewComboBoxColumn dgcmbBoxAnswer = new DataGridViewComboBoxColumn();
            dgcmbBoxAnswer.DataPropertyName = "Answer";
            dgcmbBoxAnswer.HeaderText = "Answer";
            dgcmbBoxAnswer.DataSource = answerValues;
            dg.Columns.Add(dgcmbBoxAnswer);

            DataGridViewComboBoxColumn dgcmbBoxDiffLevel = new DataGridViewComboBoxColumn();
            dgcmbBoxDiffLevel.DataPropertyName = "Difficulty Level";
            dgcmbBoxDiffLevel.Name = "Difficulty Level";
            dgcmbBoxDiffLevel.HeaderText = "Difficulty Level";
            dgcmbBoxDiffLevel.DataSource = diffLevelValues;
            dg.Columns.Add(dgcmbBoxDiffLevel);

            DataGridViewTextBoxColumn dgidCol = new DataGridViewTextBoxColumn();
            dgidCol.Visible = false;
            dgidCol.DataPropertyName = "id";
            dgidCol.HeaderText = "id";
            dg.Columns.Add(dgidCol);

            dg.DataSource = dataTable;

            dg.AutoResizeColumns();
            dg.Size = new System.Drawing.Size(800, 400);
            dg.AllowUserToAddRows = false;
            dg.MultiSelect = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            pnlQuestions.Controls.Add(dg);
            enableDisableButtons(list_count);
        }

        private DataTable ConvertToDataTable(List<Question> list)
        {
            dt.Columns.Add("Question");
            dt.Columns.Add("Option A");
            dt.Columns.Add("Option B");
            dt.Columns.Add("Option C");
            dt.Columns.Add("Option D");
            dt.Columns.Add("Answer");
            dt.Columns.Add("Difficulty Level");
            dt.Columns.Add("id");
            if (list != null)
            {
                foreach (var item in list)
                {
                    var row = dt.NewRow();
                    row["Question"] = item.question.ToString();
                    row["Option A"] = item.option_a.ToString();
                    row["Option B"] = item.option_b.ToString();
                    row["Option C"] = item.option_c.ToString();
                    row["Option D"] = item.option_d.ToString();
                    row["Answer"] = item.answer.ToString();
                    row["Difficulty Level"] = item.difficulty_level.ToString();
                    row["id"] = item.question_id;
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dg.SelectedRows[0];
            if (validateFields(row))
            {
                ques = rowData();
                if (ques.msg == "error")
                {
                   MessageBox.Show("Update operation cannot be performed on an empty row");
                   return;
                }
                string msg = ques.updateQuestionJson(ques);
                if (msg == "success")
                {
                   dg = new DataGridView();
                   dt = new DataTable();
                   List<Question> allQuestionsList = ques.getAllQuestionsJson();
                   formDataGrid(allQuestionsList);
                }
            }
        }

        private Question rowData()
        {
            Question question = new Question();
            foreach (DataGridViewRow row in dg.SelectedRows)
            {
                if (row.Cells[7].Value != null)
                {
                    question.question = row.Cells[0].Value.ToString();
                    question.option_a = row.Cells[1].Value.ToString();
                    question.option_b = row.Cells[2].Value.ToString();
                    question.option_c = row.Cells[3].Value.ToString();
                    question.option_d = row.Cells[4].Value.ToString();
                    question.answer = row.Cells[5].Value.ToString();
                    question.difficulty_level = row.Cells[6].Value.ToString();
                    question.question_id = Convert.ToInt32(row.Cells[7].Value);
                } else
                {
                    question.msg = "error";
                    return question;
                }
            }
            return question;
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this question?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DataGridViewRow row = dg.CurrentRow;
                ques = rowData();   
                if (ques.msg == "error")
                {
                    MessageBox.Show("Delete operation cannot be performed on an empty row");
                    return;
                }
                string msg = ques.deleteQuestionJson(ques);
                if (msg == "success")
                {
                    dg.Rows.Remove(row);
                    frmEditQuestions frm = new frmEditQuestions();
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            goToAdminHome();
        }

        private void goToAdminHome()
        {
            //PassingValues.QuestionId = 0;
            frmAdminHome adminHome = new frmAdminHome();
            adminHome.Closed += (s, args) => this.Close();
            adminHome.Show();
            this.Hide();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            String response_msg = "";
            DataGridViewRow row = dg.SelectedRows[0];
            if (validateFields(row))
            {
                Question question = new Question();
                question.question = row.Cells[0].Value.ToString();
                question.option_a = row.Cells[1].Value.ToString();
                question.option_b = row.Cells[2].Value.ToString();
                question.option_c = row.Cells[3].Value.ToString();
                question.option_d = row.Cells[4].Value.ToString();
                question.answer = row.Cells[5].Value.ToString();
                question.difficulty_level = row.Cells[6].Value.ToString();
                response_msg = ques.createQuestionJson(question);
            }
            if (response_msg == "success")
            {
                frmEditQuestions frm = new frmEditQuestions();
                frm.Show();
                this.Hide();
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataRow NewRow = dt.NewRow();
            dt.Rows.Add(NewRow);
            dg.DataSource = dt;
            btnAddQuestion.Enabled = true;
            btnDeleteQuestion.Enabled = false;
            btnEdit.Enabled = false;
        }

        private bool validateFields(DataGridViewRow row)
        {
            if (row.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please enter question");
                return false;
            }
            if (row.Cells[1].Value.ToString() == string.Empty || row.Cells[2].Value.ToString() == string.Empty || row.Cells[3].Value.ToString() == string.Empty || row.Cells[4].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please enter options");
                return false;
            }
            if (row.Cells[5].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select correct answer");
                return false;
            }
            if (row.Cells[6].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select difficulty level");
                return false;
            }

            var allEqual = new[] { row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString() };
            if (allEqual[0] == allEqual[1] || allEqual[1] == allEqual[2] || allEqual[2] == allEqual[3] || allEqual[0] == allEqual[2] || allEqual[0] == allEqual[3] || allEqual[1] == allEqual[3])
            {
                MessageBox.Show("Please select different answer for each option");
                return false;
            }
            return true;
        }

        private void enableDisableButtons(int questions)
        {
            if(questions == (PassingValues.NoOfQuestion * 2))
            {
                btnAddRow.Enabled = false;
                btnDeleteRow.Enabled = false;
            } else
            {
                btnAddRow.Enabled = true;
                btnDeleteRow.Enabled = true;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("curr row index "+dg.CurrentRow.Index+" list count "+list_count);
            if (dg.CurrentRow.Index >= list_count)
            {
                dg.Rows.RemoveAt(dg.CurrentRow.Index);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int avg_count = 0;
            int diff_count = 0;
            int colIndex = dg.Columns["Difficulty Level"].Index;
            foreach (DataGridViewRow row in dg.Rows)
            {
                if (row.Cells[colIndex].Value.ToString() == "Average")
                {
                    avg_count++;
                } else if (row.Cells[colIndex].Value.ToString() == "Difficult")
                {
                    diff_count++;
                }
            }
            if (list_count != PassingValues.NoOfQuestion*2)
            {
                MessageBox.Show("Please add " + PassingValues.NoOfQuestion*2 + " questions for this exam");
                return;
            } else
            {
                if (avg_count != PassingValues.NoOfQuestion)
                {
                    MessageBox.Show("Please ensure that you enter "+PassingValues.NoOfQuestion+" average questions for this exam");
                    return;
                } else if (diff_count != PassingValues.NoOfQuestion)
                {
                    MessageBox.Show("Please ensure that you enter " + PassingValues.NoOfQuestion + " difficult questions for this exam");
                    return;
                } else
                {
                    var confirmResult = MessageBox.Show("Once submitted the exam cannot be edited, are you sure?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        Exam exam = new Exam();
                        exam.status = "Complete";
                        exam.updateExamStatusJson(exam);
                        goToAdminHome();
                    }
                }
            }
        }
    }
}
