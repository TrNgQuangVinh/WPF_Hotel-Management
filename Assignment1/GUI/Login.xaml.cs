using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Assignment1.Repository;

namespace Assignment1.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public static LoginService loginService = new LoginService();
        public static string[]? data;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var email = inpEmail.Text;
            var password = inpPassword.Password;
            var checkLogin = loginService.Login(email, password);
            data = checkLogin.Split(';');
            if (data.Length<3)
            {
                MessageBox.Show(checkLogin);
            }
            else if (data[1].Equals("AD"))
            {
                AdminChoice admChs = new AdminChoice();
                Close();
                admChs.ShowDialog();
            }
            else if (data[1].Equals("US"))
            {
                CustomerScreen customerScreen = new CustomerScreen(data[0], data[2]);
                Close();
                customerScreen.ShowDialog();
            }

        }

        private void btnTestConn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DatabaseTest.testConnection());

        }
    }
}