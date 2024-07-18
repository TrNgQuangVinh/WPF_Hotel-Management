using Assignment1.BusinessObj;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository
{
    public class HotelRepo
    {
        private FuminiHotelManagementContext myHotel = new FuminiHotelManagementContext();
        public List<RoomInformation> getRoom()
        {
            return myHotel.RoomInformations.ToList();
            /*var rooms = from i in myHotel.RoomInformations
                        join t in myHotel.RoomTypes on i.RoomTypeId equals t.RoomTypeId
                        select i;
                        .Include(room => room.RoomType)
                        .Join()
                        select r;
            return rooms.ToList();*/
        }

        public List<RoomInformation> getRoomSearch(string inpSearchType, string inpSearchPrice)
        {
            List<RoomInformation> list = new List<RoomInformation>();
            if (string.IsNullOrWhiteSpace(inpSearchPrice) && string.IsNullOrWhiteSpace(inpSearchType))
            {
                return getRoom();
            }
            else if (string.IsNullOrWhiteSpace(inpSearchPrice)) 
            {
                var room = from r in myHotel.RoomInformations
                           where r.RoomType.RoomTypeName.Contains(inpSearchType)
                           select r;
                foreach (var r in room)
                {
                    list.Add(r);
                }
            }
            else if (string.IsNullOrWhiteSpace(inpSearchType))
            {
                var room = from r in myHotel.RoomInformations
                           where r.RoomPricePerDay <= decimal.Parse(inpSearchPrice)
                           select r;
                foreach (var r in room)
                {
                    list.Add(r);
                }
            }
            else
            {
                var room = from r in myHotel.RoomInformations
                           where r.RoomPricePerDay <= decimal.Parse(inpSearchPrice) &&
                           r.RoomType.RoomTypeName.Contains(inpSearchType)
                           select r;
                foreach (var r in room)
                {
                    list.Add(r);
                }
            }
            return list;
        }

        public List<RoomType> getRoomType()
        {
            List<RoomType> list = new List<RoomType>();
            var rooms = from r in myHotel.RoomTypes
                        select new { r.RoomTypeName, r.RoomTypeId };
            foreach (var r in rooms)
            {
                list.Add(
                    new RoomType()
                    {
                        RoomTypeId = r.RoomTypeId,
                        RoomTypeName = r.RoomTypeName,
                    }
                );
            }
            return list;
        }

        public bool addRoom(RoomInformation room)
        {
            if (room != null)
            {
                myHotel.RoomInformations.Add(room);
                myHotel.SaveChanges();
                return true;
            }
            return false;
        }

        public string getRoomId()
        {
            var count = 0;
            var rooms = from r in myHotel.RoomInformations
                        select new { r.RoomId };
            foreach (var r in rooms)
            {
                count++;
                if (count != r.RoomId) return count.ToString();
            }
            return count.ToString();
        }

        public bool updateRoom(RoomInformation room, int idCheck)
        {
            if(room != null) 
            {
                var roominfo = myHotel.RoomInformations
                               .FirstOrDefault(i => i.RoomId == room.RoomId);
                if (roominfo == null)
                {
                    // no product, insert
                    addRoom(room);
                    return true;
                }
                else
                {
                    try
                    {
                        // there is product, update
                        myHotel.Entry(roominfo).CurrentValues.SetValues(room);
                        myHotel.RoomInformations.Update(roominfo);
                        //roominfo = room;
                        myHotel.SaveChanges();
                        return true;
                    }
                    catch { }
                }
                return false;
            }
            return false;
        }

        public bool deleteRoom(RoomInformation room)
        {
            if(room != null) 
            {
                var roomInfo = myHotel.RoomInformations
                               .FirstOrDefault(i => i.RoomId == room.RoomId);
                try
                {
                    myHotel.RoomInformations.Remove(room);
                    myHotel.SaveChanges();
                    return true;
                }
                catch (Exception e) { return false; }
            }
            return false;
        }
    }
}
