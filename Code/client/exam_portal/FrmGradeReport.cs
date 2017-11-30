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
    public partial class frmGradeReport : Form
    {
        public frmGradeReport()
        {
            InitializeComponent();

            lblGrade.Text = PassingValues.grade;

            if(lblGrade.Text == "D" || lblGrade.Text == "C")
            {
                lblMsg.Text = "Study hard..!!";
            }

        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            frmUserHome frm = new frmUserHome();
            this.Hide();
            frm.Show();
        }
    }
    
}
