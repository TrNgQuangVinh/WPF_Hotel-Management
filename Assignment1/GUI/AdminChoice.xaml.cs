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
    /// Interaction logic for AdminChoice.xaml
    /// </summary>
    public partial class AdminChoice : Window
    {
        public AdminChoice()
        {
            InitializeComponent();
        }

        private void btnRoomView_Click_1(object sender, RoutedEventArgs e)
        {
            AdminScreen admScr = new AdminScreen();
            this.Hide();
            admScr.ShowDialog();
            this.Show();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountManager accMng = new AccountManager();
            this.Hide();
            accMng.ShowDialog();
            this.Show();
        }
    }
}
