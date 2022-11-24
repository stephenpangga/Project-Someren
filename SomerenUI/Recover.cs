using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SomerenUI
{
    public partial class Recover : Form
    {
        //Mohaymen's Part
        public Recover()
        {
            //Is used to hide the labels and textboxes when the form is opened
            InitializeComponent();
            label_Secret.Hide();
            textBox_Answer.Hide();
            label_newPassword.Hide();
            textBox_new.Hide();
            button_answer.Hide();
            button_Update.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        //button for entering username
        private void button1_enter_Click(object sender, EventArgs e)
        {
            //if textbox is empty show message box
            if (textBox_username.Text == "")
            {
                MessageBox.Show("Please enter your username correctly");
            }
            else
            {
                Login_Service loginService = new Login_Service();
                List<LoginData> loginDatas = loginService.GetLoginDatas();

                LoginData thisUser = new LoginData();
                bool exists = false;


                foreach (LoginData lg in loginDatas)
                {
                    //If condition used to check whether textbox username is = to the database username
                    if (textBox_username.Text == lg.Username)
                    {
                        exists = true;
                        thisUser = lg;
                    }


                }

                if (exists)
                {
                    label_Secret.Text = thisUser.SecretQs;
                    label_Secret.Show();
                    textBox_Answer.Show();
                    button_answer.Show();
                }
                //IF not then show that it is not in the system
                else
                {
                    MessageBox.Show("Sorry, your username does not exist in our system");
                }
            }

        }

        //button for entering answer for secret question
        private void button_answer_Click(object sender, EventArgs e)
        {
            //if textbox is empty show message box
            if (textBox_Answer.Text == "")
            {
                MessageBox.Show("Please enter correct answer");
            }
            else
            {
                Login_Service loginService = new Login_Service();
                List<LoginData> loginDatas = loginService.GetLoginDatas();


                foreach (var lg in loginDatas)
                {
                    //If condition used to check whether textbox answer is = to the database answer
                    if (textBox_Answer.Text == lg.SecretAs)
                    {
                        label_newPassword.Show();
                        textBox_new.Show();
                        button_Update.Show();
                        break;
                    }
                    //if not show message box incorrect
                    else
                    {
                        MessageBox.Show("Incorrect answer");
                        break;
                    }

                }
            }

        }

        //password update button
        private void button_Update_Click(object sender, EventArgs e)
        {
            //if textbox is empty show message box
            if (textBox_new.Text == "")
            {
                MessageBox.Show("Please enter new Password");
            }
            else
            {
                Login_Service loginService = new Login_Service();
                List<LoginData> loginDatas = loginService.GetLoginDatas();

                //loop for password conditions 
                foreach (char c in textBox_new.Text)
                {

                    //password should be at least 8 characters
                    if (textBox_new.Text.Length < 8)
                    {
                        MessageBox.Show("Password should be at least 8 characters");
                        break;
                    }

                    //password should have at least 1 uppercase character
                    if (!textBox_new.Text.Any(char.IsUpper))
                    {
                        MessageBox.Show("Password should have at least 1 uppercase character");
                        break;
                    }

                    //password should have at least 1 lowercase character
                    if (!textBox_new.Text.Any(char.IsLower))
                    {
                        MessageBox.Show("Password should have at least 1 lowercase character");
                        break;
                    }

                    //password should have at least 1 digit
                    if (!textBox_new.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Password should have at least 1 digit");
                        break;
                    }

                    ////password should have at least 1 punctuation character
                    if (!textBox_new.Text.Any(char.IsPunctuation))
                    {
                        MessageBox.Show("Password should have at least 1 punctuation character");
                        break;
                    }


                }

                //loop used for updating password to the database on click
                foreach (var lg in loginDatas)
                {
                    SomerenLogic.Login_Service login_db = new Login_Service();
                    button_Update.Show();
                    login_db.UpdatePassword(textBox_username.Text, textBox_new.Text);

                }
            }
        }
    }
}
