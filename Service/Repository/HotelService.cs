using Assignment1.BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;

namespace Assignment1.Repository
{
    public class HotelService
    {
        private HotelRepo _hotelRepo = new HotelRepo();

        public List<RoomInformation> getAllRooms()
        {
            return _hotelRepo.getRoom();
        }
        public List<RoomInformation> getRoomByCol(string inpSearchType, string inpSearchPrice) 
        {
            return _hotelRepo.getRoomSearch(inpSearchType, inpSearchPrice);
        }
        public bool addRoom(RoomInformation room)
        {
            return _hotelRepo.addRoom(room); 
        }
        public bool updateRoom(RoomInformation room, int idCheck)
        {
            return _hotelRepo.updateRoom(room, idCheck);
        }
        public bool deleteRoom(RoomInformation room)
        {
            return _hotelRepo.deleteRoom(room);
        }
        public List<RoomType> getRoomType()
        {
            return _hotelRepo.getRoomType();
        }
        public string getRoomId()
        {
            return _hotelRepo.getRoomId();
        }
    }
}
