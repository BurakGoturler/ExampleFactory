using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevFactory
{
    public class IPhone : IPhoneFactory
    {
        public void Memory(int gb)
        {
            Console.WriteLine($"IPhone marka telefon {gb}gb belleğe sahip.");
        }
    }
}
