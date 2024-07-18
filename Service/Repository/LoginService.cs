using Assignment1.BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment1.Repository
{
    public class LoginService
    {
        private LoginRepo _loginRepo = new LoginRepo();
        public string Login(string email, string password)
        {
            return _loginRepo.Login(email, password);
        }

        public Customer getAccountDetails(string globalData)
        {
            return _loginRepo.getAccountDetails(globalData);
        }
    }
}
