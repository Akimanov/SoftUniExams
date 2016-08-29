using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int RabotniDniMesec = int.Parse(Console.ReadLine());
            decimal SpecheleniPariDen = decimal.Parse(Console.ReadLine());
            decimal KursDolar = decimal.Parse(Console.ReadLine());

            var mesecZaplata = SpecheleniPariDen * RabotniDniMesec;
            var GodishnaZaplata =(decimal) mesecZaplata * 12m + (mesecZaplata * 2.5m);
            var danyk = GodishnaZaplata / 100 * 25;
            var ChistGodDohod = (GodishnaZaplata - danyk) * KursDolar;
            decimal SrPechalbaDen = ChistGodDohod / 365m;

            Console.WriteLine("{0:f2}",SrPechalbaDen);


        }
    }
}
