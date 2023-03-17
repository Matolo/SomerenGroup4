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
            string query = "SELECT ActivityId, Type, Date, time FROM Activity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<SomerenModel.Activity> ReadTables(DataTable dataTable)
        {
            List<SomerenModel.Activity> Activities = new List<SomerenModel.Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                SomerenModel.Activity activity= new SomerenModel.Activity()
                {
                    ActivityId = (int)dr["ActivityId"],
                    Type = dr["Type"].ToString(),
                    Date = (DateTime)dr["Date"],
                    time = (TimeSpan)dr["time"]
                };
                Activities.Add(activity);
            }
            return Activities;
        }
    }
}
