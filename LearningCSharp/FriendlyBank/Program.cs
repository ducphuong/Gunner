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

        enum AccountState
        {
            New,
            Active,
            UnderAudit,
            Frozen,
            Closed
        };
        
        
        static void Main(string[] args)
        {
            IAccount  [] accounts = new IAccount[MAX_CUST];
            accounts[0] = new CustomerAccount("Phuong");
            accounts[0].payInFunds(100);
            Console.WriteLine("Balance "+ accounts[0].getBalance());

            accounts[1] = new BabyAccount("KKY","Nanterre");
            accounts[1].payInFunds(20);
            accounts[1].withdrawFunds(9);
            //Console.WriteLine(accounts[0].printWarning());
            string d = Console.ReadLine();
        }
    }
}
