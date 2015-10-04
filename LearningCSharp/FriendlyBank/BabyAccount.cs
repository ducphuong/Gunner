using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
    //as a sealed class: no ther class can extend from BabyAccount
    public sealed class BabyAccount:CustomerAccount, IAccount
    {
        //constructor
        public BabyAccount(string aName, string aAddress, decimal aBalance)
            : base(aName,aAddress,aBalance)
        {
        }

        public BabyAccount(string aName, string aAddress)
            : base(aName,aAddress)
        {
        }

        public BabyAccount(string aName)
            : base(aName)
        {
        }
        /*************************************************/
        public override bool withdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
            return base.withdrawFunds(amount);
        }
        
    }
}
