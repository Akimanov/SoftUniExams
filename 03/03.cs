using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mesec = Console.ReadLine().ToLower();
            int broiNoshtuvki = int.Parse(Console.ReadLine());
            decimal CenaStudio = 0;
            decimal CenaApartament = 0;

            if (Mesec == "may")
            {
                if ( broiNoshtuvki > 7 && broiNoshtuvki <= 14)
                {
                    CenaStudio = broiNoshtuvki * 50 - (broiNoshtuvki * 50 * 0.05m);
                    CenaApartament = broiNoshtuvki * 65;
                }
                else if (broiNoshtuvki > 14)
                {
                    CenaStudio = broiNoshtuvki * 50 - (broiNoshtuvki * 50 * 0.3m);
                    CenaApartament = broiNoshtuvki * 65 - (broiNoshtuvki * 65 * 0.1m);
                }
                else
                {
                    CenaStudio = broiNoshtuvki * 50;
                    CenaApartament = broiNoshtuvki * 65;
                }
                
            }
            else if (Mesec == "june")
            {
                 if (broiNoshtuvki > 14)
                {
                    CenaStudio = broiNoshtuvki * 75.20m - (broiNoshtuvki * 75.20m * 0.2m);//
                    CenaApartament = broiNoshtuvki * 68.70m - (broiNoshtuvki * 68.70m * 0.1m);
                }
                else
                {
                    CenaStudio = broiNoshtuvki * 75.20m;
                    CenaApartament = broiNoshtuvki * 68.70m;
                }
              
            }
            else if (Mesec == "july")
            {
                if (broiNoshtuvki > 14)
                {
                    CenaStudio = 76m * broiNoshtuvki;
                    CenaApartament = broiNoshtuvki * 77m - (broiNoshtuvki * 77m * 0.1m);
                }
                else
                {
                    CenaStudio = 76m * broiNoshtuvki;
                    CenaApartament = broiNoshtuvki * 77m;
                }

            }
            else if (Mesec == "august")
            {
                if (broiNoshtuvki > 14)
                {
                    CenaStudio = broiNoshtuvki * 76m;
                    CenaApartament = broiNoshtuvki * 77m - (broiNoshtuvki * 77m * 0.1m);
                }
                else
                {
                    CenaStudio = broiNoshtuvki * 76m;
                    CenaApartament = broiNoshtuvki * 77m;
                }
            }
            else if (Mesec == "september")
            {
                if (broiNoshtuvki > 14)
                {
                    CenaStudio = broiNoshtuvki * 75.20m - (broiNoshtuvki * 75.20m * 0.2m);//
                    CenaApartament = broiNoshtuvki * 68.70m - (broiNoshtuvki * 68.70m * 0.1m);
                }
                else
                {
                    CenaStudio = broiNoshtuvki * 75.20m;
                    CenaApartament = broiNoshtuvki * 68.70m;
                }
            }
            else if (Mesec == "october")
            {
                if (broiNoshtuvki > 7 && broiNoshtuvki <= 14)
                {
                    CenaStudio = broiNoshtuvki * 50 - (broiNoshtuvki * 50 * 0.05m);
                    CenaApartament = broiNoshtuvki * 65;
                }
               else if (broiNoshtuvki > 14)
                {
                    CenaStudio = broiNoshtuvki * 50 - (broiNoshtuvki * 50 * 0.3m);
                    CenaApartament = broiNoshtuvki * 65 - (broiNoshtuvki * 65 * 0.1m);
                }
                else
                {
                    CenaStudio = broiNoshtuvki * 50 ;
                    CenaApartament = broiNoshtuvki * 65;
                }



            }
           
            Console.WriteLine("Apartment: {0:f2} lv.",CenaApartament);
            Console.WriteLine("Studio: {0:f2} lv.", CenaStudio);

        }
    }
}
