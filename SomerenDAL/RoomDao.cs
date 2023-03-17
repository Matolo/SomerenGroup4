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
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT RoomId, StudentOccupant, Building, Type, LecturerOccupant FROM Room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    RoomId = (int)dr["RoomId"],
                    Building = dr["Building"].ToString(),
                    Type = (string)dr["Type"],
                };

                if (DBNull.Value.Equals(dr["LecturerOccupant"]))
                    room.LecturerOccupant = 0;
                else
                    room.LecturerOccupant = (int)dr["LecturerOccupant"];

                if (DBNull.Value.Equals(dr["StudentOccupant"]))
                    room.StudentOccupant = 0;
                else
                    room.StudentOccupant = (int)dr["StudentOccupant"];

                rooms.Add(room);
            }
            return rooms;
        }
    }
}