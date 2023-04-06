using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class ActivitySupervisorsDao:BaseDao
    {
        public List<ActivitySupervisors> GetAllSupervisors()
        {
            string query = "SELECT LecturerId, FirstName, LastName, PhoneNumber, Age, RoomId FROM Lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
       // public List<ActivitySupervisors> GetActivitiys()
       // {

       // }
       private List<ActivitySupervisors> ReadTables(DataTable dataTable)
        {
            List<ActivitySupervisors> activitiesSupervisors = new List<ActivitySupervisors>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ActivitySupervisors activitySupervisor = new ActivitySupervisors()
                {
                    TeacherID = (int)dr["LectureId"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    isSupervisors = (bool)dr["isSupervisor"]
                };
                activitiesSupervisors.Add(activitySupervisor);
            }
            return activitiesSupervisors;
        }
        public void AddSupervisor(Teacher teacher)
        {
            string query = $"INSERT INTO Teacher (TeacherID, FirstName, LastName, Supervisor)" +
                $"VALUES ({teacher.TeacherId}, '{teacher.FirstName}', {teacher.LastName}, '{teacher.isSupervisor}')";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

        }
        public void DeleteSupervisor(int TeacherID)
        {
            string query = $"DELETE FROM Teacher WHERE TeacherID = {TeacherID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }

}
