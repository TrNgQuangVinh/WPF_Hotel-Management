using Assignment1.BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository
{
    public class DatabaseTest
    {
        public static string testConnection()
        {
            try 
            {
                List<dynamic> list = new List<dynamic>();
                FuminiHotelManagementContext myHotel = new FuminiHotelManagementContext();
                var rooms = from r in myHotel.RoomInformations
                            select new { r.RoomId };
                //select new { r.RoomId, r.RoomNumber, r.RoomDetailDescription, r.RoomType };
                if (rooms.Count() > 0) { return "Connection is good!"; }
                return "Bad connection";
            } catch (Exception e) { return "Bad connection"; } 
        }
    }
}
