using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int neobhodimiChasove = int.Parse(Console.ReadLine());
            int RazpolagashtiDni = int.Parse(Console.ReadLine());
            int BroiSlujiteliIzvynredno = int.Parse(Console.ReadLine());

            double ChasoveRabota =((double) RazpolagashtiDni - (RazpolagashtiDni / 100d * 10.0d)) * 8;
            double ObshtoIzvRabota = (BroiSlujiteliIzvynredno * RazpolagashtiDni) * 2;
            
            double ObshtoChasove = Math.Truncate(ChasoveRabota + ObshtoIzvRabota);
            double difference =Math.Abs (ObshtoChasove - neobhodimiChasove);
            if (ObshtoChasove < neobhodimiChasove)
            {
                Console.WriteLine("Not enough time!{0} hours needed.",difference);
            }
            else
            {
                Console.WriteLine("Yes!{0} hours left.", difference);
            }

        }
    }
}
