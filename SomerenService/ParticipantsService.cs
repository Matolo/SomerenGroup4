using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ParticipantsService
    {
        private ParticipantsDao participantsdb;

        public ParticipantsService()
        {
            participantsdb = new ParticipantsDao();
        }

        public List<Student> GetParticipants(Activity activity)
        {
            List<Student> students = participantsdb.GetAllParticipants(activity);
            return students;
        }
        public List<Student> GetNonParticipants(Activity activity)
        {
            List<Student> students = participantsdb.GetNonParticipants(activity);
            return students;
        }
        public void AddParticipant(Activity activity, Student student)
        {
            participantsdb.AddParticipant(activity, student);
        }
        public void RemoveParticipant(Activity activity, Student student)
        {
            participantsdb.RemoveParticipant(activity, student);
        }
    }
}
