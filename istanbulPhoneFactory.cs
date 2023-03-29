using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevFactory
{
    public class IstanbulPhoneFactory : MainFactory
    {
        public override IPhoneFactory GetPhone(string type)
        {
            switch (type)
            {
                case "Samsung":
                case "samsung":
                    return new Samsung();

                case "Iphone":
                case "iphone":
                    return new IPhone();

                case "Htc":
                case "htc":
                    return new HTC();

                default: return null;
            }
        }
    }
}
