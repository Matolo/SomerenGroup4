using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivitiesDao activitiydb;

        public ActivityService()
        {
            activitiydb = new ActivitiesDao();
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activities = activitiydb.GetAllActivity();
            return activities;
        }
    }
}
