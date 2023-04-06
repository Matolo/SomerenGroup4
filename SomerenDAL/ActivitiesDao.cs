using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace SomerenDAL
{
    public class ActivitiesDao : BaseDao
    {
        public List<SomerenModel.Activity> GetAllActivity()
        {
            string query = "SELECT ActivityId, Type, Date, BeginTime,EndTime FROM Activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<SomerenModel.Activity> ReadTables(DataTable dataTable)
        {
            List<SomerenModel.Activity> activities = new List<SomerenModel.Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                SomerenModel.Activity activity= new SomerenModel.Activity()
                {
                    ActivityId = (int)dr["ActivityId"],
                    Type = dr["Type"].ToString(),
                    Date = (DateTime)dr["Date"],
                    time = (TimeSpan)dr["BeginTime"],
                    EndTime = (TimeSpan)dr["EndTime"]
                };
                activities.Add(activity);
            }
            return activities;
        }
        public void DeleteActivity(int ActivityId)
        {
            string query = $"DELETE FROM Activity WHERE ActivityId = {ActivityId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void AddActivity(SomerenModel.Activity activity)
        {
            string query = $"INSERT INTO Activities (ActivityId, Type, Date, BeginTime, EndTime)" +
                $"VALUES ({activity.ActivityId}, '{activity.Type}', {activity.Date}, '{activity.time}', {activity.EndTime})";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateActivity(SomerenModel.Activity activity)
        {
            string query = $"UPDATE Activity SET Type = '{activity.Type}', Date = {activity.Date}, time = '{activity.time}', EndTime = {activity.EndTime} WHERE ActivityId = {activity.ActivityId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
     
    }
}
