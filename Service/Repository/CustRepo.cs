using Assignment1.BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository
{
    public class CustRepo
    {
        private FuminiHotelManagementContext myHotel = new FuminiHotelManagementContext();
        public bool deleteCustomer(Customer cust)
        {
            if (cust != null)
            {
                var custInfo = myHotel.Customers
                               .FirstOrDefault(c => c.CustomerId == cust.CustomerId);
                try
                {
                    myHotel.Customers.Remove(cust);
                    myHotel.SaveChanges();
                    return true;
                }
                catch (Exception e) { return false; }
            }
            return false;
        }

        public List<Customer> getCustSearch(string name, string email)
        {
            List<Customer> list = new List<Customer>();
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(email))
            {
                return getCustomers();
            }
            else if (string.IsNullOrWhiteSpace(email))
            {
                var cust = from c in myHotel.Customers
                           where c.CustomerFullName.Contains(name)
                           select c;
                foreach (var c in cust)
                {
                    list.Add(c);
                }
            }
            else if (string.IsNullOrWhiteSpace(name))
            {
                var cust = from c in myHotel.Customers
                           where c.EmailAddress.Contains(email)
                           select c;
                foreach (var c in cust)
                {
                    list.Add(c);
                }
            }
            else
            {
                var cust = from c in myHotel.Customers
                           where c.EmailAddress.Contains(email) &&
                           c.CustomerFullName.Contains(name)
                           select c;
                foreach (var c in cust)
                {
                    list.Add(c);
                }
            }
            return list;
        }

        public List<Customer> getCustomers()
        {
            return myHotel.Customers.ToList();
        }

        public bool updateAccount(Customer customer)
        {
            if (customer != null)
            {
                var cust = myHotel.Customers
                               .FirstOrDefault(i => i.CustomerId == customer.CustomerId);
                if (cust != null)
                {
                    try
                    {
                        myHotel.Entry(cust).CurrentValues.SetValues(customer);
                        myHotel.Customers.Update(cust);
                        myHotel.SaveChanges();
                        return true;
                    }
                    catch { }
                }
                return false;
            }
            return false;
        }

        public bool addAccount(Customer customer)
        {
            if (customer != null)
            {
                myHotel.Customers.Add(customer);
                myHotel.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
