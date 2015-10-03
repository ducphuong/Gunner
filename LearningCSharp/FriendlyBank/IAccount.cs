using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
    public interface IAccount
    {
        void payInFunds(decimal amount);
        bool withdrawFunds(decimal amount);
        decimal getBalance();
    }
}