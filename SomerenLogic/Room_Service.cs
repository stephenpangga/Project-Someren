using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;


namespace SomerenLogic
{
    public class Room_Service
    {
        Room_DAO student_db = new Room_DAO();

        public List<Room> GetRooms()
        {
            try
            {
                List<Room> room = student_db.Db_Get_All_Rooms();
                return room;
            }
            catch (Exception)
            {
                /*List<Room> rooms = new List<Room>();

                Room room = new Room();
                room.Room_Id = 5;
                room.Type = "Student";
                room.Occupied = "Taken";
                room.Size = 12;
                rooms.Add(room);

                Room room1 = new Room();
                room.Room_Id = 12;
                room.Type = "Teacher";
                room.Occupied = "Not Taken";
                room.Size = 43;
                rooms.Add(room);

                return rooms;*/

                throw new Exception("No connection to the database.");
            }
        }
    }
}
