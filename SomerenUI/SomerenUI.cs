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
    public partial class SomerenUI : Form
    {
        int ID = 0;
        int selectedrow;
        int Supervisor_ID = 0;

        public Register userlog = new Register();


        //checker of the activity already exist
        List<Activity> checker = new List<Activity>();

        //public static object loggedInUser { get; private set; }

        //checker.Add()
        public SomerenUI()
        {
            //stephen added this part to show the request.
            //this is the general list
            //SomerenLogic.Register_Service userAcc = new SomerenLogic.Register_Service();
            //List<Register> rList = userAcc.GetRegisters();

            //string accounts = "";
            //Register admins = new Register();
            ////if(rList.userNumber ==)

            //foreach (Register users in rList)
            //{
            //    if (users.userNumber == (int)Status.request)
            //    {
            //        accounts += users.Name;
            //    }
            //}
            //MessageBox.Show(accounts, "requesting for admin level of authorization");

            //LoginForm l = new LoginForm();
            //l.Close();

            InitializeComponent();

        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {    
            showPanel("Dashboard");            
        }

        private void showPanel(string panelName)
        {
            try
            {
                if (panelName == "Dashboard")
                {
                    // hide all other panels
                    pnl_Students.Hide();
                    //thigns i added
                    pnl_Teachers.Hide();
                    pnl_Students.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    pnl_Activities.Hide();
                    panel_TimeTable.Hide();
                    pnl_Supervisors.Hide();



                    //this is for the barservice
                    pnl_BarService.Hide();
                    // show dashboard
                    pnl_Dashboard.Show();
                    img_Dashboard.Show();

                }
                else if (panelName == "Students")
                {
                    // hide all other panels
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    //things i added
                    pnl_Teachers.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    pnl_Activities.Hide();
                    panel_TimeTable.Hide();
                    pnl_Supervisors.Hide();




                    // show students
                    pnl_Students.Show();

                    // fill the students listview within the students panel with a list of students
                    SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                    List<Student> studentList = studService.GetStudents();

                    listViewStudents.Clear();
                    listViewStudents.View = View.Details;
                    listViewStudents.Columns.Add("Student Id", 100, HorizontalAlignment.Left);
                    listViewStudents.Columns.Add("First Name", 100, HorizontalAlignment.Left);
                    listViewStudents.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
                    listViewStudents.Columns.Add("Class", 100, HorizontalAlignment.Left);
                    listViewStudents.Columns.Add("Contact Info", 100, HorizontalAlignment.Left);

                    // clear the listview before filling it again

                    foreach (SomerenModel.Student s in studentList)
                    {
                        ListViewItem li = new ListViewItem(s.Number.ToString());
                        li.SubItems.Add(s.FirstName);
                        li.SubItems.Add(s.LastName);
                        li.SubItems.Add(s.Group);
                        li.SubItems.Add(s.Contact);
                        listViewStudents.Items.Add(li);
                    }

                }
                else if (panelName == "Teachers")
                {

                    // hide all other panels
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    //things that i added -stephen
                    pnl_Students.Hide();
                    pnl_Rooms.Hide();
                    pnl_BarService.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    pnl_Activities.Hide();
                    panel_TimeTable.Hide();
                    pnl_Supervisors.Hide();




                    // show Teachers
                    pnl_Teachers.Show();


                    // fill the teacher listview within the teacher panel with a list of teachers
                    SomerenLogic.Teacher_Service teacherService = new SomerenLogic.Teacher_Service();
                    List<Teacher> teacherList = teacherService.GetTeachers();

                    // clear the listview before filling it again
                    listViewTeachers.Clear();

                    foreach (SomerenModel.Teacher t in teacherList)
                    {
                        ListViewItem ListofT = new ListViewItem(t.Number.ToString());
                        ListofT.SubItems.Add(t.firstName);
                        ListofT.SubItems.Add(t.lastName);
                        ListofT.SubItems.Add(t.supervisor);
                        ListofT.SubItems.Add(t.Department);
                        ListofT.SubItems.Add(t.Contact.ToString());
                        listViewTeachers.Items.Add(ListofT);
                    }

                    // this is for the display
                    listViewTeachers.GridLines = true;
                    listViewTeachers.FullRowSelect = true;
                    listViewTeachers.View = View.Details;
                    listViewTeachers.Columns.Add("Teacher ID", 100, HorizontalAlignment.Left);
                    listViewTeachers.Columns.Add("First Name", 100, HorizontalAlignment.Left);
                    listViewTeachers.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
                    listViewTeachers.Columns.Add("Supervisor", 100, HorizontalAlignment.Left);
                    listViewTeachers.Columns.Add("Department", 100, HorizontalAlignment.Left);
                    listViewTeachers.Columns.Add("Contact info.", 100, HorizontalAlignment.Left);

                }
                else if (panelName == "Rooms")
                {
                    // hide all other panels
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    pnl_Students.Hide();
                    pnl_Teachers.Hide();
                    pnl_BarService.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    pnl_Activities.Hide();
                    panel_TimeTable.Hide();
                    pnl_Supervisors.Hide();




                    //show rooms 
                    pnl_Rooms.Show();


                    //fill the rooms listview within rooms panel with a list of rooms
                    SomerenLogic.Room_Service studService = new SomerenLogic.Room_Service();
                    List<Room> roomList = studService.GetRooms();

                    // clear the listview before filling it again
                    listViewRooms.Clear();
                    listViewRooms.View = View.Details;
                    listViewRooms.Columns.Add("Room Id", 100, HorizontalAlignment.Left);
                    listViewRooms.Columns.Add("TypeOfRoom", 100, HorizontalAlignment.Left);
                    listViewRooms.Columns.Add("Taken/Not-Taken", 100, HorizontalAlignment.Left);
                    listViewRooms.Columns.Add("Size", 100, HorizontalAlignment.Left);



                    foreach (SomerenModel.Room r in roomList)
                    {

                        ListViewItem li = new ListViewItem(r.Room_Id.ToString());
                        li.SubItems.Add(r.Type);
                        li.SubItems.Add(r.Occupied);
                        li.SubItems.Add(r.Size.ToString());

                        listViewRooms.Items.Add(li);
                    }
                }
                else if (panelName == "Cash Register")
                {
                    pnl_Dashboard.Hide();
                    pnl_Students.Hide();
                    pnl_Teachers.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Show();
                    pnl_Drinks.Hide();
                    panel_TimeTable.Hide();
                    pnl_Supervisors.Hide();



                    SomerenLogic.Cash_Service studService = new SomerenLogic.Cash_Service();
                    //List<CashRegister> drList = studService.GetDrinks();
                    SomerenLogic.Student_Service ss = new SomerenLogic.Student_Service();
                    List<Student> stList = ss.GetStudents();
                    comboBoxStudents.DataSource = stList;
                    comboBoxStudents.DisplayMember = "Name";
                    //checkedListBoxDrinks.DataSource = drList;
                    checkedListBoxDrinks.DisplayMember = "Name";
                }

                else if(panelName =="Bar Service")
                {
                    // hide all other panels
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    pnl_Students.Hide();
                    pnl_Teachers.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    pnl_Activities.Hide();



                    //show the
                    //pnl_BarService.Show();

                }
                else if (panelName == "Drinks")
                {
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    pnl_Students.Hide();
                    pnl_Teachers.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Hide();
                    pnl_BarService.Hide();
                    pnl_Activities.Hide();
                    panel_TimeTable.Hide();
                    pnl_Supervisors.Hide();



                    pnl_Drinks.Show();

                    ShowData();

                }
                else if(panelName == "Sales Report")
                {

                    // hide all other panels
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    pnl_Students.Hide();
                    pnl_Teachers.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    pnl_Activities.Hide();
                    panel_TimeTable.Hide();
                    pnl_Supervisors.Hide();



                    StartCalendar.MaxDate = DateTime.Today;//this is for the calendar to only show the dates til today.
                    

                    //show the
                    pnl_BarService.Show();

                    //this is to show all the transaction.. with no specific date, just all the current transaction in the
                    //the database.
                    
                    SomerenLogic.Revenue_Service revenueService = new SomerenLogic.Revenue_Service();
                    List<Revenue> revenueList = revenueService.GetRevenue();
                    

                    // clear the listview before filling it again
                    listViewRevenue.Clear();

                    foreach (SomerenModel.Revenue r in revenueList)
                    {
                        ListViewItem ListofRev = new ListViewItem((r.Students).ToString());//(r.Date.ToString("yyyy-dd-MM"));
                        //ListViewItem ListofRev = new ListViewItem((r.Date).ToString("dd-MM-yyyy"));
                        ListofRev.SubItems.Add((r.Price).ToString());
                        ListofRev.SubItems.Add((r.Prod_Sold).ToString());
                        ListofRev.SubItems.Add((r.Date).ToString("dd-MM-yyyy"));
                        ListofRev.SubItems.Add((r.Turnover).ToString());

                        listViewRevenue.Items.Add(ListofRev);
                    }


                    listViewRevenue.GridLines = true;
                    listViewRevenue.FullRowSelect = true;
                    listViewRevenue.View = View.Details;
                    listViewRevenue.Columns.Add("Student", 100, HorizontalAlignment.Left);
                    listViewRevenue.Columns.Add("Price", 100, HorizontalAlignment.Left);
                    listViewRevenue.Columns.Add("Amount product Sold", 120, HorizontalAlignment.Left);
                    listViewRevenue.Columns.Add("Date", 100, HorizontalAlignment.Left);
                    listViewRevenue.Columns.Add("Turnover", 100, HorizontalAlignment.Left);

                    //clear the list after for the display when the date is selecteds

                
                    lblmsg.Text = "General overview of transaction";
                    lblStart.Text = "";
                    lblEnd.Text = "";
                }
                else if (panelName=="Activities")
                {
                    //hide

                    // hide all other panels
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    pnl_Students.Hide();
                    pnl_Teachers.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    panel_TimeTable.Hide();
                    pnl_Supervisors.Hide();


                    //show
                    pnl_Activities.Show();

                    SomerenLogic.Activities_Service activityService = new SomerenLogic.Activities_Service();
                    List<Activity> activityList = activityService.GetActivity();

                    //clear listview before filling in the informations
                    listViewActivity.Clear();

                    //the informations that needs to be shown
                    foreach(SomerenModel.Activity a in activityList)
                    {
                        ListViewItem ListofActivities = new ListViewItem(a.ID.ToString());
                        ListofActivities.SubItems.Add((a.Description));
                        ListofActivities.SubItems.Add(a.numbOfStudent.ToString());
                        ListofActivities.SubItems.Add(a.numbOfTeacher.ToString());
                        ListofActivities.Tag = a;

                        listViewActivity.Items.Add(ListofActivities);
                    }

                    listViewActivity.GridLines = true;
                    listViewActivity.FullRowSelect = true;
                    listViewActivity.View = View.Details;
                    listViewActivity.Columns.Add("Activity ID", 100, HorizontalAlignment.Left);
                    listViewActivity.Columns.Add("Description", 100, HorizontalAlignment.Left);
                    listViewActivity.Columns.Add("Number Of Students", 100, HorizontalAlignment.Left);
                    listViewActivity.Columns.Add("Number Of Supervisors", 100, HorizontalAlignment.Left);

                }
                else if (panelName == "Supervisors")
                {
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    pnl_Students.Hide();
                    pnl_Teachers.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    pnl_BarService.Hide();
                    pnl_Activities.Hide();
                    panel_TimeTable.Hide();


                    pnl_Supervisors.Show();

                    //displaying datagridview in another method
                    DisplayDataSup();

                    //to get all the info from teacher's table
                    SomerenLogic.Teacher_Service teacherdb = new SomerenLogic.Teacher_Service();
                    List<Teacher> TeacherList = teacherdb.GetTeachers();

                    combo_Teacher.DataSource = TeacherList;
                    //only displaying the first name in the combo box
                    combo_Teacher.DisplayMember = "FirstName";



                }
                //time table
                else if(panelName == "Time Table")
                {
                    pnl_Dashboard.Hide();
                    img_Dashboard.Hide();
                    pnl_Students.Hide();
                    pnl_Teachers.Hide();
                    pnl_Rooms.Hide();
                    pnl_Sales.Hide();
                    pnl_Drinks.Hide();
                    pnl_Activities.Hide();
                    pnl_BarService.Hide();
                    pnl_Activities.Hide();
                    pnl_Supervisors.Hide();

                    //to show
                    panel_TimeTable.Show();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                StreamWriter writer = new StreamWriter($"errorLog.txt",true);
                writer.WriteLine($"{ DateTime.Now}, error message:  {e.Message}");
                writer.Close();
            }           

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }
               
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void lbl_Rooms_Click(object sender, EventArgs e)
        {

        }

        private void barServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showPanel("Bar Service");
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Sales Report");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //DateTime startD = StartCalendar.SelectionStart;
            //DateTime endD = StartCalendar.SelectionEnd;
            //StartCalendar.SelectionRange = new SelectionRange(startD, endD);

            /*
            if(lblStart.Text =="")
            {
                StartCalendar.MinDate = StartCalendar.SelectionStart;
                lblStart.Text = StartCalendar.SelectionStart.ToString("dd-MM-yyyy");
            }
            else if(lblEnd.Text == "" && lblEnd.Text != lblStart.Text)
            {
                StartCalendar.MaxDate = StartCalendar.SelectionEnd;
                lblEnd.Text = StartCalendar.SelectionEnd.ToString("dd-MM-yyyy");
            }
            */

            StartCalendar.MaxSelectionCount = 1000000000;// just to make sure its possible to click more than 7 days.
            //StartCalendar.ShowToday = false;
            StartCalendar.ShowTodayCircle = false;

            lblStart.Text = StartCalendar.SelectionStart.ToString("dd-MM-yyyy");
            lblEnd.Text = StartCalendar.SelectionEnd.ToString("dd-MM-yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //the message above the listview
                lblmsg.Text = "Transaction of the date selected..";
                //this is for the buttons
                SomerenLogic.Revenue_Service revenueService = new SomerenLogic.Revenue_Service();
                //List<Revenue> rList = revenueService.GetRevenue();

                //this is when the list is clicked.
                List<Revenue> rDate = revenueService.GetDate(StartCalendar.SelectionStart, StartCalendar.SelectionEnd);

                //to clear the list.
                listViewRevenue.Clear();

                //the display when a date is selected.

                foreach (SomerenModel.Revenue r in rDate)
                {
                    ListViewItem ListofRev = new ListViewItem((r.Students).ToString());
                    ListofRev.SubItems.Add((r.Price).ToString());
                    ListofRev.SubItems.Add((r.Prod_Sold).ToString());
                    ListofRev.SubItems.Add((r.Date).ToString("dd-MM-yyyy"));
                    ListofRev.SubItems.Add((r.Turnover).ToString());

                    listViewRevenue.Items.Add(ListofRev);
                }
                listViewRevenue.GridLines = true;
                listViewRevenue.FullRowSelect = true;
                listViewRevenue.View = View.Details;
                listViewRevenue.Columns.Add("Student", 100, HorizontalAlignment.Left);
                listViewRevenue.Columns.Add("Price", 100, HorizontalAlignment.Left);
                listViewRevenue.Columns.Add("Amount product Sold", 120, HorizontalAlignment.Left);
                listViewRevenue.Columns.Add("Date", 100, HorizontalAlignment.Left);
                listViewRevenue.Columns.Add("Turnover", 100, HorizontalAlignment.Left);

                //this part for the calculations of  sales, turnover and number of customer.
            
            
                int sales = 0;
                int turnover = 0;

                foreach (Revenue r in rDate)
                {
                    //if (r.Date >= StartCalendar.SelectionStart && r.Date <= StartCalendar.SelectionEnd)
                    //{
                    turnover += r.Turnover;
                    sales = r.Prod_Sold + sales;

                    //}                
                }
                txt_Sales.Text = sales.ToString();
                txt_Turnover.Text = turnover.ToString();

                //amount of student counter.
                txt_TotalCust.Text = Revenue.NumbOfStudent.ToString();
                Revenue.NumbOfStudent = 0;
            }
            catch(Exception d)
            {
                MessageBox.Show(d.Message);
                StreamWriter writer = new StreamWriter($"errorLog.txt", true);
                writer.WriteLine($"{ DateTime.Now}, error message:  {d.Message}");
                writer.Close();
            }
            
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            string student = "";
            student = comboBoxStudents.Text;

            List<string> drink = new List<string>();

            foreach (var item in checkedListBoxDrinks.CheckedItems.OfType<CashRegister>())
            {
                if (item.Stock < 1)
                {
                    MessageBox.Show("Sorry!! Not Enough Stock of " + item.Name + "!!");
                    continue;
                }

                drink.Add(item.Name);
            }
            if (drink == null && drink.Count == 0)
            {
                // there is no drink in the list to buy
                MessageBox.Show("Nothing to buy!!");
                return;
            }


            if (student != "" && drink[0] != "")
            {
                SomerenLogic.Cash_Service studService = new SomerenLogic.Cash_Service();
                studService.InsertCashBill(student, drink);
                comboBoxStudents.ResetText();
                foreach (int i in checkedListBoxDrinks.CheckedIndices)
                {
                    checkedListBoxDrinks.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            else
            {
                MessageBox.Show("Please Enter all values");
            }
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Cash Register");
        }
        private void ShowData()
        {
            //used a datagridview since it was an easier way to display the data, also watched a few youtube videos where they showed it in a datagrid view. 
            SomerenLogic.Drinks_Service drinks_db = new SomerenLogic.Drinks_Service();
            List<Drinks> drinkList = drinks_db.GetDrinks();
            dataGridViewDrinks.AutoGenerateColumns = true;
            dataGridViewDrinks.DataSource = drinkList;

        }
        private void ClearData()
        {
            textBox_Name.Text = "";
            textBox_Price.Text = "";
            textBox_Stock.Text = "";
            ID = 0;

        }
        private void button_Insert_Click(object sender, EventArgs e)
        {
            if ((textBox_Name.Text != "") && (textBox_Price.Text != "") && (textBox_Stock.Text != ""))
            {
                Decimal VAT = 0;
                if (radioButton_No.Checked)
                {
                    SomerenLogic.Drinks_Service drink_Db = new SomerenLogic.Drinks_Service();


                    drink_Db.AddDrinks(textBox_Name.Text, Convert.ToInt32(textBox_Price.Text), Convert.ToInt32(textBox_Stock.Text), radioButton_No.Text, VAT);
                    ShowData();
                    ClearData();
                }
                else
                {
                    SomerenLogic.Drinks_Service drink_Db = new SomerenLogic.Drinks_Service();
                    drink_Db.AddDrinks(textBox_Name.Text, Convert.ToInt32(textBox_Price.Text), Convert.ToInt32(textBox_Stock.Text), radioButton_Yes.Text, VAT);
                    ShowData();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Field(s) Empty");
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if ((textBox_Name.Text != "") && (textBox_Price.Text != "") && (textBox_Stock.Text != ""))
            {
                Decimal VAT = 0;
                if (radioButton_No.Checked)
                {
                    SomerenLogic.Drinks_Service drink_Db = new SomerenLogic.Drinks_Service();
                    drink_Db.UpdateDrinks(ID, textBox_Name.Text, Convert.ToInt32(textBox_Price.Text), Convert.ToInt32(textBox_Stock.Text), radioButton_No.Text, VAT);
                    ShowData();
                    ClearData();
                }
                else
                {
                    SomerenLogic.Drinks_Service drink_Db = new SomerenLogic.Drinks_Service();
                    drink_Db.UpdateDrinks(ID, textBox_Name.Text, Convert.ToInt32(textBox_Price.Text), Convert.ToInt32(textBox_Stock.Text), radioButton_Yes.Text, VAT);
                    ShowData();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Select Field to Update");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "" && textBox_Price.Text != "" && textBox_Stock.Text != "")
            {
                SomerenLogic.Drinks_Service studService = new SomerenLogic.Drinks_Service();
                studService.DeleteDrinks(ID);


                ShowData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        private void dataGridViewDrinks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //This method is used to display the information of the datatable onto the textbox for further modification.
            ID = Convert.ToInt32(dataGridViewDrinks.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox_Name.Text = dataGridViewDrinks.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_Price.Text = dataGridViewDrinks.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_Stock.Text = dataGridViewDrinks.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Sales Report");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        //add button for the activity panel.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewActivity.FindItemWithText(txt_ActName.Text);
                if ((txt_ActName.Text == "") || (txt_NumbStud.Text == "") || (txt_NumbSup.Text == ""))//this is for checking all the text back if they have input
                {
                    MessageBox.Show("Please fill in the empty fields..");

                }
                else if (item != null)
                {
                    MessageBox.Show("Do not fill in the same activity, fool!");

                }
                else
                {
                    SomerenLogic.Activities_Service AddAct = new SomerenLogic.Activities_Service();
                    //passing the informations
                    //string NameofActivity = txt_ActName.Text;
                    //int numberStud = int.Parse(txt_NumbStud.Text);
                    //int numberSupervisor = int.Parse(txt_NumbSup.Text);

                    AddAct.AddActivity(txt_ActName.Text, int.Parse(txt_NumbStud.Text), int.Parse(txt_NumbSup.Text));
                    showPanel("Activities");//to refresh the list.
                                            //after clicking the button clean the text box.
                    txt_ActName.ResetText();
                    txt_NumbStud.ResetText();
                    txt_NumbSup.ResetText();

                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
                StreamWriter writer = new StreamWriter($"errorLog.txt", true);
                writer.WriteLine($"{ DateTime.Now}, error message:  {a.Message}");
                writer.Close();
            }

        }

        //delete the information selected.
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (listViewActivity.SelectedItems.Count == 0)
                return;
            
            SomerenLogic.Activities_Service DeleteAct = new SomerenLogic.Activities_Service();
            Activity toDelete = (Activity)listViewActivity.SelectedItems[0].Tag;
            DialogResult dialogBox = MessageBox.Show("Are you sure, you wish to remove this Activity!!!!", "",MessageBoxButtons.YesNo);// probably need to change this more, but keep it simple right now.

            //this is a joke please give me a higher grade??????
            //DialogResult dialogBox = MessageBox.Show("What do you want to do with this homework??", "", MessageBoxButtons.AbortRetryIgnore);

            if (dialogBox==DialogResult.Yes)
            {
                DeleteAct.DeleteActivity(toDelete.ID);
            }
            //else if(dialogBox == DialogResult.No)//dont really need this as it doesnt do anything.
            //{
            //    //it does nothing.
            //}
            //this has to be last because bae said so.
            showPanel("Activities");//to refresh the list.
                                    //after clicking the button clean the text box.
            txt_ActName.ResetText();
            txt_NumbStud.ResetText();
            txt_NumbSup.ResetText();
        }

        private void btn_UpD_Click(object sender, EventArgs e)
        {
            if (listViewActivity.SelectedItems.Count == 0)
                return;
            Activity activity = (Activity)listViewActivity.SelectedItems[0].Tag;

            SomerenLogic.Activities_Service Update_Activity = new SomerenLogic.Activities_Service();
            if ((txt_ActName.Text != "") && (txt_NumbStud.Text != "") && (txt_NumbSup.Text != ""))
            {

                DialogResult dialogBox = MessageBox.Show("Are you sure, you wish to Update this Activity!!!!", "", MessageBoxButtons.YesNo);
                if (dialogBox == DialogResult.Yes)
                {
                    Update_Activity.UpdateActivity(activity.ID, txt_ActName.Text, int.Parse(txt_NumbStud.Text), int.Parse(txt_NumbSup.Text));
                }
                showPanel("Activities");//to refresh the list.
                                        //after clicking the button clean the text box.
                txt_ActName.ResetText();
                txt_NumbStud.ResetText();
                txt_NumbSup.ResetText();
            }
            else
            {
                MessageBox.Show("Please fill in the empty fields..");

            }

        }

        private void listViewActivity_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ActName.Text = listViewActivity.SelectedItems[0].SubItems[1].Text;
            txt_NumbStud.Text = listViewActivity.SelectedItems[0].SubItems[2].Text;
            txt_NumbSup.Text = listViewActivity.SelectedItems[0].SubItems[3].Text;

        }

        private void timeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Time Table");
        }

        private void Date1_CheckedChanged(object sender, EventArgs e)
        {
            listViewTimeTableActv.Clear();
            listViewTimeTableActv.View = View.Details;
            listViewTimeTableActv.Columns.Add("Activity", 100, HorizontalAlignment.Left);
            listViewTimeTableActv.Columns.Add("Start time", 100, HorizontalAlignment.Left);
            listViewTimeTableActv.Columns.Add("End time", 100, HorizontalAlignment.Left);
            listViewTimeTableSpv.Clear();
            listViewTimeTableSpv.View = View.Details;
            listViewTimeTableSpv.Columns.Add("Supervisor", 100, HorizontalAlignment.Left);
            DateTime d1 = new DateTime(2019, 05, 13);
            //TimeTable_Service timeTable_Service = new TimeTable_Service();
            //Activities_Service activities_Service = new Activities_Service();
            //List<TimeTable> timeTablesList = timeTable_Service.GetTimeTables();
            //List<Activity> activities = activities_Service.GetActivity();
            //List<TimeTable> activities = timeTable_Service.GetTimeTables();
            SomerenLogic.TimeTable_Service time = new SomerenLogic.TimeTable_Service();
            List<TimeTable> TimeList = time.GetTimeTables();
            //SomerenLogic.Activities_Service nameAct = new SomerenLogic.Activities_Service();
            //List<Activity> listnameAct = nameAct.GetActivity();
            foreach (var t in TimeList)
            {
                //foreach(var a in listnameAct)
                {
                    if (t.Date == d1)
                    {
                        ListViewItem li = new ListViewItem(t.Activity.ToString());
                        //li.SubItems.Add(a.Description);
                        li.SubItems.Add(t.StartTime.ToString("hh-mm-yyyy"));
                        li.SubItems.Add(t.EndTime.ToString("hh-mm-yyyy"));
                        listViewTimeTableActv.Items.Add(li);
                    }
                }

            }
        }

        private void panel_TimeTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Date2_CheckedChanged(object sender, EventArgs e)
        {
            listViewTimeTableActv.Clear();
            listViewTimeTableActv.View = View.Details;
            listViewTimeTableActv.Columns.Add("Activity", 100, HorizontalAlignment.Left);
            listViewTimeTableActv.Columns.Add("Start time", 100, HorizontalAlignment.Left);
            listViewTimeTableActv.Columns.Add("End time", 100, HorizontalAlignment.Left);
            listViewTimeTableSpv.Clear();
            listViewTimeTableSpv.View = View.Details;
            listViewTimeTableSpv.Columns.Add("Supervisor", 100, HorizontalAlignment.Left);
            DateTime d2 = new DateTime(2019, 5, 14);

            SomerenLogic.TimeTable_Service time = new SomerenLogic.TimeTable_Service();
            List<TimeTable> TimeList = time.GetTimeTables();
            //SomerenLogic.Activities_Service nameAct = new SomerenLogic.Activities_Service();
            //List<Activity> listnameAct = nameAct.GetActivity();
            foreach (var t in TimeList)
            {
                //foreach(var a in listnameAct)
                {
                    if (t.Date == d2)
                    {
                        ListViewItem li = new ListViewItem(t.Activity.ToString());
                        //li.SubItems.Add(a.Description);
                        li.SubItems.Add(t.StartTime.ToString("hh-mm-yyyy"));
                        li.SubItems.Add(t.EndTime.ToString("hh-mm-yyyy"));
                        listViewTimeTableActv.Items.Add(li);
                    }
                }

            }
            /*
            TimeTable_Service timeTable_Service = new TimeTable_Service();
            Activities_Service activities_Service = new Activities_Service();
            List<TimeTable> timeTablesList = timeTable_Service.GetTimeTables();
            List<Activity> activities = activities_Service.GetActivity();
            //foreach (var a in activities)
            //{
            //   if (a.Date == d2)
            //   {
            //        foreach (var t in timeTablesList)
            //        {
            //            if (t.Activity == a.ID)
            //            {
            //                ListViewItem li = new ListViewItem(a.ID.ToString());
            //                li.SubItems.Add(a.Description);
            //                li.SubItems.Add(a.StartTime.ToString());
            //                li.SubItems.Add(a.EndTime.ToString());
            //                listViewTimeTableActv.Items.Add(li);
            //            }
            //        }
            //    }
            //}
            */
        }

        private void Date3_CheckedChanged(object sender, EventArgs e)
        {
            listViewTimeTableActv.Clear();
            listViewTimeTableActv.View = View.Details;
            listViewTimeTableActv.Columns.Add("No activities!", 100, HorizontalAlignment.Left);
        }

        //supervisor
        private void but_Addsup_Click(object sender, EventArgs e)
        {
            SomerenLogic.Teacher_Service stud = new SomerenLogic.Teacher_Service();
            List<Teacher> stList = stud.GetTeachers();

            // trying to make button work but it doesn't work
            int supervisorid = 0;
            int teacherid = 0;

            SomerenLogic.Supervisors_Service studService = new SomerenLogic.Supervisors_Service();
            studService.Insert_Supervisor_Service(supervisorid, teacherid);

            DisplayDataSup();
            ClearDataSup();

        }

        private void DisplayDataSup()
        {
            // using this method to fill the datagridview
            SomerenLogic.Supervisors_Service studService = new SomerenLogic.Supervisors_Service();
            List<Supervisors> drinkList = studService.GetSupervisors();

            dataGridView_Sup.AutoGenerateColumns = true;
            dataGridView_Sup.DataSource = drinkList;

        }
        private void ClearDataSup()
        {
            //using this method to clear the contents
            textBox_FirstName.Text = "";
            textBox_Lastname.Text = "";
            Supervisor_ID = 0;

        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text != "" && textBox_Lastname.Text != "")
            {
                SomerenLogic.Supervisors_Service studService = new SomerenLogic.Supervisors_Service();
                studService.Delete_Supervisor_Service(Supervisor_ID);


                DisplayDataSup();
                ClearDataSup();
            }
            else
            {
                MessageBox.Show("Please Select field to Delete");
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Supervisors");
        }

        private void Supervisors_Click(object sender, EventArgs e)
        {
            showPanel("Supervisors");
        }

        private void dataGridView_Sup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Sup_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //adding the info to the textbox
            Supervisor_ID = Convert.ToInt32(dataGridView_Sup.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox_FirstName.Text = dataGridView_Sup.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_Lastname.Text = dataGridView_Sup.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void SomerenUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listViewActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }    
}
