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
        private void NewTab(Panel panel, string name)
        {
            foreach (Panel p in new[] { pnlDashboard, pnlStudents, pnlTeachers, pnlActivities, pnlRooms })
            {
                p.Hide();
            }
            panel.Show();

            label1.Show();
            label1.Visible = true;
            label1.AutoSize = true;
            label1.Text = name;
            panel.Controls.Add(label1);

            /*Doesn't work for some reason - will check later
             * pictureBox1.Show();
            pictureBox1.Visible = true;
            pictureBox1.AutoSize = true;
            panel.Controls.Add(pictureBox1);*/


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
            NewTab(pnlActivities, "Activities");
            label1.Text = "Activities";

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
            listViewActivities.Columns.Add("Time");

            foreach (Activity activity in activities)
            {
                ListViewItem item = new ListViewItem(activity.ActivityId.ToString());
                item.SubItems.Add(activity.Type);
                item.SubItems.Add(activity.Date.ToString("yyyy/MM/dd"));
                item.SubItems.Add(activity.time.ToString());
                item.Tag = activity;
                listViewActivities.Items.Add(item);
            }
            listViewActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }
        private void ShowTeachersPanel()
        {
            NewTab(pnlTeachers, "Teachers");

            try
            {
                // get and display all activities
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

            foreach (Teacher teacher in teachers)
            {
                ListViewItem item = new ListViewItem(teacher.TeacherId.ToString());
                item.SubItems.Add(teacher.FirstName);
                item.SubItems.Add(teacher.LastName);
                item.SubItems.Add(teacher.PhoneNumber.ToString());
                item.SubItems.Add(teacher.Age.ToString());
                item.Tag = teacher;
                listViewTeachers.Items.Add(item);
            }
            listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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
                // get and display all activities
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
            listViewRooms.Columns.Add("Student Occupant");
            listViewRooms.Columns.Add("Building");
            listViewRooms.Columns.Add("Type");
            listViewRooms.Columns.Add("Lecturer Occupant");

            foreach (Room room in rooms)
            {

                ListViewItem item = new ListViewItem(room.RoomId.ToString());
                if (room.StudentOccupant == 0)
                    item.SubItems.Add("");
                else
                    item.SubItems.Add(room.StudentOccupant.ToString());
                item.SubItems.Add(room.Building.ToString());
                item.SubItems.Add(room.Type.ToString());
                if(room.LecturerOccupant == 0)
                    item.SubItems.Add("");
                else
                    item.SubItems.Add(room.LecturerOccupant.ToString());
                item.Tag = room;
                listViewRooms.Items.Add(item);
            }
            listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }
    }

}
