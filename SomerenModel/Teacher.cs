using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int TeacherId { get; set; }     // database id
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public int RoomId { get; set; }
    }
}