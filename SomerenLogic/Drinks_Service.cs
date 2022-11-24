using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenLogic
{
    public class Drinks_Service
    {
        Drinks_DAO drink_db = new Drinks_DAO();

        public void AddDrinks(string name, int price, int stock, string Is_alc, Decimal VAT)
        {
            drink_db.AddDrinks(name, price, stock, Is_alc, VAT);
        }

        public void DeleteDrinks(int id)
        {
            drink_db.DeleteDrinks(id);
        }

        public void UpdateDrinks(int id, string name, int price, int stock, string Is_alc, Decimal VAT)
        {
            drink_db.UpdateDrinks(id, name, price, stock, Is_alc, VAT);
        }

        public List<Drinks> GetDrinks()
        {
            try
            {
                List<Drinks> drinkslist = drink_db.Db_Get_All_Drinks();

                foreach (var d in drinkslist)
                {
                    int stock = d.Stock;

                    if (stock <= 9)
                    {
                        d.Stock_Status = "'Stock nearly depleted";
                    }
                    else
                    {
                        d.Stock_Status = "Stock sufficient";
                    }

                }
                return drinkslist;
            }
            catch (Exception exit)
            {
                Console.WriteLine(exit.Message);
                throw new Exception("Someren could not connect to the database");

            }
        }


    }
}
