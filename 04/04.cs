using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            var doctors = 7;
            var pregledaniNaDen = 0;
            var nePregledaniNaDen = 0;
            var pregledani = 0;
            var nepregledani = 0;

            for (int i = 1; i <= dni; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                //if (i % 3 == 0 && nepregledani > pregledani)
                //{
                //    doctors = ++;
                //}
                //else if (i % 3 == 0 && nepregledani < pregledani)
                //{
                //    doctors = 7;
                //}
                if (i % 3 == 0)
                {
                    doctors = pregledani < nepregledani ? 8 : 7;
                }
                


                if (patients > doctors)
                {
                    pregledaniNaDen = doctors;
                    nePregledaniNaDen = patients - doctors;
                    pregledani += pregledaniNaDen;
                    nepregledani += nePregledaniNaDen;
                }
                else
                {
                    pregledaniNaDen =  patients;
                    nePregledaniNaDen = 0;
                    pregledani += pregledaniNaDen;
                    nepregledani += nePregledaniNaDen;
                }
            }
            Console.WriteLine("Treated patients: {0}.", pregledani);
            Console.WriteLine("Untreated patients: {0}.", nepregledani);
        }
    }
}
