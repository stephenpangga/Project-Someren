using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Revenue
    {
        //Date
        public DateTime Date { get; set; }

        //drink information
        public int Prod_Sold { get; set; }
        public int Price { get; set; }
        public int Students { get; set; }

        //calculated property of turnover.
        private int turnover;

        public int Turnover
        {
            get { return Prod_Sold * Price; }
        }

        //SPECIFICALLY FOR counting the amount of student.
        public static int NumbOfStudent { get; set; }
    }
}
