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
    public partial class frmStartExam : Form
    {
        public frmStartExam()
        {
            InitializeComponent();
            textBox1.Text = (PassingQuesList.quesList.Count/2).ToString();
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            frmTakeExam takeExam = new frmTakeExam();
            this.Hide();
            takeExam.Show();
        }

        
    }
}
