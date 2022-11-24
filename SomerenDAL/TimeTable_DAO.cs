using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class TimeTable_DAO : Base
    {
        public List<TimeTable> Db_Get_TimeTable()
        {
            string query = "SELECT * FROM [TimeTable]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<TimeTable> ReadTables(DataTable dataTable)
        {
            List<TimeTable> timeTables = new List<TimeTable>();
            foreach (DataRow dr in dataTable.Rows)
            {
                TimeTable timeTable = new TimeTable()
                {
                    Activity = (int)dr["Activity"],
                    //Supervisor = (int)dr["Supervisor"],
                    Date = (DateTime)(dr["Date"])
                };
                timeTables.Add(timeTable);
            }
            return timeTables;
        }
    }
}
