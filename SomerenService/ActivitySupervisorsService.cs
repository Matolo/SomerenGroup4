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

        public List<Teacher> GetSupervisors(int id)
        {
            List<Teacher> supervisors = supervisorsdb.GetSupervisorById(id);
            return supervisors;
        }
        public List<Teacher> GetNotSupervisors(int id)
        {
            List<Teacher> notSupervisors = supervisorsdb.GetLecturersNotSupervising(id);
            return notSupervisors;
        }
        public void AddSupervisor(ActivitySupervisors supervisor, int id)
        {
            supervisorsdb.AddSupervisors(supervisor,id);
        }
        public void DeleteSupervisor(int lecturerId, int id)
        {
            supervisorsdb.DeleteSupervisor(lecturerId, id);
        }

    }
}
