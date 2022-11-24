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
    public class Login_Service
    {
        Login_DAO login_db = new Login_DAO();

        //added method for updating password
        public void UpdatePassword(string username, string password)
        {
            login_db.UpdatePassword(username, password);
        }

        public List<LoginData> GetLoginDatas()
        {
            //try
            //{
            List<LoginData> login = login_db.Db_Get_Login_Data();
            return login;
            //}
            //catch (Exception)
            //{
            //  throw new Exception("Someren couldn't connect to the database");
            //}
        }
    }
}
