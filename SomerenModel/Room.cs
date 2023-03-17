using System;

namespace SomerenModel
{
    public class Room
    {
        public int RoomId { get; set; }         // database id
        public int StudentOccupant { get; set; }     // RoomNumber, e.g. 206
        public string Building { get; set; }   // number of beds, either 4, 6, 8, 12 or 16
        public string Type { get; set; }      // student = false, teacher = true
        public int LecturerOccupant { get; set; }      // student = false, teacher = true
    }
}