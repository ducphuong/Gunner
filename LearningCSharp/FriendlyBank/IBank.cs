using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
    public interface IBank
    {
        IAccount findAccount(string name);
        bool storeAccount(IAccount aAccount);
        IAccount findAccountHT(string name); //HT for HashTable
        bool storeAccountHT(IAccount aAccount);
    }
}
