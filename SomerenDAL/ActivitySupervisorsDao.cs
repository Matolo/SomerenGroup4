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
        public List<Teacher> GetSupervisorById(int ActivityId)
        {
            string query = "SELECT l.LecturerId, l.FirstName, l.LastName FROM Lecturerss AS l JOIN ActivitySupervisor AS a ON a.LecturerId = l.LecturerId WHERE a.ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ActivityId", ActivityId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Teacher> GetLecturersNotSupervising(int activityId)
        {
            string query = "SELECT l.LecturerId, l.FirstName, l.LastName FROM Lecturerss AS l  WHERE l.LecturerId NOT IN (SELECT a.LectureId FROM ActivitySupervisor a WHERE a.ActivityId = @ActivityId)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ActivityId", activityId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddSupervisors(ActivitySupervisors supervisor, int activityId)
        {
            string query = "INSERT INTO [ActivitySupervisor] (LecturerId, ActivityId) " +
                           "VALUES (@LectureIdId, @ActivityId)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@LectureIdId", supervisor.TeacherID),
        new SqlParameter("@ActivityId", activityId),

            };

            ExecuteEditQuery(query, sqlParameters);
        }




        public void DeleteSupervisor(int lecturerId, int activityId)
        {
            string query = "DELETE FROM [ActivitySupervisor] WHERE LecturerId = @LecturerId AND ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LecturerIdId", lecturerId),
                new SqlParameter("@ActivityId", activityId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> supervisors = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {


                Teacher supervisor = new Teacher()
                {
                    TeacherId = (int)dr["LecturerId"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString()

                };

                supervisors.Add(supervisor);
            }

            return supervisors;
        }
    }

}
