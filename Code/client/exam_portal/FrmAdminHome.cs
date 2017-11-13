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
    public partial class frmAdminHome : Form
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            frmCreateExam createExam = new frmCreateExam();
            this.Hide();
            createExam.Show();
        }
    }
}
