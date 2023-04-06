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
        private ActivitySupervisorsDao activitySupervisorsdb;

        public ActivitySupervisorsService()
        {
            activitySupervisorsdb = new ActivitySupervisorsDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = activitySupervisorsdb.GetAllSupervisors();
            return teachers;
        }

        public void DeleteTeacher(int TeacherId)
        {
            activitySupervisorsdb.DeleteSupervisor(TeacherId);
        }
        public void AddTeacher(Teacher teacher)
        {
            activitySupervisorsdb.AddSupervisor(teacher);
        }
      
    }
}
