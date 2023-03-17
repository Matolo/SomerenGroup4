using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan time { get; set; }
    }
}
