using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drinks
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public int Price { get; set; }

        public int Stock { get; set; }
        public int Sold { get; set; }

        public string Stock_Status { get; set; }
        public String is_alcoholic { get; set; }

        public Decimal VAT { get; set; }
    }

}
