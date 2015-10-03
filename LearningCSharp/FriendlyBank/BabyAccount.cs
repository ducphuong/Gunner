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
        private static decimal minIncome;
        private static int minAge;

        private static decimal interestRateCharged;//by saying static
        // interestratecharged is a part of the class (not an instance of the class)
        // it is therefore shared by all instances
        private decimal balance = 0;
        private string name;
        private string address;

        //constructor
        public BabyAccount(string aName, string aAddress, decimal aBalance)
        {
            name = aName;
            address = aAddress;
            balance = aBalance;
            //Console.WriteLine("a new account is created!");
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
