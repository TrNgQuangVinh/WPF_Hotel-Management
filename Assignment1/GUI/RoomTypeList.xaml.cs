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
    /// Interaction logic for RoomTypeList.xaml
    /// </summary>
    public partial class RoomTypeList : Window
    {
        List<RoomType> roomType = new List<RoomType>();
        public RoomTypeList()
        {
            InitializeComponent();
            roomType = AdminScreen.hotelService.getRoomType();
            Loaded += dgrRoomType_Loaded;
        }

        private void dgrRoomType_Loaded(object sender, RoutedEventArgs e)
        {
            //binding on datagrid
            dgrRoomType.ItemsSource = roomType;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
