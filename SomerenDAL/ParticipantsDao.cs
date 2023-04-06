using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class ParticipantsDao : BaseDao
    { 
        public List<Student> GetAllParticipants(Activity activity)
        {
            string query = $"SELECT * FROM Participant JOIN Students ON Students.StudentId = Participant.StudentId WHERE Participant.ActivityId = {activity.ActivityId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentId = (int)dr["StudentId"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    PhoneNumber = dr["PhoneNumber"].ToString(),
                    RoomId = (int)dr["RoomId"],
                };
                students.Add(student);
            }
            return students;
        }
    }
}
