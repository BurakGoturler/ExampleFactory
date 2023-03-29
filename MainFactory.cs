using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevFactory
{
    public abstract class MainFactory
    {
        public abstract IPhoneFactory GetPhone(string type);
    }
}
