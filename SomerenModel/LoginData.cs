using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class LoginData : Register
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //added secretqs and secret as
        public string SecretQs { get; set; }
        public string SecretAs { get; set; }
    }
}
