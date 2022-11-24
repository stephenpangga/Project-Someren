using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Cash_Service
    {
        Cash_DAO ra_db = new Cash_DAO();
        public void InsertCashBill(string name, List<string> drink)
        {
            ra_db.InsertCash(name, drink);
        }
    }
}
