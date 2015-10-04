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

        public string Name //Name as a interface (declared from IAccount to be implemented here)
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Address //Name as a interface (declared from IAccount to be implemented here)
        {
            get
            {
                return address;
            }
            set
            {
                this.address = value;
            }
        }

        public decimal Balance //Name as a interface (declared from IAccount to be implemented here)
        {
            get
            {
                return balance;
            }
            set
            {
                this.balance = value;
            }
        }

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


        public override string printWarning() //override
        {
            return "it is a warning message to " + name;
        }

        public override string ToString()
        {
            return " Name: " + name + " balance :" + balance;
            //throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            CustomerAccount vCAccount = (CustomerAccount) obj;
            if ((vCAccount.name == name)&& (vCAccount.address == address) && (vCAccount.balance == balance))
            {
                return true;
            }
            else
                return false;
            //throw new NotImplementedException();
        }
    }
}
