using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    //stephen parts
    public class Register
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

        //this is for the different level of Users.
        public Status UserStatus { get; set; }
        public int userNumber { get; set; }
    }
}
