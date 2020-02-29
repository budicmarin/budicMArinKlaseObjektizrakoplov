using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMArinKlaseObjektizrakoplov
{
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();
            x380.Naziv = "Airbus";
            x380.SnagaMotora="2000kW";
            x380.DosegLeta = "6000km";
            Console.WriteLine(x380.ToString);
            Console.ReadKey();
        }
    }
}
