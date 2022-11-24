using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class Cash_DAO : Base
    {
        public void InsertCash(string name, List<string> drink)
        {
            string q1 = "";
            string q2 = "";
            q1 = "SELECT Student Id as ID FROM Students WHERE Name = '" + name + "')";
            q2 = "SELECT Drink Id as ID FROM Drinks WHERE Name = '" + drink + "')";
            SqlParameter[] sqlParameters1 = new SqlParameter[0];
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            int idStd = ReadValue(ExecuteSelectQuery(q1, sqlParameters1));
            int idDrk = ReadValue(ExecuteSelectQuery(q2, sqlParameters2));
            int id = 1;
            foreach (var item in drink)
            {
                string query = "INSERT INTO Sales VALUES (" + id + ", " + idStd + "," + idDrk + " ,'" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
                id++;
            }
        }
        private int ReadValue(DataTable dataTable)
        {
            int id = 0;
            try
            {
                id = dataTable.Rows[0].Field<int>("ID");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            return id;
        }
    }
}
