using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
         
            // show dashboard
            pnlDashboard.Show();
        }
        


        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlStudents.Show();

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

            foreach (Student student in students)
            {

                ListViewItem item = new ListViewItem(student.StudentId.ToString());
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.PhoneNumber);
                item.Tag = student;
                listViewStudents.Items.Add(item);
            }
            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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

        //Activity Part!!!
        //private ListView listViewActivities;
        private void ShowActivitiesPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();

            // show activities
            pnlStudents.Show();

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
            listViewStudents.Clear();

            listViewStudents.View = View.Details;
            listViewStudents.Columns.Add("Activity ID");
            listViewStudents.Columns.Add("Activity Name");
            listViewStudents.Columns.Add("Date");
            listViewStudents.Columns.Add("Time");

            foreach (Activity activity in activities)
            {
                ListViewItem item = new ListViewItem(activity.ActivityId.ToString());
                item.SubItems.Add(activity.Type);
                item.SubItems.Add(activity.Date.ToString("yyyy/MM/dd"));
                item.SubItems.Add(activity.time.ToString());
                item.Tag = activity;
                listViewStudents.Items.Add(item);
            }
            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }
    }
}