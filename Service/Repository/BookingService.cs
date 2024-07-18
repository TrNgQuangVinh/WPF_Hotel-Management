using Assignment1.BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository
{
    public class BookingService
    {
        private BookingRepo _bookingRepo = new BookingRepo();
        public List<RoomInformation> getAllRooms() { return _bookingRepo.getRoom(); }
        public int getReserveId() { return _bookingRepo.getReserveId(); }

        public bool addReservation(int reserveID, int ID, decimal? price, DateOnly? checkIn, DateOnly? checkOut)
        {
            return _bookingRepo.addReservation(reserveID, ID, price, checkIn, checkOut);
        }

        public List<BookingDetail> getReservebyID(int rID)
        {
            return _bookingRepo.getReservebyID(rID);
        }

        public bool finalizeReservation(int reserveID, DateOnly? currentDate, decimal? totalPrice, string customerID, int v, string action)
        {
            return _bookingRepo.finalizeReservation(reserveID, currentDate, totalPrice, customerID, v, action);
        }

        public List<BookingDetail> getReservebyName(string name)
        {
            return _bookingRepo.getReservebyName(name);
        }
    }
}
