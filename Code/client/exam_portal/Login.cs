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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Client c = new Client();
        User user = new User();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ans = JsonConvert.SerializeObject(user, Formatting.Indented);
            string response = c.send_data(ans, "login");
            //MessageBox.Show(ans);
            //MessageBox.Show(response);
            Dummy dummy = JsonConvert.DeserializeObject<Dummy>(response);
            // MessageBox.Show(dummy.ToString());

            if (txtBoxUserName.Text.Equals(user.email) && txtBoxPwd.Text.Equals(user.password))
            {
                if(dummy.admin_key.Equals(true) && dummy.msg.Equals("success"))
                {
                    frmAdminHome adminHome = new frmAdminHome();
                    this.Hide();
                    adminHome.Show();
                }

                //MessageBox.Show("You are logged in successfully");
            }
            else
            {
                MessageBox.Show("Login Error!");
            }
        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {
            user.email = txtBoxUserName.Text;
            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //Match match = regex.Match(txtBoxUserName.Text);
            //if (match.Success)
              //  user.email = txtBoxUserName.Text;
            //else
              //  MessageBox.Show("Not a valid username");
        }

        private void txtBoxPwd_TextChanged(object sender, EventArgs e)
        {
            txtBoxPwd.PasswordChar = '*';
            user.password = txtBoxPwd.Text;
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.Show();
        }
    }

    public class User
    {
        public string email;
        public string password;
    }

    public class Dummy
    {
        public string msg;
        public int user_id;
        public bool admin_key;
    }
}
