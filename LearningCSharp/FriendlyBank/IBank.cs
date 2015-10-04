using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
    public interface IBank
    {
        IAccount findAccountHT(string name);
        bool storeAccountHT(IAccount aAccount);
    }
}
