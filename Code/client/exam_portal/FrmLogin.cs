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
            //MessageBox.Show(ans);
            //MessageBox.Show(response);
            ResponseJSON res = JsonConvert.DeserializeObject<ResponseJSON>(response);
            

            if (txtBoxUserName.Text.Equals(user.email) && txtBoxPwd.Text.Equals(user.password))
            {
                if(res.admin_key.Equals(true) && (!(res.user_id == 0)))
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

            }
           
        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {
            user.email = txtBoxUserName.Text;
         }

        private void txtBoxPwd_TextChanged(object sender, EventArgs e)
        {
            txtBoxPwd.PasswordChar = '*';
            user.password = txtBoxPwd.Text;
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            this.Hide();
            registerForm.Show();
        }
    }

    public class User
    {
        public string email;
        public string password;
    }

    public class ResponseJSON
    {
        public string msg;
        public int user_id;
        public bool admin_key;
    }
}
