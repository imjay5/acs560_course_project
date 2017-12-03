using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace exam_portal
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        User user = new User();
        Client c = new Client();
        Regex regexDigit = new Regex(@"(?=.*\d)");
        Regex regexUpperCase = new Regex(@"(?=.*[A-Z])");
        Regex regexSpecial = new Regex(@"(?=.*\W)");
        Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        UTF8Encoding utf8 = new UTF8Encoding();
        

        private void lblPwd_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            user.name = txtBoxName.Text;
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            user.email = txtBoxEmail.Text;
        }

        private void txtBoxPwd_TextChanged(object sender, EventArgs e)
        {
            txtBoxPwd.PasswordChar = '*';
            //user.password = txtBoxPwd.Text;
            user.password = utf8.GetBytes(txtBoxPwd.Text);
        }

        private void txtBoxRPwd_TextChanged(object sender, EventArgs e)
        {
            txtBoxRPwd.PasswordChar = '*';
        }

       
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text.Equals(""))
            {
                MessageBox.Show("Name field can't be empty");
                return;
            }

            if (txtBoxEmail.Text.Equals(""))
            {
                MessageBox.Show("Email address can't be empty");
                return;                
            }

            if (!(regexEmail.IsMatch(txtBoxEmail.Text)))
            {
                MessageBox.Show("Is not a valid email address");
                return;
            }

            if (txtBoxPwd.Text.Equals("") || txtBoxRPwd.Text.Equals(""))
            {
                MessageBox.Show("Password fields can't be empty");
                return;
            }

            if (!(regexDigit.IsMatch(txtBoxPwd.Text)))
            {
                MessageBox.Show("Password should contain atleast one digit");
                return;
            }

            if (!(regexUpperCase.IsMatch(txtBoxPwd.Text)))
            {
                MessageBox.Show("Password should contain atleast one Uppercase letter");
                return;
            }

            if (!(regexSpecial.IsMatch(txtBoxPwd.Text)))
            {
                MessageBox.Show("Password should contain atleast one Special character");
                return;
            }

            if (txtBoxPwd.Text.Length < 8)
            {
                MessageBox.Show("Password should be min 8 characters long");
                return;
            }

            if (!(txtBoxPwd.Text.Equals(txtBoxRPwd.Text)))
            {
                MessageBox.Show("Password doesn't match");
                return;
            }
            

            string ans = JsonConvert.SerializeObject(user, Formatting.Indented);
            string response = c.send_data(ans, "register");
            //MessageBox.Show(ans);
            //MessageBox.Show(response);
            User res = JsonConvert.DeserializeObject<User>(response);
            //MessageBox.Show(res.msg);
            PassingValues.name = user.name;
            

            if (res.msg.Equals("success"))
            {
                MessageBox.Show("Registration Successful. Login Now..!!");
                frmLogin loginForm = new frmLogin();
                this.Hide();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Already registered! Please login");
            }
            
        }

        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            this.Hide();
            loginForm.Show();
        }
        
    }
    
}
