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
    public class Login_DAO : Base
    {
        //added secret question and answer
        public List<LoginData> Db_Get_Login_Data()
        {
            string query = "SELECT [Email_Address], Password, SecretQuestion, SecretAnswer FROM Register";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //added method for updating password
        public void UpdatePassword(string username, string password)
        {
            string query = "UPDATE Register SET Password='" + password + "' WHERE CONVERT(VARCHAR, [Email_Address])='" + username + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<LoginData> ReadTables(DataTable dataTable)
        {
            List<LoginData> lg = new List<LoginData>();

            foreach (DataRow dr in dataTable.Rows)
            {
                LoginData l = new LoginData()
                {
                    Username = (string)dr["Email_Address"],
                    Password = (string)dr["Password"],
                    //added secret question and secret answer
                    SecretQs = (string)dr["SecretQuestion"],
                    SecretAs = (string)dr["SecretAnswer"]
                };
                lg.Add(l);
            }
            return lg;
        }
    }
}
