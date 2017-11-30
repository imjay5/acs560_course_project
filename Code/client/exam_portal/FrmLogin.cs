using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace exam_portal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Client c = new Client();
        User user = new User();
        UTF8Encoding utf8 = new UTF8Encoding();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == string.Empty)
            {
                MessageBox.Show("Username can't be empty");
                return;
            }
            if (txtBoxPwd.Text == string.Empty)
            {
                MessageBox.Show("Password can't be empty");
                return;
            }

            string ans = JsonConvert.SerializeObject(user, Formatting.Indented);
            string response = c.send_data(ans, "login");
            User res = JsonConvert.DeserializeObject<User>(response);
            PassingValues.name = res.name;
            PassingValues.userID = res.user_id;
            
            String decodedPwd = utf8.GetString(res.password);
            
            if (txtBoxPwd.Text == decodedPwd)
            {
                if (res.admin_key.Equals(true) && (!(res.user_id == 0)))
                {
                    frmAdminHome adminHome = new frmAdminHome();
                    this.Hide();
                    adminHome.Show();
                }

                else if (res.admin_key.Equals(false) && (!(res.user_id == 0)))
                {
                    frmUserHome userHome = new frmUserHome();
                    this.Hide();
                    userHome.Show();
                }

                else
                {
                    MessageBox.Show("No details found. Please register");
                    return;
                }

            } else
            {
                MessageBox.Show("Invalid Credentials");
                return;
            }    
           
        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {
            user.email = txtBoxUserName.Text;
         }

        private void txtBoxPwd_TextChanged(object sender, EventArgs e)
        {
            txtBoxPwd.PasswordChar = '*';           
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            this.Hide();
            registerForm.Show();
        }

        public void AddExitButtons()
        {
            //MessageBox.Show("Trail");
            foreach (Form frm in Application.OpenForms)
            {
                //MessageBox.Show("Trail2");
                Button btn = new Button();
                btn.BackColor = Color.Black;
                btn.Name = "exitBtn";
                btn.Text = "Logout";
                btn.Size = new Size(115, 30);
                btn.Location = new Point(588, 183);
                btn.Click += new EventHandler(this.exitBtn_Click);
                frm.Controls.Add(btn);
            }
            //MessageBox.Show("Trail3");
        }

        public void exitBtn_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
