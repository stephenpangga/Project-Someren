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
    public class Register_DAO:Base
    {
        //stephen's part for variant B
        //this is specifically for the admins, not sure if needed. but its a trial.
        //public List<Register> GetAlladmins()
        //{
        //    string queryUser = "SELECT *" +
        //                        "FROM Register" +
        //                        "WHERE adminStatus LIKE 3";

        //    SqlParameter[] sqlParameters = new SqlParameter[0];

        //    return ReadTable(ExecuteSelectQuery(queryUser, sqlParameters));
        //}
        public List<Register> Db_Get_All_Register()
        {
            string query = "SELECT [Name], [Email_Address], [Password], adminStatus " + 
                           "FROM Register";
            //, adminStatus
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Register> ReadTable(DataTable dataTable)
        {
            List<Register> registered = new List<Register>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Register registration = new Register()
                {
                    Name = (String)(dr["Name"].ToString()),
                    Email = (String)(dr["Email_Address"].ToString()),
                    Password = (String)(dr["Password"].ToString()),
                    //(int)UserStatus= (int)(dr["adminStatus"])
                    userNumber =(int)(dr["adminStatus"])
                };
                registered.Add(registration);
            }
            return registered;
        }
        public void AddRegister(string name, string email, string password, int user)
        {
            string addquerry = "INSERT INTO Register ([Name], [Email_Address], [Password], adminStatus) " +
                "VALUES ('" + name+"','"+email+"','"+password+"','"+user+"')";

            SqlParameter[] sqlParametersAdd = new SqlParameter[0];

            ExecuteEditQuery(addquerry, sqlParametersAdd);
        }
        //end of stephen's part for variantB
    }
}
