using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainFactory factory = new IstanbulPhoneFactory();

            IPhoneFactory samsung1 = factory.GetPhone("samsung");
            IPhoneFactory iphone1 = factory.GetPhone("iphone");
            IPhoneFactory htc1 = factory.GetPhone("htc");

            samsung1.Memory(4);
            iphone1.Memory(6);
            htc1.Memory(8);

            Console.Read();
        }
    }
}
