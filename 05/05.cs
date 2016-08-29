using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var middleMinus = 0;
            var shirina = 5 * n;
            var endMInus = shirina - n * 3 - 2;

            //------**--
            //------*-*-
            //*******-*-
            //------***-

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', n * 3));
                Console.Write("*");
                Console.Write(new string('-', middleMinus));
                Console.Write("*");
                Console.WriteLine(new string('-', endMInus));
                middleMinus++;
                endMInus--;
            }
            var middleMinusCenter = n - 1;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('*', n * 3));
                Console.Write("*");
                Console.Write(new string('-',middleMinusCenter));
                Console.Write("*");
                Console.WriteLine(new string('-', n-1));
            }

            var bottomminus = n * 3;
            var bottomMinusCenter = n - 1;
            var endminus = n -1 ;
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                Console.Write(new string('-', bottomminus));
                Console.Write("*");
                Console.Write(new string('-', bottomMinusCenter));
                Console.Write("*");
                Console.WriteLine(new string('-', endminus));

                bottomminus--;
                bottomMinusCenter+=2;
                endminus--;
            }
            for (int i = 1; i <= n/n; i++)
            {
                Console.Write(new string('-', bottomminus));
                Console.Write("*");
                Console.Write(new string('*', bottomMinusCenter));
                Console.Write("*");
                Console.WriteLine(new string('-', endminus));

                bottomminus--;
                bottomMinusCenter += 2;
                endminus--;
            }

        }
    }
}
