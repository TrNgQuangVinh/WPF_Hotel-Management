using Assignment1.BusinessObj;
using Assignment1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment1.GUI
{
    /// <summary>
    /// Interaction logic for BookingInterface.xaml
    /// </summary>
    public partial class BookingInterface : Window
    {
        decimal? totalPrice=0;
        List<RoomInformation> roomInfo = new List<RoomInformation>();
        List<BookingDetail> bookDetail = new List<BookingDetail>();
        public static BookingService bookingService = new BookingService();
        string customerID;
        public BookingInterface(string data)
        {
            InitializeComponent();
            hiddenContinue.Text = "no";
            txtTotal.Text = "Total price: 0";
            Loaded += dgrRoomInfo_Loaded;
            Loaded += dgrBooking_Loaded;
            customerID = data;
        }

        private void dgrBooking_Loaded(object sender, RoutedEventArgs e)
        {
            dgrBooking.ItemsSource = null;
        }

        private void dgrRoomInfo_Loaded(object sender, RoutedEventArgs e)
        {
            dgrRoomInfo.ItemsSource = null;
            roomInfo = bookingService.getAllRooms();
            dgrRoomInfo.ItemsSource = roomInfo;
        }

        private void dgrRoomInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RoomInformation room = (RoomInformation)dgrRoomInfo.SelectedItem;
            txtPrice.Text = "Price: "+room.RoomPricePerDay.ToString();
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            int reserveID = 1;
            DateOnly? checkIn = null;
            DateOnly? checkOut = null;
            DateOnly? currentDate = null;
            checkIn = DateOnly.FromDateTime((DateTime)dateCheckin.SelectedDate);
            checkOut = DateOnly.FromDateTime((DateTime)dateCheckout.SelectedDate);
            currentDate = DateOnly.FromDateTime((DateTime)DateTime.Today);
            if (checkIn > currentDate && checkOut >= currentDate)
            {
                if (checkIn == null || checkOut == null)
                {
                    txtError.Text = "Please pick a check-in date and check-out date!";
                }
                else if (checkIn != null && checkOut != null)
                {
                    if (hiddenContinue.Text.Equals("no"))
                    {
                        reserveID = bookingService.getReserveId();
                        check = bookingService.finalizeReservation(reserveID, currentDate, totalPrice, customerID, 1, "Create");
                    }
                    RoomInformation room = (RoomInformation)dgrRoomInfo.SelectedItem;
                    int roomID = room.RoomId;
                    decimal? price = room.RoomPricePerDay;
                    check = bookingService.addReservation(reserveID, roomID, price, checkIn, checkOut);
                    totalPrice += price;
                }
                if (check)
                {
                    var result = System.Windows.MessageBox.Show("Do you want to continue with this order?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        hiddenContinue.Text = "yes";
                        check = false;
                        dgrBookingByID(reserveID);
                        txtTotal.Text = $"Total price: {totalPrice}";
                        check = bookingService.finalizeReservation(reserveID, currentDate, totalPrice, customerID, 1, "Update");
                    }
                    else if (result == MessageBoxResult.No)
                    {
                        hiddenContinue.Text = "no";
                        check = false;
                        dgrBookingByID(reserveID);
                        txtTotal.Text = $"Total price: {totalPrice}";
                        check = bookingService.finalizeReservation(reserveID, currentDate, totalPrice, customerID, 1, "Update");
                    }
                    //check = false;
                    //check = bookingService.finalizeReservation(reserveID, currentDate, totalPrice, customerID, 1);
                }
            }
            else { MessageBox.Show("Invalid date!"); }
        }
        private void dgrBookingByID(int rID)
        {
            dgrBooking.ItemsSource = null;
            bookDetail = bookingService.getReservebyID(rID);
            dgrBooking.ItemsSource = bookDetail;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btSearchName_Click(object sender, RoutedEventArgs e)
        {
            string name = inpSearchRsv.Text;
            var detailList = bookingService.getReservebyName(name);
            if (detailList != null) { 
                dgrBooking.ItemsSource = null;
                dgrBooking.ItemsSource = detailList;
            }
        }
    }
}
