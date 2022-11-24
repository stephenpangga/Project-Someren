using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class CashRegister
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int Sold { get; set; }
        public string Is_alcoholic { get; set; }
        public decimal VAT { get; set; }
    }
}
