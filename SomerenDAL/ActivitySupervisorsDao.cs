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
        public List<Teacher> GetSupervisors(Activity selectedActivity)
        {
            string query = "SELECT SupervisorId FROM ActivitySupervisor WHERE ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", selectedActivity.ActivityId)
            };
            return AddSupervisorList(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Teacher> GetNotSupervisors(Activity selectedActivity, List<Teacher> supervisors)
        {
            string query = "SELECT LecturerId FROM Lecturer ";
            ///Creating a SQL line
            if (supervisors.Capacity > 0)
            {
                bool firstSupervisor = false;
                query += "WHERE ";
                foreach (Teacher supervisor in supervisors)
                {
                    if (firstSupervisor)
                    {
                        query += " AND ";
                    }
                    else
                        firstSupervisor = true;
                    query += $"LecturerId != {supervisor.TeacherId}";
                }
            }
            //---
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return AddNotSupervisorList(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Teacher> AddSupervisorList(DataTable dataTable)
        {
            List<Teacher> supervisors = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                supervisors.Add(GetLecturerById((int)dr["SupervisorId"]));
            }
            return supervisors;
        }
        private List<Teacher> AddNotSupervisorList(DataTable dataTable)
        {
            List<Teacher> supervisors = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                supervisors.Add(GetLecturerById((int)dr["LecturerId"]));
            }
            return supervisors;
        }
        public Teacher GetLecturerById(int id)
        {
            string query = "SELECT LecturerId, [First Name], [Last Name],  IsSupervisor FROM [Lecturers] WHERE LecturerId = @LecturerId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LecturerId", id)
            };
            Teacher teacher = new Teacher();
            foreach (DataRow dr in ExecuteSelectQuery(query, sqlParameters).Rows)
            {
                teacher.TeacherId = (int)dr["LecturerId"];
                teacher.FirstName = dr["First Name"].ToString();
                teacher.LastName = dr["Last Name"].ToString();
                teacher.isSupervisor = (bool)dr["IsSupervisor"];
            }
            return teacher;
        }
        public void AddSupervisor(Activity selectedActivity, Teacher selectedTeacher)
        {
            string query = "INSERT INTO ActivitySupervisor (SupervisorId, ActivityId) " +
                           "VALUES (@SupervisorId, @ActivityId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@SupervisorId", selectedTeacher.TeacherId),
                new SqlParameter("@ActivityId", selectedActivity.ActivityId)
            };
            ExecuteEditQuery(query, sqlParameters);

        }
        public void DeleteSupervisor(Activity selectedActivity, Teacher selectedTeacher)
        {
            string query = "DELETE FROM ActivitySupervisor WHERE SupervisorId = @SupervisorId AND ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                 new SqlParameter("@SupervisorId", selectedTeacher.TeacherId),
                 new SqlParameter("@ActivityId", selectedActivity.ActivityId)

            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }

}
