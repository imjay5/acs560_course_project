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
            int score = GradeScore.averageCount * 2 + GradeScore.difficultCount * 4;
            txtBoxScore.Text = score.ToString();
            
        }
    }
}
