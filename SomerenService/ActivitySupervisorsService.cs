using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ActivitySupervisorsService
    {
        private ActivitySupervisorsDao teacherdb;

        public ActivitySupervisorsService()
        {
            teacherdb = new ActivitySupervisorsDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherdb.GetAllTeachers();
            return teachers;
        }

        public void DeleteDrink(int TeacherId)
        {
            teacherdb.DeleteTeacher(TeacherId);
        }
        public void AddTeacher(Teacher teacher)
        {
            teacherdb.AddTeacher(teacher);
        }
      
    }
}
