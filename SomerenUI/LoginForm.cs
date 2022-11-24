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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            showPanel("Login");
        }

        private void pnl_Login_Paint(object sender, PaintEventArgs e)
        {

        }
        private void showPanel(string panelName)
        {
            try
            {
                if(panelName=="Login")
                {
                    pnl_Login.Show();

                    pnl_registration.Hide();
                }
                else if(panelName == "Cancel")
                {
                    pnl_Login.Show();

                    pnl_registration.Hide();
                }
                else if(panelName=="register")
                {
                    //show
                    pnl_registration.Show();
                    //hide
                    pnl_Login.Hide();

                    //SomerenLogic.Register_Service activityService = new SomerenLogic.Register_Service();
                    //List<Register> rList = activityService.GetRegisters();

                    ////clear listview before filling in the informations
                    //listView1.Clear();

                    ////the informations that needs to be shown
                    //foreach (SomerenModel.Register r in rList)
                    //{
                    //    ListViewItem ListofActivities = new ListViewItem(r.Name.ToString());
                    //    ListofActivities.SubItems.Add((r.Email));
                    //    ListofActivities.SubItems.Add(r.Password);

                    //    listView1.Items.Add(ListofActivities);
                    //}

                    //listView1.GridLines = true;
                    //listView1.FullRowSelect = true;
                    //listView1.View = View.Details;
                    //listView1.Columns.Add("Name", 100, HorizontalAlignment.Left);
                    //listView1.Columns.Add("email", 100, HorizontalAlignment.Left);
                    //listView1.Columns.Add("password", 200, HorizontalAlignment.Left);
                }
            }
            catch
            {

            }
        }
        //login
        // string[] usernames = {  "piet@infhaarlem.nl", "rita @ infhaarlem.nl" };
        //string[] passwords = {  "t78Dx4BfhqfEamxdnAkLCpbC", "qd6VqFfyzF5UgPRDNy9NSCb4" };
        private void Login_Click(object sender, EventArgs e)
        {
            Register_Service adminlog = new Register_Service();
            List<Register> adminList = adminlog.GetRegisters();

            Login_Service loginService = new Login_Service();
            List<LoginData> loginDatas = loginService.GetLoginDatas();

            //stephen added this part for the notification of the admin, since variant a is only done till 80%
            foreach(Register  admin in adminList)
            {
                if(admin.userNumber == 1)
                {
                    foreach (Register user in adminList)
                    {
                        if ((user.Email == UsernameBox.Text && user.Password == PasswordBox.Text) && (user.userNumber == (int)Status.admin))
                        {
                            this.Hide();
                            SomerenUI s = new SomerenUI();
                            MessageBox.Show("You have some request for administration.", "Notification");
                            //string accounts = "";
                            //foreach (Register request in adminList)
                            //{
                            //    if (request.userNumber == (int)Status.request)
                            //    {
                            //        accounts +=request.Name;
                            //    }
                            //}
                            //MessageBox.Show(accounts,"you got mail");
                            s.ShowDialog();
                        }

                    }
                }
                else if((admin.userNumber== 2) || (admin.userNumber == 3))
                {
                    //tudors part for a logins for assignment A
                    foreach (var lg in loginDatas)
                    {
                        if (lg.Username == UsernameBox.Text && lg.Password == PasswordBox.Text)
                        {
                            this.Hide();
                            SomerenUI s = new SomerenUI();
                            //MessageBox.Show("error");
                            s.ShowDialog();
                        }

                    }
                    //tudors part for a logins
                }
            }
            //stephen's just to get the notification for the admin.
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            showPanel("register");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string licenseKey1 = "XsZAb";
            string licenseKey2 = "tgz3PsD";
            string licenseKey3 = "qYh69un";
            string licenseKey4 = "WQCEx";
            //txtBn_name.Text = txtBn_1stkey.Text;//a checker

            if ((txtBn_1stkey.Text == licenseKey1) && (txtBn_2ndkey.Text == licenseKey2) && (txtBn_3rdkey.Text == licenseKey3) && (txtBn_4thkey.Text == licenseKey4))
            {
                if((txtBn_name.Text=="") ||(txtBn_Email.Text=="")||(txtBn_Password.Text=="")||(txtBn_RePassword.Text==""))
                {
                    MessageBox.Show("One or more of the fields is empty");
                }
                else if (txtBn_Password.Text != txtBn_RePassword.Text)
                {
                    MessageBox.Show("Error: please retype password");
                }
                //else if(txtBn_Email.Text!="@")//need to fix this
                //{
                //    MessageBox.Show("Invalid email");
                //}
                else if(txtBn_Password.Text == txtBn_RePassword.Text)
                {
                    SomerenLogic.Register_Service AddPerson = new SomerenLogic.Register_Service();
                    //AddPerson.AddUser(txtBn_name.Text, txtBn_Email.Text, txtBn_Password.Text);
                    DialogResult request = MessageBox.Show("Would you like to request for administration status from the admin, if not, you'll be registered as user? ","",MessageBoxButtons.YesNo);
                    if (request == DialogResult.Yes)
                    {
                        //something about the request
                        AddPerson.AddUser(txtBn_name.Text, txtBn_Email.Text, txtBn_Password.Text,Status.request);
                    }
                    else
                    {
                        //this will be with the no request of admin level
                        AddPerson.AddUser(txtBn_name.Text, txtBn_Email.Text, txtBn_Password.Text, Status.user);
                    }
                    txtBn_name.Text = "";
                    txtBn_Email.Text = "";
                    txtBn_Password.Text = "";
                    txtBn_RePassword.Text = "";
                    //clean the code
                    txtBn_1stkey.Text = "";
                    txtBn_2ndkey.Text = "";
                    txtBn_3rdkey.Text = "";
                    txtBn_4thkey.Text = "";

                }
            }
            else if((txtBn_1stkey.ToString()!= licenseKey1) || (txtBn_2ndkey.ToString()!= licenseKey2) || (txtBn_3rdkey.ToString() != licenseKey3) || (txtBn_4thkey.ToString()!= licenseKey4))
            {
                MessageBox.Show("License key is invalid");
            }

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            showPanel("Cancel");//the button to return to the main page.
        }

        private void button_Forgot_Click(object sender, EventArgs e)
        {
            //Forgot password window form (recover.cs)
            var myForm = new Recover();
            myForm.Show();

        }
    }
}
