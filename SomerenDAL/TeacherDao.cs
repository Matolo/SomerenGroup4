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
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT LecturerId, FirstName, LastName, PhoneNumber, Age, RoomId FROM Lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    TeacherId = (int)(dr["LecturerId"]),
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    PhoneNumber = (int)dr["PhoneNumber"],
                    Age = (int)dr["Age"],
                    RoomId = (int)dr["RoomId"],
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}