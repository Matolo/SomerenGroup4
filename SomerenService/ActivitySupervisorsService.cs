using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ActivitySupervisorService
    {
        private ActivitySupervisorsDao supervisorsdb;

        public ActivitySupervisorService()
        {
            supervisorsdb = new ActivitySupervisorsDao();
        }

        public List<Teacher> GetSupervisors(Activity selectedActivity)
        {
            List<Teacher> supervisors = supervisorsdb.GetSupervisors(selectedActivity);
            return supervisors;
        }
        public List<Teacher> GetNotSupervisors(Activity selectedActivity, List<Teacher> supervisors)
        {
            List<Teacher> notSupervisors = supervisorsdb.GetNotSupervisors(selectedActivity, supervisors);
            return notSupervisors;
        }
        public void AddSupervisor(Activity selectedActivity, Teacher selectedTeacher)
        {
            supervisorsdb.AddSupervisor(selectedActivity, selectedTeacher);
        }
        public void DeleteSupervisor(Activity selectedActivity, Teacher selectedTeacher)
        {
            supervisorsdb.DeleteSupervisor(selectedActivity, selectedTeacher);
        }

    }
}
