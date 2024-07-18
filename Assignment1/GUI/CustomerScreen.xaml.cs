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
using Xceed.Wpf.Toolkit.Converters;

namespace Assignment1.GUI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CustomerScreen : Window
    {
        public string globalData;
        public CustomerScreen(string data1, string data2)
        {
            InitializeComponent();
            Loaded += txbWelcome_Loaded;
            hiddenField.Text = data1;
            globalData = data2;
        }

        private void txbWelcome_Loaded(object sender, RoutedEventArgs e)
        {
            txbWelcome.Text = $"Welcome {hiddenField.Text}!";
        }

        private void btnBooking_Click(object sender, RoutedEventArgs e)
        {
            BookingInterface booking = new BookingInterface(globalData);
            this.Hide();
            booking.ShowDialog();
            this.ShowDialog();
        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            Customer account = new Customer();
            account = Login.loginService.getAccountDetails(globalData);
            AccountDetail accDet = new AccountDetail(account,"");
            accDet.ShowDialog();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnTestID_Click(object sender, RoutedEventArgs e)
        {
            BookingService bookingService = new BookingService();
            MessageBox.Show(bookingService.getReserveId().ToString());
        }
    }
}
