using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Proxy
{
    interface IBankAccount
    {
        decimal GetBalance();
        void Deposit(decimal val);
        void Withdraw(decimal val);
    }
}
