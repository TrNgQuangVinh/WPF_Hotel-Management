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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class HotelDetail : Window
    {
        private static readonly string ADD = "Add";
        private static readonly string UPDATE = "Update";
        //HotelService hotelService = new HotelService();
        public HotelDetail(RoomInformation? room, string action)
        {
            InitializeComponent();
            Loaded += cboRoomType_Loaded;
            rdbtVacant.IsChecked = true;
            //inpRoomID.Text = hotelService.getRoomId();
            inpRoomID.Text = "";
            hiddenAction.Text = action;
            if(room != null ) { loadData(room); }
        }
        private void loadData(RoomInformation room) 
        {
            inpRoomID.Text = room.RoomId.ToString();
            inpRoomNum.Text = room.RoomNumber;
            inpRoomDesc.Text = room.RoomDetailDescription;
            inpRoomCap.Text = room.RoomMaxCapacity.ToString();
            inpRoomPrice.Text = room.RoomPricePerDay.ToString();
            if(room.RoomStatus == 1) rdbtVacant.IsChecked = true;
            else rdbtOccupied.IsChecked = true;
            cboRoomType.SelectedValue = room.RoomTypeId;
        }
        private void cboRoomType_Loaded(object sender, RoutedEventArgs e)
        {
            List<RoomType> list = AdminScreen.hotelService.getRoomType();
            cboRoomType.ItemsSource = list;
            cboRoomType.DisplayMemberPath = "RoomTypeName";
            cboRoomType.SelectedValuePath = "RoomTypeId";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            RoomInformation room = new RoomInformation();
            if (ADD.Equals(hiddenAction.Text))
            {
                //room.RoomId = int.Parse(inpRoomID.Text);
                room.RoomNumber = inpRoomNum.Text;
                room.RoomDetailDescription = inpRoomDesc.Text;
                room.RoomMaxCapacity = int.Parse(inpRoomCap.Text);
                room.RoomPricePerDay = decimal.Parse(inpRoomPrice.Text);
                RoomType selectedType = (RoomType)cboRoomType.SelectedItem;
                room.RoomTypeId = selectedType.RoomTypeId;
                //room.RoomType.RoomTypeId = selectedType.RoomTypeId;
                //room.RoomType = selectedType;
                if (rdbtVacant.IsChecked == true)
                {
                    room.RoomStatus = 1;
                }
                else if (rdbtOccupied.IsChecked == true)
                {
                    room.RoomStatus = 0;
                }
                bool check = AdminScreen.hotelService.addRoom(room);
                if (check) { Close(); }
                else { MessageBox.Show("Error"); }
            }
            else if (UPDATE.Equals(hiddenAction.Text))
            {
                int idCheck = int.Parse(inpRoomID.Text);
                room.RoomId = int.Parse(inpRoomID.Text);
                room.RoomNumber = inpRoomNum.Text;
                room.RoomDetailDescription = inpRoomDesc.Text;
                room.RoomMaxCapacity = int.Parse(inpRoomCap.Text);
                room.RoomPricePerDay = decimal.Parse(inpRoomPrice.Text);
                RoomType selectedType = (RoomType)cboRoomType.SelectedItem;
                room.RoomTypeId = selectedType.RoomTypeId;
                //room.RoomType.RoomTypeId = selectedType.RoomTypeId;
                //room.RoomType = selectedType;
                if (rdbtVacant.IsChecked == true)
                {
                    room.RoomStatus = 1;
                }
                else if (rdbtOccupied.IsChecked == true)
                {
                    room.RoomStatus = 0;
                }
                bool check = AdminScreen.hotelService.updateRoom(room,idCheck);
                if (check) { Close(); }
                else { MessageBox.Show("Error"); }
            }  
        }
    }
}
