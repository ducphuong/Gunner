using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FriendlyBank
{
    class SGBank: IBank
    {
        //private IAccount[] accounts; // the array to contain all the bank accounts of this bank

        private Hashtable bankHashtable; // the bank use a hash table to hold all bank account

        public SGBank()
        {
            bankHashtable = new Hashtable();
        }

        public IAccount findAccountHT(string name)
        {
            return bankHashtable[name] as IAccount; // using as ... to return as a reference to an object of type IAccount
        }

        
        public bool storeAccountHT(IAccount aAccount)
        {
            bankHashtable.Add(aAccount.Name,aAccount);
            return true;
        }


        /*
        public SGBank(int banksize)
        {
            accounts = new IAccount[banksize];
        }
        */
        /*
        public IAccount findAccount(string aname)
        {
            foreach (IAccount vIt in accounts)
            {
                if (vIt.Name == aname)
                    return vIt;
                else
                    continue;
            }
            return null;
        }
        */
        /*
        public bool storeAccount(IAccount aAccount)
        {
            for (int i = 0; i < accounts.Length;++i )
            {
                if (accounts[i] == null)
                {
                    accounts[i] = aAccount;
                    return true;
                }
            }
            return false;
        }
        */
    }
}
