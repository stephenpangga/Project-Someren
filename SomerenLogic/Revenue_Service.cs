using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Revenue_Service
    {
        Revenue_DAO revenue_db = new Revenue_DAO();

        //just for the basic information from the date.
        public List<Revenue> GetRevenue()
        {
            try
            {
                List<Revenue> revenue = revenue_db.Db_Get_All_Revenue();
                return revenue;
            }
            catch (Exception)
            {
                /*
                List<Revenue> revenue = new List<Revenue>();

                Revenue r1 = new Revenue();
                //r1.Date = 2011-03-16;
                r1.Name = "capri sun";

                revenue.Add(r1);
                Revenue r2 = new Revenue();
                //r2.Date =;
                r1.Name = "wine";

                return revenue;
                */
                throw new Exception("Someren couldn't connect to the database");
            }
        }
        //specific for the date.
        public List<Revenue> GetDate(DateTime startD, DateTime endD)
        {
            try
            {
                List<Revenue> RevDate = revenue_db.Db_Get_All_Date(startD, endD);

                return RevDate;
            }
            catch (Exception)
            {
                throw new Exception("Date not working/Date data can't be reached ");
            }
        }
    }
}
