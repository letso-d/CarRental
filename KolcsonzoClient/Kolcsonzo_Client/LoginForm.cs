using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kolcsonzo_Client
{
    public partial class LoginForm : Form
    {
        public LoginForm(Kolcsonzo.Kolcsonzo.KolcsonzoClient client)
        {
            this.client = client;
            InitializeComponent();
            ResetUsername();
            ResetPw();
        }

        Kolcsonzo.Kolcsonzo.KolcsonzoClient client;
        private void usernameBox_Click(object sender, EventArgs e)
        {
            ClearUsername();
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text.Length<1)
            {
                ResetUsername();
            }
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            ClearPw();
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length<1)
            {
                ResetPw();
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            ClearPw();
        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {
            ClearUsername();
        }

        private void ClearPw()
        {
            passwordBox.PasswordChar = '*';
            passwordBox.Text = "";
        }

        private void ClearUsername()
        {
            usernameBox.Text = "";
        }

        private void ResetPw()
        {
            passwordBox.PasswordChar = (char)0;
            passwordBox.Text = "password";
        }

        private void ResetUsername()
        {
            usernameBox.Text = "username";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text.Length > 3 && passwordBox.Text.Length > 3)
            {
                var response = client.Login(new Kolcsonzo.LoginData { Username = usernameBox.Text, Passwd = passwordBox.Text });
                if (response.Success == "You have successfully logged in.")
                {
                    if (response.Level == 2)
                    {
                        Form1.IsAdmin = true;
                    }
                    Form1.LoggedIn = true;
                    Form1.Uid = response.Uid;
                    MessageBox.Show(response.Success);
                    this.Close();
                }
                else
                {
                    ResetPw();
                    ResetUsername();
                    Form1.LoggedIn = false;
                    Form1.Uid = "";
                    MessageBox.Show(response.Success);
                }
            }
            else
            {
                ResetPw();
                ResetUsername();
                MessageBox.Show("You have to type your username and your password to perform this action!");
            }
        }
    }
}
