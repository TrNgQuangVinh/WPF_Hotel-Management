using Assignment1.BusinessObj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository
{
    public class CustService
    {
        private CustRepo _custRepo = new CustRepo();

        public bool addAccount(Customer customer)
        {
            return _custRepo.addAccount(customer);
        }

        public bool deleteCustomer(Customer cust)
        {
            return _custRepo.deleteCustomer(cust);
        }

        public List<Customer> getAllCustomers()
        {
            return _custRepo.getCustomers();
        }

        public List<Customer> getCustByCol(string name, string email)
        {
            return _custRepo.getCustSearch(name, email);
        }
        public bool updateAccount(Customer customer)
        {
            return _custRepo.updateAccount(customer);
        }
    }
}
