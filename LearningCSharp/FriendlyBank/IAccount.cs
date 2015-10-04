using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
    public interface IAccount
    {
        string Name //interface to get/sset name a property common from all account
        {
            get;set;
        }

        string Address
        {
            get;set;
        }

        decimal Balance
        {
            get;
            set;
        }
        void payInFunds(decimal amount);
        bool withdrawFunds(decimal amount);
        string printWarning();// create interface for prinWarning function in the abstract class
    }
}