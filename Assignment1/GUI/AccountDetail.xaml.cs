using Assignment1.BusinessObj;
using Assignment1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    public partial class AccountDetail : Window
    {
        private static readonly string ADD = "Add";
        private static readonly string UPDATE = "Update";
        Customer customer = new Customer();
        bool visible = false;
        public AccountDetail(Customer account, string action)
        {
            InitializeComponent();
            customer = account;
            hiddenAction.Text = action;
            if (customer != null) { loadData(customer); }
            inpPwdVisible.Visibility = Visibility.Hidden;
        }
        private void loadData(Customer customer) 
        {
            inpCusID.Text = customer.CustomerId.ToString();
            inpPhoneNum.Text = customer.Telephone;
            inpFullName.Text = customer.CustomerFullName;
            inpEmail.Text = customer.EmailAddress;
            dateBirthday.Text = customer.CustomerBirthday.ToString();
            inpPwdVisible.Text = customer.Password;
            pwdBox.Password = customer.Password;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(dateBirthday.SelectedDate <= DateTime.Now 
                && MailAddress.TryCreate(inpEmail.Text,out MailAddress? mail)
                && this.IsPhoneNumber(inpPhoneNum.Text, "0000000000"))
            {
                if(ADD.Equals(hiddenAction.Text))
                {
                    //customer.CustomerId = int.Parse(inpCusID.Text);
                    customer.CustomerFullName = inpFullName.Text;
                    customer.CustomerBirthday = DateOnly.FromDateTime((DateTime)dateBirthday.SelectedDate);
                    customer.EmailAddress = inpEmail.Text;
                    customer.Telephone = inpPhoneNum.Text;
                    customer.Password = pwdBox.Password;
                    customer.CustomerStatus = 1;
                    bool check = AccountManager.custService.addAccount(customer);
                    if (check) { Close(); }
                    else { MessageBox.Show("Error"); }
                }
                else if(UPDATE.Equals(hiddenAction.Text)) 
                {
                    customer.CustomerId = int.Parse(inpCusID.Text);
                    customer.CustomerFullName = inpFullName.Text;
                    customer.CustomerBirthday = DateOnly.FromDateTime((DateTime)dateBirthday.SelectedDate);
                    customer.EmailAddress = inpEmail.Text;
                    customer.Telephone = inpPhoneNum.Text;
                    customer.Password = pwdBox.Password;
                    bool check = AccountManager.custService.updateAccount(customer);
                    if (check) { Close(); }
                    else { MessageBox.Show("Error"); }
                }
                else
                {
                    customer.CustomerId = int.Parse(inpCusID.Text);
                    customer.CustomerFullName = inpFullName.Text;
                    customer.CustomerBirthday = DateOnly.FromDateTime((DateTime)dateBirthday.SelectedDate);
                    customer.EmailAddress = inpEmail.Text;
                    customer.Telephone = inpPhoneNum.Text;
                    customer.Password = pwdBox.Password;
                    bool check = AccountManager.custService.updateAccount(customer);
                    if (check)
                    {
                        MessageBox.Show("Please login again!");
                        Login login = new Login();
                        for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--) 
                        { 
                            App.Current.Windows[intCounter].Close(); 
                        }
                            
                    }
                }
            }
            else { MessageBox.Show("Invalid input!\nMaybe check your email, birthday, phone?"); }
        }

        private void btShowPwd_Click(object sender, RoutedEventArgs e)
        {
            if(visible) 
            {
                inpPwdVisible.Text = pwdBox.Password;
                inpPwdVisible.Visibility = Visibility.Hidden;
                visible = false;
            }
            else
            {
                inpPwdVisible.Text = pwdBox.Password;
                inpPwdVisible.Visibility = Visibility.Visible;
                visible = true;
            }
        }

        private void inpPwdVisible_GotFocus(object sender, RoutedEventArgs e)
        {
            btShowPwd_Click(sender,e);
            pwdBox.Focus();
        }

        bool IsPhoneNumber(string input, string pattern)
        {
            if (input.Length != pattern.Length) return false;

            for (int i = 0; i < input.Length; ++i)
            {
                bool ith_character_ok;
                if (Char.IsDigit(pattern, i))
                    ith_character_ok = Char.IsDigit(input, i);
                else
                    ith_character_ok = (input[i] == pattern[i]);

                if (!ith_character_ok) return false;
            }
            return true;
        }
    }
}
