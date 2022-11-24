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
    public class Revenue_DAO : Base
    {

        public List<Revenue> Db_Get_All_Revenue()
        {

            //string query = "SELECT * FROM Bar WHERE Date LIKE '2019-03-16'"; //-->this works so far//i wiill neeed a count(amount of student) sql code

            //string query = "SELECT * FROM Sales Where Date LIKE 03-16-2019 ";


            string query = "SELECT S.date, D.Sold, D.price, S.studentID " +
                           "FROM Sales as S " +
                           "JOIN Drinks as D ON D.[Drink Id] = S.drinkID";

            //need to use GROUP BYs and JOIN said by bae.

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Revenue> ReadTables(DataTable dataTable)
        {
            int studentcount = 1;

            List<Revenue> revenues = new List<Revenue>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Revenue revenue = new Revenue()
                {
                    //Name = (String)(dr["Name"].ToString()),
                    Students = (int)(dr["studentID"]),
                    Date = (DateTime)dr["date"],
                    Price = (int)dr["Price"],
                    Prod_Sold = (int)dr["Sold"]
                    //need to make turnover, total number of student who bought products and the sales                   

                };
                revenues.Add(revenue);

                Revenue.NumbOfStudent += studentcount;

            }
            return revenues;
        }

        //this part is only dedicated to obtaining the date from data table
        public List<Revenue> Db_Get_All_Date(DateTime startD, DateTime endD)
        {
            string query = "SELECT S.date, D.Sold, D.price, S.studentID " +
                           "FROM Sales as S " +
                           "JOIN Drinks as D ON D.[Drink Id] =S.drinkID " +
                           "WHERE date BETWEEN '"+ startD.ToString("yyyy-MM-dd")+"' AND '"+endD.ToString("yyyy-MM-dd")+ "'";


            //"WHERE date BETWEEN '"+startD.Year+ "-" +startD.Month+ "-" + startD.Day + "' " +
            //"AND '"+endD.Year+"-"+endD.Month+"-"+endD.Day+"' ";
            //$"WHERE date LIKE {startD.ToString("dd-mm-yyyy")}";
            //but one works when i choose more than 1 date
            //$"WHERE date BETWEEN ({startD.ToString("yyyy-mm-dd")} AND {endD.ToString("yyyy-mm-dd")})";

            //the specific date works. therefore this should work but it doesnt.

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));


            //return ReadTableDate(ExecuteSelectQuery(query1, sqlParameters));
        }
        /*
        private List<Revenue> ReadTableDate(DataTable dataTable)
        {
            int studentcount = 1;
            List<Revenue> revenueD = new List<Revenue>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Revenue revenueDs = new Revenue()
                {
                    Date = (DateTime)dr["date"],
                    Students = (int)(dr["studentID"]),
                    Price = (int)dr["Price"],
                    Prod_Sold = (int)dr["Sold"]

                };
                revenueD.Add(revenueDs);

                Revenue.NumbOfStudent += studentcount;
            }
            return revenueD;
        }
        */
    }
}
