using Assignment1.BusinessObj;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository
{
    public class LoginRepo
    {
        private FuminiHotelManagementContext myHotel = new FuminiHotelManagementContext();
        public string Login(string email, string password)
        {
            if (!email.IsNullOrEmpty() && !password.IsNullOrEmpty())
            {
                var users = from u in myHotel.Customers
                            select new { u.EmailAddress, u.Password, u.CustomerFullName, u.CustomerId };
                string defaultEmail = FuminiHotelManagementContext.email;
                string defaultPassword = FuminiHotelManagementContext.pwd;
                if (email.Equals(defaultEmail) && password.Equals(defaultPassword))
                {
                    return "Admin;AD;0";
                }
                else
                {
                    foreach (var u in users)
                    {
                        if (u.EmailAddress == email && u.Password == password)
                        {
                            return u.CustomerFullName + ";US;" + u.CustomerId;
                        }
                    }
                }
            }
            return "No user found!";
        }

        public Customer getAccountDetails(string globalData)
        {
            Customer customer = new Customer();
            var user = from u in myHotel.Customers
                       where u.CustomerId == int.Parse(globalData)
                       select u;
            foreach (var u in user) customer = u;
            return customer;
        }
    }
}
