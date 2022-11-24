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
    public class TimeTable_Service
    {
        TimeTable_DAO timeTable_db = new TimeTable_DAO();

        public List<TimeTable> GetTimeTables()
        {
            try
            {
                List<TimeTable> tt = timeTable_db.Db_Get_TimeTable();
                return tt;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}
