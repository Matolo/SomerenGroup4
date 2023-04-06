using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class TeacherService
    {
        private TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }
        public void DeleteTeacher(int TeacherId)
        {
            teacherdb.DeleteTeacher(TeacherId);
        }
        public void AddTeacher(Teacher teacher)
        {
            teacherdb.AddTeacher(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherdb.GetAllTeachers();
            return teachers;
        }
    }
}