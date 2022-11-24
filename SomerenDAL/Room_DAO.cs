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
    public class Room_DAO : Base
    {
        //Mohaymen's code

        public List<Room> Db_Get_All_Rooms()
        {
            string query = "SELECT * FROM Room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Room_Id = (int)dr["Room Id"],
                    Type = (String)(dr["TypeOfRoom"].ToString()),
                    Occupied = (String)(dr["Taken/Not-Taken"].ToString()),
                    Size = (int)(dr["Size"])
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
