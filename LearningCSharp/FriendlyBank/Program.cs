using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
    class Program
    {
        const int MAX_CUST = 100;

        public delegate decimal CalculateFee(decimal balance); //CalculateFee is a delegate type

        public static decimal RipOffFee(decimal balance)
        {
            Console.WriteLine("Calling the rip off method!! ");
            if (balance < 0)
                return 100; //if your account is negative than charge you really high!
            else
                return 1; //normal fee
        }

        public static decimal FriendlyFee(decimal balance)
        {
            Console.WriteLine("Calling friendly method");
            if (balance < 0)
                return 5;
            else
                return 1;
        }

        static void Main(string[] args)
        {
            IAccount  [] accounts = new IAccount[MAX_CUST];
            accounts[0] = new CustomerAccount("Phuong");
            accounts[0].payInFunds(100);
            Console.WriteLine("Balance "+ accounts[0].Balance);

            accounts[1] = new BabyAccount("KKY","Nanterre");
            accounts[1].payInFunds(20);
            accounts[1].withdrawFunds(9);
            accounts[1].Name = "KKYPhuong";
            Console.WriteLine(accounts[0].printWarning());
            Console.WriteLine(accounts[0].ToString());
            Console.WriteLine(accounts[1].ToString());
            Console.WriteLine(accounts[0].Equals(accounts[1]));
            Console.WriteLine(accounts[1].Equals(accounts[0]));

            //Delegate
            CalculateFee calc; //declare an instance of delegate
            calc = new CalculateFee(RipOffFee); // map/call the ripofffee method
            calc(-1);     //execute the method

            calc = new CalculateFee(FriendlyFee);
            calc(-1);

            //Bank

            SGBank myBank = new SGBank();
            myBank.storeAccountHT(accounts[0]);
            myBank.storeAccountHT(accounts[1]);
            IAccount found = myBank.findAccountHT("Phuong");
            Console.WriteLine(found.ToString());
            string d = Console.ReadLine();
        }
    }
}
