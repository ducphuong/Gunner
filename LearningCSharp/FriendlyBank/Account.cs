using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
    public abstract class Account
    {
        public abstract string printWarning();
        public override abstract string ToString(); // override keyword: means we are (allowing) to override the same fct from "object".
        public abstract override bool Equals(object obj);// override Equals to do the comparison
    }
}
