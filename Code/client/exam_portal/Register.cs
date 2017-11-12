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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        UserDetails user = new UserDetails();
        Client c = new Client();
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

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
            user.password = txtBoxPwd.Text;
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
            }

            if (txtBoxEmail.Text.Equals(""))
            {
                MessageBox.Show("Is not a valid email address");
            }

            if (txtBoxPwd.Text.Equals("") || txtBoxRPwd.Text.Equals(""))
            {
                MessageBox.Show("Password fields can't be empty");
            }            

            string ans = JsonConvert.SerializeObject(user, Formatting.Indented);
            string response = c.send_data(ans, "register");
            MessageBox.Show(ans);
            MessageBox.Show(response);
            Dummy dummy = JsonConvert.DeserializeObject<Dummy>(response);
            MessageBox.Show(dummy.msg);

            if (dummy.msg.Equals("success") && txtBoxPwd.Text.Equals(txtBoxRPwd.Text))
            {
                MessageBox.Show("Registration Successful!");
            }
            else
            {
                MessageBox.Show("Passwords doesn't match");
            }
        }        
    }

    public class UserDetails
    {
        public string name;
        public string email;
        public string password;
    }
    public class Response
    {
        public string msg;
    }

    
}
