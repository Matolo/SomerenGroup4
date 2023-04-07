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
            //CHANGE THE QUERIES SO THERE ISN'T * ANYWHERE 
            string query = $"SELECT * FROM Participant JOIN Students ON Students.StudentId = Participant.StudentId WHERE Participant.ActivityId = {activity.ActivityId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Student> GetNonParticipants(Activity activity)
        {
            string query = $"SELECT * FROM Students WHERE Students.StudentId NOT IN (SELECT Students.StudentId FROM Participant JOIN Students ON Students.StudentId = Participant.StudentId WHERE Participant.ActivityId = {activity.ActivityId})";
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
        public void AddParticipant(Activity activity, Student student)
        {
            string query = $"INSERT INTO Participant (StudentId, ActivityId) VALUES ({student.StudentId}, {activity.ActivityId})" +
                $"SELECT * FROM Participant"; //idk why I have to do this everytime I instert something
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }
        public void RemoveParticipant(Activity activity, Student student)
        {
            string query = $"DELETE FROM Participant WHERE StudentId = {student.StudentId}" +
                $"SELECT * FROM Participant";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
