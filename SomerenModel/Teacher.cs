using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Teacher
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String supervisor { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198
        public String Department { get; set; }
        public int Contact { get; set; }
    }
}
