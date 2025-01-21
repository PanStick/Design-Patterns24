using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Proxy
{
    internal class ProxyBankAccount
    {
        RealBankAccount _realAccount;
        bool _userAuthenticated;

        public ProxyBankAccount(RealBankAccount realAccount)
        {
            _realAccount = realAccount;
            _userAuthenticated = false;
        }
        bool CheckAuthentication()
        {
            if (_userAuthenticated)
                return true;
            throw new Exception("User not authenticated");
        }

        public decimal GetBalance()
        {
            if(CheckAuthentication())
                return _realAccount.GetBalance();
            return -1;
        }

        public void Deposit(decimal amount)
        {
            if(CheckAuthentication())
                _realAccount.Deposit(amount);
        }

        public void Withdraw(decimal amount) {
            CheckAuthentication();
            if (_realAccount.GetBalance() > amount)
                _realAccount.Withdraw(amount);
            else throw new Exception("Balance too small to withdraw");
        }

        public void AuthenticateUser() { _userAuthenticated = true; }
    }
}
