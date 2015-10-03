using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
    public class CustomerAccount: Account, IAccount //implement the interface
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
        //create a parameterless constructor (to help the constructor this class' children)
        public CustomerAccount()
        {
        }

        public CustomerAccount(string aName, string aAddress, decimal aBalance)
        {
            name = aName;
            address = aAddress;
            balance = aBalance;
            //Console.WriteLine("a new account is created!");
        }

        public CustomerAccount(string aName, string aAddress)
            : this(aName, aAddress, 0)
        {
        }

        public CustomerAccount(string aName)
            : this(aName, "void", 0)
        {
        }
        /*************************************************/
        public virtual bool withdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance -= amount;
            return true;
        }

        public void payInFunds(decimal amount)
        {
            balance += amount;
        }

        public decimal getBalance()
        {
            return balance;
        }

        public static bool accountAllowed(decimal income, int age)
        {
            if (income >= minIncome && age >= minAge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        public string printWarning()
        {
            return "it is a warning message";
        }
         * */
        /*
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdraft;
        */
    }
}
