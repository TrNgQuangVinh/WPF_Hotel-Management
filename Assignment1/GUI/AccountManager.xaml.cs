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
    public partial class AccountManager : Window
    {
        List<Customer> custInfo = new List<Customer>();
        public static CustService custService = new CustService();
        public AccountManager()
        {
            InitializeComponent();
            inpSearchName.Text = null;
            inpSearchEmail.Text = null;
            Loaded += dgrCustInfo_Loaded;
        }

        private void dgrCustInfo_Loaded(object sender, RoutedEventArgs e)
        {
            //binding on datagrid
            dgrCustInfo.ItemsSource = null;
            custInfo = custService.getAllCustomers();
            dgrCustInfo.ItemsSource = custInfo;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (inpSearchName.Text.IsNullOrEmpty() == false || inpSearchEmail.Text.IsNullOrEmpty() == false)
            {
                dgrCustInfo.ItemsSource = null;
                dgrCustInfo.ItemsSource = custService.getCustByCol(inpSearchName.Text, inpSearchEmail.Text);
            }
            else
            {
                dgrCustInfo_Loaded(sender, e);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Customer cust = new Customer();
            AccountDetail accDetail = new AccountDetail(cust, "Add");
            accDetail.ShowDialog();
            this.btnSearch_Click(sender, e);
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dgrCustInfo.SelectedItem == null)
            {
                ErrorLabel.Content = "Please choose an account to update!";
            }
            else
            {
                Customer cust = (Customer)dgrCustInfo.SelectedItem;
                AccountDetail accDetail = new AccountDetail(cust, "Update");
                accDetail.ShowDialog();
                this.btnSearch_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            bool check;
            if (dgrCustInfo.SelectedItem == null)
            {
                ErrorLabel.Content = "Please choose a room to delete!";
            }
            else
            {
                Customer cust = (Customer)dgrCustInfo.SelectedItem;
                var result = System.Windows.MessageBox.Show("Are you sure you want to delete this entry?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    check = custService.deleteCustomer(cust);
                    if(check) 
                    {
                        dgrCustInfo_Loaded(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Some error has occurred!");
                        dgrCustInfo_Loaded(sender, e);
                    }
                    

                }
                else if (result == MessageBoxResult.No)
                {

                }
            }
        }
    }
}
