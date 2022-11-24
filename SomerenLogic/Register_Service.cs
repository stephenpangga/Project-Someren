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
    //stephen did this part
    public class Register_Service
    {
        Register_DAO register_db = new Register_DAO();
        public Status UserStatus;

        public List<Register> GetRegisters()
        {
            try
            {
                List<Register> register = register_db.Db_Get_All_Register();
                return register;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }
        //public List<Register> GetAdmins()
        //{
        //    try
        //    {
        //        List<Register> register = register_db.GetAlladmins();
        //        return register;
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("Someren couldn't connect to the database");
        //    }
        //}
        public void AddUser(string name,string email,string password,Status user)
        {
            register_db.AddRegister(name, email, password, (int)user);
        }
        
        //stephen
    }
}
