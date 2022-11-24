using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Drinks_DAO : Base
    {
        public void AddDrinks(string name, int price, int stock, string is_alc, Decimal VAT)
        {
            //Added MAX drink id so the newest added drink shows up as the first
            string query = "SELECT MAX([Drink Id]) as ID FROM Drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            int idd = ReadValue(ExecuteSelectQuery(query, sqlParameters));
            Console.WriteLine("IDD = " + idd);
            int id = idd + 1;
            string query1 = "INSERT INTO Drinks VALUES ('" + name + "'," + price + "," + stock + ", 0,'" + is_alc + "'," + VAT + ")";
            SqlParameter[] sqlParameters1 = new SqlParameter[0];
            ExecuteEditQuery(query1, sqlParameters1);

        }
        public void DeleteDrinks(int id)
        {
            string query = "DELETE FROM Drinks WHERE [Drink Id]=" + id;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private int ReadValue(DataTable dataTable)
        {
            int id;
            id = dataTable.Rows[0].Field<int>("ID");
            return id;
        }
        public void UpdateDrinks(int id, string name, int price, int stock, string is_alc, Decimal VAT)
        {
            string query = "UPDATE Drinks SET Name='" + name + "', Price=" + price + ", Stock=" + stock + ", Is_Acoholic= '" + is_alc + "', VAT=" + VAT + " WHERE [Drink Id]=" + id;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

        }
        public List<Drinks> Db_Get_All_Drinks()
        {
            string query = "SELECT [Drink ID], Name, Price, Stock, Sold, Is_Acoholic, VAT FROM Drinks WHERE Stock>1 AND Price>1 ORDER BY Stock ASC, Price ASC, Sold ASC;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {

                Drinks drink = new Drinks()
                {
                    ID = (int)(dr["Drink Id"]),
                    Name = (String)(dr["Name"].ToString()),
                    Price = (int)dr["Price"],
                    Stock = (int)dr["Stock"],
                    Sold = (int)dr["Sold"],
                    is_alcoholic = (String)(dr["Is_Acoholic"].ToString()),


                };
                drinks.Add(drink);

            }
            return drinks;
        }
    }
}
