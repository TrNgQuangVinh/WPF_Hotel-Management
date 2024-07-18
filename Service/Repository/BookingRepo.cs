using Assignment1.BusinessObj;
//using Assignment1.GUI;
//using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository
{
    class BookingRepo
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
        public int getReserveId()
        {
            var count = 1;
            var reserve = from r in myHotel.BookingReservations
                        select new { r.BookingReservationId };
            foreach (var r in reserve)
            {
                count++;
            }
            return count++;
        }

        public bool addReservation(int reserveID, int ID, decimal? price, DateOnly? checkIn, DateOnly? checkOut)
        {
            try {
                BookingDetail reservation = new BookingDetail();
                reservation.BookingReservationId = reserveID;
                reservation.RoomId = ID;
                reservation.ActualPrice = price;
                reservation.StartDate = (DateOnly)checkIn;
                reservation.EndDate = (DateOnly)checkOut;
                myHotel.BookingDetails.Add(reservation);
                myHotel.SaveChanges();
                return true;
            } catch (Exception ex) 
            { 
                string error = ex.Message;
                return false; 
            }
        }

        public List<BookingDetail> getReservebyID(int rID)
        {
            List<BookingDetail> list = new List<BookingDetail> ();
            var booking = from d in myHotel.BookingDetails
                          where d.BookingReservationId == rID
                          select d;
            foreach(var d in booking)
            {
                list.Add(d);
            }
            return list;
        }

        public bool finalizeReservation(int reserveID, DateOnly? currentDate, decimal? totalPrice, string customerID, int v, string action)
        {
            try
            {
                if("Create".Equals(action)) 
                {
                    BookingReservation reservation = new BookingReservation();
                    reservation.BookingReservationId = reserveID;
                    reservation.BookingDate = currentDate;
                    reservation.TotalPrice = totalPrice;
                    reservation.CustomerId = int.Parse(customerID);
                    reservation.BookingStatus = (byte?)v;
                    myHotel.BookingReservations.Add(reservation);
                    myHotel.SaveChanges();
                    return true;
                }
                else if("Update".Equals(action)) 
                {
                    BookingReservation reservation = new BookingReservation();
                    reservation.BookingReservationId = reserveID;
                    reservation.BookingDate = currentDate;
                    reservation.TotalPrice = totalPrice;
                    reservation.CustomerId = int.Parse(customerID);
                    reservation.BookingStatus = (byte?)v;
                    if (reservation != null)
                    {
                        var rsv = myHotel.BookingReservations
                                       .FirstOrDefault(i => i.BookingReservationId == reservation.BookingReservationId);
                        if (rsv != null)
                        {
                            try
                            {
                                myHotel.Entry(rsv).CurrentValues.SetValues(reservation);
                                myHotel.BookingReservations.Update(rsv);
                                myHotel.SaveChanges();
                                return true;
                            }
                            catch { return false; }
                        } 
                    }  
                }
                return false;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return false;
            }
        }

        internal List<BookingDetail> getReservebyName(string name)
        {
            List<BookingDetail> list = new List<BookingDetail>();
            var detail = from d in myHotel.BookingDetails
                         join r in myHotel.BookingReservations on d.BookingReservationId equals r.BookingReservationId
                         join c in myHotel.Customers on r.CustomerId equals c.CustomerId
                         where name.Equals(c.CustomerFullName) && r.CustomerId == c.CustomerId && r.BookingReservationId == d.BookingReservationId
                         select d;
            foreach (var d in detail)
            {
                list.Add(d);
            }
            return list;
        }
    }
}
