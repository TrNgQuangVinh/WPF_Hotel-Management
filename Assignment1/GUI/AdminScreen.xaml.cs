using Assignment1.BusinessObj;
using Assignment1.Repository;
using Microsoft.IdentityModel.Tokens;
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
    /// Interaction logic for CustomerScreen.xaml
    /// </summary>
    public partial class AdminScreen : Window
    {
        List<RoomInformation> roomInfo = new List<RoomInformation>();
        public static HotelService hotelService = new HotelService();
        public AdminScreen()
        {
            InitializeComponent();
            inpSearchType.Text = null;
            inpSearchPrice.Text = null;
            Loaded += dgrRoomInfo_Loaded;
        }

        private void dgrRoomInfo_Loaded(object sender, RoutedEventArgs e)
        {
            //binding on datagrid
            dgrRoomInfo.ItemsSource = null;
            roomInfo = hotelService.getAllRooms();
            dgrRoomInfo.ItemsSource = roomInfo;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (inpSearchType.Text.IsNullOrEmpty() == false || inpSearchPrice.Text.IsNullOrEmpty() == false)
            {
                dgrRoomInfo.ItemsSource = null;
                dgrRoomInfo.ItemsSource = hotelService.getRoomByCol(inpSearchType.Text, inpSearchPrice.Text);
            }
            else
            {
                dgrRoomInfo_Loaded(sender, e);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            RoomInformation room = new RoomInformation();
            HotelDetail hotelDetail = new HotelDetail(room, "Add");
            hotelDetail.ShowDialog();
            this.btnSearch_Click(sender, e);
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dgrRoomInfo.SelectedItem == null)
            {
                ErrorLabel.Content = "Please choose a room to update!";
            }
            else
            {
                RoomInformation room = (RoomInformation)dgrRoomInfo.SelectedItem;
                HotelDetail hotelDetail = new HotelDetail(room, "Update");
                hotelDetail.ShowDialog();
                this.btnSearch_Click(sender, e);
            }
        }

        private void inpSearchPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double checkNum = -1;
                Double.TryParse(inpSearchPrice.Text, out checkNum);
                if (checkNum == 0)
                {
                    inpSearchPrice.Clear();
                    ErrorLabel.Content = "Price must be a number!";
                }
            }
            catch (FormatException ex) { }
            {

            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            bool check;
            if (dgrRoomInfo.SelectedItem == null)
            {
                ErrorLabel.Content = "Please choose a room to delete!";
            }
            else
            {
                RoomInformation room = (RoomInformation)dgrRoomInfo.SelectedItem;
                var result = System.Windows.MessageBox.Show("Are you sure you want to delete this entry?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    check = hotelService.deleteRoom(room);
                    if(check) 
                    {
                        dgrRoomInfo_Loaded(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Some error has occurred!");
                        dgrRoomInfo_Loaded(sender, e);
                    }
                    

                }
                else if (result == MessageBoxResult.No)
                {

                }
            }
        }

        private void btnTypeList_Click(object sender, RoutedEventArgs e)
        {
            RoomTypeList roomTypeList = new RoomTypeList();
            roomTypeList.Show();
        }
    }
}
