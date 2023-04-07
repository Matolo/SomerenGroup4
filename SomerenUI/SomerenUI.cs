using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using SomerenDAL;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }
        private void NewTab(Panel panel, string name)
        {
            foreach (Panel p in new[] { pnlDashboard, pnlStudents, pnlTeachers, pnlActivities, pnlRooms, pnlVat, pnlDrinks, pnlCashRegister, pnlActivitiesParticipants })
            {
                p.Hide();
            }
            panel.Show();

            label1.Show();
            label1.Visible = true;
            label1.AutoSize = true;
            label1.Text = name;
            panel.Controls.Add(label1);

            pictureBox1.Show();
            pictureBox1.Visible = true;
            pictureBox1.AutoSize = true;
            panel.Controls.Add(pictureBox1);
        }


        private void ShowDashboardPanel()
        {
            NewTab(pnlDashboard, "Dashboard");
        }

        private void ShowStudentsPanel()
        {
            NewTab(pnlStudents, "Students");


            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            listViewStudents.View = View.Details;
            listViewStudents.Columns.Add("Student ID");
            listViewStudents.Columns.Add("First Name");
            listViewStudents.Columns.Add("Last Name");
            listViewStudents.Columns.Add("Phone Number");
            listViewStudents.Columns.Add("RoomId");

            foreach (Student student in students)
            {

                ListViewItem item = new ListViewItem(student.StudentId.ToString());
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.PhoneNumber);
                item.SubItems.Add(student.RoomId.ToString());
                item.Tag = student;
                listViewStudents.Items.Add(item);
            }
            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }
        private void ShowActivitiesPanel()
        {
            NewTab(pnlActivities, "Activities");

            try
            {
                // get and display all activities
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }
        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }
        private void DisplayActivities(List<Activity> activities)
        {
            // clear the listview before filling it
            listViewActivities.Clear();

            listViewActivities.View = View.Details;
            listViewActivities.Columns.Add("Activity ID");
            listViewActivities.Columns.Add("Activity Name");
            listViewActivities.Columns.Add("Date");
            listViewActivities.Columns.Add("Begin Time");
            listViewActivities.Columns.Add("End Time");


            foreach (Activity activity in activities)
            {
                ListViewItem item = new ListViewItem(activity.ActivityId.ToString());
                item.SubItems.Add(activity.Type);
                item.SubItems.Add(activity.Date.ToString("yyyy/MM/dd"));
                item.SubItems.Add(activity.time.ToString());
                item.SubItems.Add(activity.EndTime.ToString());
                item.Tag = activity;
                listViewActivities.Items.Add(item);
            }
            // listViewActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void listViewActivities_Click(object sender, EventArgs e)
        {

            Activity selectedItem = listViewActivities.SelectedItems[0].Tag as Activity;

            txtActivityId.Text = selectedItem.ActivityId.ToString();
            txtActivityName.Text = selectedItem.Type.ToString();
            txtDate.Text = selectedItem.Date.ToString();
            txtStartTime.Text = selectedItem.time.ToString();
            txtEndTime.Text = selectedItem.EndTime.ToString();
        }
        private void btnUpdateActivity_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity()
            {
                ActivityId = int.Parse(txtActivityId.Text.ToString()),
                Type = txtActivityName.Text.ToString(),
                Date = DateTime.Parse(txtDate.Text.ToString()),
                time = TimeSpan.Parse(txtStartTime.Text.ToString()),
                EndTime = TimeSpan.Parse(txtEndTime.Text.ToString())
            };
            ActivityService activityService = new ActivityService();
            activityService.UpdateActivity(activity);
            DisplayActivities(activityService.GetActivities());
        }
        private void btnDeleteActivity_Click(object sender, System.EventArgs e)
        {
            ActivityService activityService = new ActivityService();
            if (listViewActivities.SelectedItems.Count > 0)
            {
                Activity selectedItem = listViewActivities.SelectedItems[0].Tag as Activity;
                activityService.DeleteActivity(selectedItem.ActivityId);
                DisplayActivities(activityService.GetActivities());
            }
        }
        // if (selectedItem.TimesSold == 0)
        //    drinkService.DeleteDrink(selectedItem.DrinkId);
        //     DisplayDrinks(drinkService.GetDrinks());     

        private void btnAddActivity_Click(object sender, System.EventArgs e)
        {

            Activity activity = new Activity()
            {
                ActivityId = int.Parse(txtActivityId.Text.ToString()),
                Type = txtActivityName.Text.ToString(),
                Date = DateTime.Parse(txtDate.Text.ToString()),
                time = TimeSpan.Parse(txtStartTime.Text.ToString()),
                EndTime = TimeSpan.Parse(txtEndTime.Text.ToString())
            };

            ActivityService activityService = new ActivityService();
            activityService.AddActivity(activity);
            DisplayActivities(activityService.GetActivities());

        }
        private void ShowTeachersPanel()
        {
            NewTab(pnlTeachers, "Teachers");

            try
            {
                // get and display all teachers
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }
        private List<Teacher> GetTeachers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }
        private void DisplayTeachers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            listViewTeachers.Clear();

            listViewTeachers.View = View.Details;
            listViewTeachers.Columns.Add("Lecturer ID");
            listViewTeachers.Columns.Add("First Name");
            listViewTeachers.Columns.Add("Last Name");
            listViewTeachers.Columns.Add("Phone Number");
            listViewTeachers.Columns.Add("Age");
            listViewTeachers.Columns.Add("Room ID");

            foreach (Teacher teacher in teachers)
            {
                ListViewItem item = new ListViewItem(teacher.TeacherId.ToString());
                item.SubItems.Add(teacher.FirstName);
                item.SubItems.Add(teacher.LastName);
                item.SubItems.Add(teacher.PhoneNumber.ToString());
                item.SubItems.Add(teacher.Age.ToString());
                item.SubItems.Add(teacher.RoomId.ToString());
                item.Tag = teacher;
                listViewTeachers.Items.Add(item);
            }
            //listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }
        private void ShowRoomsPanel()
        {
            NewTab(pnlRooms, "Rooms");

            try
            {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }
        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }
        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Clear();

            listViewRooms.View = View.Details;
            listViewRooms.Columns.Add("Room ID");
            listViewRooms.Columns.Add("Building");
            listViewRooms.Columns.Add("Type");
            listViewRooms.Columns.Add("Number of Beds");

            foreach (Room room in rooms)
            {
                ListViewItem item = new ListViewItem(room.RoomId.ToString());
                item.SubItems.Add(room.Building);
                item.SubItems.Add(room.Type);
                item.SubItems.Add(room.BedsNumber.ToString());
                item.Tag = room;
                listViewRooms.Items.Add(item);
            }
            // listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void ShowVatPanel()
        {
            NewTab(pnlVat, "VAT");

            CashRegisterService cashRegisterService = new CashRegisterService();
            cbSelectYear.DataSource = cashRegisterService.GetYears();

        }

        private void vatCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVatPanel();
        }

        private void ShowDrinksPanel()
        {
            NewTab(pnlDrinks, "Drinks");

            try
            {
                // get and display all rooms
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }
        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }
        private void DisplayDrinks(List<Drink> drinks)
        {


            // clear the listview before filling it
            listViewDrinks.Clear();

            listViewDrinks.View = View.Details;
            listViewDrinks.Columns.Add("Drink ID");
            listViewDrinks.Columns.Add("Drink Name");
            listViewDrinks.Columns.Add("Price");
            listViewDrinks.Columns.Add("Is Alcoholic");
            listViewDrinks.Columns.Add("Stock");
            listViewDrinks.Columns.Add("Times Sold");

            foreach (Drink drink in drinks)
            {
                ListViewItem item = new ListViewItem(drink.DrinkId.ToString());
                item.SubItems.Add(drink.DrinkName);
                item.SubItems.Add(drink.Price.ToString());
                if (drink.IsAlcoholic)
                    item.SubItems.Add("Yes");
                else
                    item.SubItems.Add("No");
                if (drink.Stock < 10)
                    item.SubItems.Add($"{drink.Stock} - Stock nearly depleted");
                else
                    item.SubItems.Add($"{drink.Stock} - Stock sufficient");
                item.SubItems.Add(drink.TimesSold.ToString());
                item.Tag = drink;
                listViewDrinks.Items.Add(item);
            }
            // listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void drinksSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }
        private void BtnAddDrink_Click(object sender, System.EventArgs e)
        {
            bool isAlc;

            if (tbIsAlcohol.Text.ToString() == "1" || tbIsAlcohol.Text.ToString().ToLower() == "true")
                isAlc = true;
            else
                isAlc = false;

            Drink drink = new Drink()
            {
                DrinkId = int.Parse(tbDrinkId.Text.ToString()),
                DrinkName = tbDrinkName.Text.ToString(),
                Price = float.Parse(tbPrice.Text.ToString()),
                IsAlcoholic = isAlc,
                Stock = int.Parse(tbStock.Text.ToString()),
                TimesSold = 0
            };

            DrinkService drinkService = new DrinkService();
            drinkService.AddDrink(drink);
            DisplayDrinks(drinkService.GetDrinks());

        }
        private void BtnDeleteDrink_Click(object sender, System.EventArgs e)
        {
            DrinkService drinkService = new DrinkService();

            if (listViewDrinks.SelectedItems.Count > 0)
            {
                Drink selectedItem = listViewDrinks.SelectedItems[0].Tag as Drink;

                if (selectedItem.TimesSold == 0)
                {
                    drinkService.DeleteDrink(selectedItem.DrinkId);
                    DisplayDrinks(drinkService.GetDrinks());
                }
            }
        }
        private void listViewDrinks_Click(object sender, EventArgs e)
        {

            Drink selectedItem = listViewDrinks.SelectedItems[0].Tag as Drink;

            tbDrinkId.Text = selectedItem.DrinkId.ToString();
            tbDrinkName.Text = selectedItem.DrinkName.ToString();
            tbPrice.Text = selectedItem.Price.ToString();
            tbIsAlcohol.Text = selectedItem.IsAlcoholic.ToString();
            tbStock.Text = selectedItem.Stock.ToString();


        }
        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            bool isAlc;

            if (tbIsAlcohol.Text.ToString() == "1" || tbIsAlcohol.Text.ToString().ToLower() == "true")
                isAlc = true;
            else
                isAlc = false;

            Drink drink = new Drink()
            {
                DrinkId = int.Parse(tbDrinkId.Text.ToString()),
                DrinkName = tbDrinkName.Text.ToString(),
                Price = double.Parse(tbPrice.Text.ToString()),
                IsAlcoholic = isAlc,
                Stock = int.Parse(tbStock.Text.ToString()),
                TimesSold = 0
            };

            DrinkService drinkService = new DrinkService();
            drinkService.UpdateDrink(drink);
            DisplayDrinks(drinkService.GetDrinks());
        }

        public void ShowCashRegisterPanel()
        {
            NewTab(pnlCashRegister, "Cash Register");

            try
            {
                //get and display all students and drinks
                List<Student> students = GetStudents();
                List<Drink> drinks = GetDrinks();
                DisplaySimpleStudents(students);
                DisplaySimpleDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the cash register: " + e.Message);
            }
        }

        private void DisplaySimpleStudents(List<Student> students)
        {


            // clear the listview before filling it
            listViewStudentSimple.Clear();

            listViewStudentSimple.View = View.Details;
            listViewStudentSimple.Columns.Add("Student ID");
            listViewStudentSimple.Columns.Add("Last Name");

            foreach (Student student in students)
            {

                ListViewItem item = new ListViewItem(student.StudentId.ToString());
                item.SubItems.Add(student.LastName);

                item.Tag = student;
                listViewStudentSimple.Items.Add(item);
            }
            //listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewStudentSimple.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void DisplaySimpleDrinks(List<Drink> drinks)
        {

            listViewDrinksSimple.Clear();

            listViewDrinksSimple.View = View.Details;
            listViewDrinksSimple.Columns.Add("Drink ID");
            listViewDrinksSimple.Columns.Add("Drink Name");
            listViewDrinksSimple.Columns.Add("Price");
            listViewDrinksSimple.Columns.Add("Is Alcoholic");
            listViewDrinksSimple.Columns.Add("Stock");

            foreach (Drink drink in drinks)
            {
                ListViewItem item = new ListViewItem(drink.DrinkId.ToString());
                item.SubItems.Add(drink.DrinkName);
                item.SubItems.Add(drink.Price.ToString());
                if (drink.IsAlcoholic)
                    item.SubItems.Add("Yes");
                else
                    item.SubItems.Add("No");
                item.SubItems.Add(drink.Stock.ToString());
                item.SubItems.Add(drink.TimesSold.ToString());
                item.Tag = drink;
                listViewDrinksSimple.Items.Add(item);
            }
            // listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDrinksSimple.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCashRegisterPanel();
        }
        private void BtnCheckOut_Click(object sender, System.EventArgs e)
        {
            CashRegisterService cashRegisterService = new CashRegisterService();

            DateTime time = DateTime.Now;

            Student selectedStudent = listViewStudentSimple.SelectedItems[0].Tag as Student;
            Drink selectedDrink = selectedDrink = listViewDrinksSimple.SelectedItems[0].Tag as Drink;

            cashRegisterService.RegisterCheckOut(selectedStudent, selectedDrink, time);
            ShowCashRegisterPanel();

        }
        private void ListViewDrinksSimple_Click(object sender, System.EventArgs e)
        {
            Student selectedStudent;
            Drink selectedDrink;
            if (listViewDrinksSimple.SelectedItems.Count >= 1 && listViewStudentSimple.SelectedItems.Count >= 1)
            {
                selectedDrink = listViewDrinksSimple.SelectedItems[0].Tag as Drink;
                selectedStudent = listViewStudentSimple.SelectedItems[0].Tag as Student;
            }
            else
                return;

            CalculatePrice(selectedStudent, selectedDrink);

        }
        private void ListViewStudentSimple_Click(object sender, System.EventArgs e)
        {
            Student selectedStudent;
            Drink selectedDrink;
            if (listViewDrinksSimple.SelectedItems.Count >= 1 && listViewStudentSimple.SelectedItems.Count >= 1)
            {
                selectedDrink = listViewDrinksSimple.SelectedItems[0].Tag as Drink;
                selectedStudent = listViewStudentSimple.SelectedItems[0].Tag as Student;
            }
            else
                return;

            CalculatePrice(selectedStudent, selectedDrink);

        }
        public void CalculatePrice(Student student, Drink drink)
        {

            float priceToPay = float.Parse(drink.Price.ToString());
            if (drink.IsAlcoholic)
                priceToPay *= 1.21f;
            else
                priceToPay *= 1.06f;

            lblAmountToPay.Text = $"Amount to be paid: {priceToPay}";
        }
        private void BtnCalculateVat_Click(object sender, EventArgs e)
        {
            float highVAT = 0f;
            float lowVAT = 0f;
            float totalVAT;

            DrinkService drinkService = new DrinkService();

            int year = int.Parse(cbSelectYear.SelectedItem.ToString());
            int quarter = cbSelectQuarter.SelectedIndex + 1;


            DateTime start = new DateTime(year, 3 * (quarter - 1) + 1, 1);
            DateTime end = start.AddMonths(3).AddDays(-1);

            List<Drink> soldDrinks = drinkService.GetSoldDrinks(start, end);

            foreach (Drink drink in soldDrinks)
            {
                if (drink.IsAlcoholic)
                    highVAT += (float)drink.Price * 0.21f;
                else
                    lowVAT += (float)drink.Price * 0.06f;
            }
            lblVatQuarterRuns.Text = $"Quarter runs from: {start:dd-MM-yyyy} to: {end:dd-MM-yyyy}";
            lblVatTotalVATHigh.Text = $"Total VAT (high tariff, 21%) amount payable: {highVAT:C}";
            lblVatTotalVATLow.Text = $"Total VAT (low tariff, 6%) amount payable: {lowVAT:C}";
            lblVatTotalVAT.Text = $"Total VAT amount payable: {(highVAT + lowVAT):C}";

        }

        private void listOfActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }
        public void DisplaySimpleActivities(List<Activity> activities)
        {
            listViewActivitiesSimple.Clear();

            listViewActivitiesSimple.View = View.Details;
            listViewActivitiesSimple.Columns.Add("Activity ID");
            listViewActivitiesSimple.Columns.Add("Activity Name");


            foreach (Activity activity in activities)
            {
                ListViewItem item = new ListViewItem(activity.ActivityId.ToString());
                item.SubItems.Add(activity.Type);
                item.Tag = activity;
                listViewActivitiesSimple.Items.Add(item);
            }
            listViewActivitiesSimple.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private List<Student> GetParticipants(Activity activity)
        {
            ParticipantsService participantsService = new ParticipantsService();
            List<Student> students = participantsService.GetParticipants(activity);
            return students;
        }
        public void DisplayParticipants(List<Student> students)
        {
            // clear the listview before filling it
            listViewParticipants.Clear();

            listViewParticipants.View = View.Details;
            listViewParticipants.Columns.Add("Student ID");
            listViewParticipants.Columns.Add("First Name");
            listViewParticipants.Columns.Add("Last Name");

            foreach (Student student in students)
            {

                ListViewItem item = new ListViewItem(student.StudentId.ToString());
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);

                item.Tag = student;
                listViewParticipants.Items.Add(item);
            }
            listViewParticipants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private List<Student> GetNonParticipants(Activity activity)
        {
            ParticipantsService participantsService = new ParticipantsService();
            List<Student> students = participantsService.GetNonParticipants(activity);
            return students;
        }
        public void DisplayNonParticipants(List<Student> students)
        {
            // clear the listview before filling it
            listViewNonParticipants.Clear();

            listViewNonParticipants.View = View.Details;
            listViewNonParticipants.Columns.Add("Student ID");
            listViewNonParticipants.Columns.Add("First Name");
            listViewNonParticipants.Columns.Add("Last Name");

            foreach (Student student in students)
            {

                ListViewItem item = new ListViewItem(student.StudentId.ToString());
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);

                item.Tag = student;
                listViewNonParticipants.Items.Add(item);
            }
            listViewNonParticipants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        // private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        private void activityParticipantsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowActivityParticipantsPanel();
        }
        public void ShowActivityParticipantsPanel()
        {
            NewTab(pnlActivitiesParticipants, "Participants");
            /*            listViewParticipants.Hide();
            */
            try
            {
                // get and display all activities
                List<Activity> activities = GetActivities();
                DisplaySimpleActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }
        private void ListViewActivitiesSimple_Click(object sender, EventArgs e)
        {

            Activity selectedActivity = listViewActivitiesSimple.SelectedItems[0].Tag as Activity;

            try
            {
                List<Student> participants = GetParticipants(selectedActivity);
                List<Student> nonParticipants = GetNonParticipants(selectedActivity);
                DisplayParticipants(participants);
                DisplayNonParticipants(nonParticipants);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the participants: " + ex.Message);
            }
        }


        private void PnlActivitiesParticipants_Click(object sender, EventArgs e)
        {

        }
        private void ListViewNonParticipants_Click(object sender, EventArgs e)
        {

        }
        private void BtnAddParticipant_Click(object sender, EventArgs e)
        {
            ParticipantsService participantsService = new ParticipantsService();
            Activity selectedActivity = listViewActivitiesSimple.SelectedItems[0].Tag as Activity;
            Student selectedStudent = listViewNonParticipants.SelectedItems[0].Tag as Student;
            participantsService.AddParticipant(selectedActivity, selectedStudent);
            try
            {
                List<Student> participants = GetParticipants(selectedActivity);
                List<Student> nonParticipants = GetNonParticipants(selectedActivity);
                DisplayParticipants(participants);
                DisplayNonParticipants(nonParticipants);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the participants: " + ex.Message);
            }
        }

        private void BtnRemoveParticipant_Click(object sender, EventArgs e)
        {
            ParticipantsService participantsService = new ParticipantsService();
            Activity selectedActivity = listViewActivitiesSimple.SelectedItems[0].Tag as Activity;
            Student selectedStudent = listViewParticipants.SelectedItems[0].Tag as Student;



            DialogResult areYouSure = MessageBox.Show("Are you sure you wish to remove this participant?", "Remove Participant", MessageBoxButtons.YesNo);
            if (areYouSure == DialogResult.Yes)
                participantsService.RemoveParticipant(selectedActivity, selectedStudent);
            else
                return;
            try
            {
                List<Student> participants = GetParticipants(selectedActivity);
                List<Student> nonParticipants = GetNonParticipants(selectedActivity);
                DisplayParticipants(participants);
                DisplayNonParticipants(nonParticipants);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the participants: " + ex.Message);
            }
        }
    }
}


