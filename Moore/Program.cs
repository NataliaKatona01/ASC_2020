using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n=");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Numarul trebuie sa fie intreg", e.Message);
                return;
            }
            double luni;
            luni = (Math.Log(n, 2) * 18);
            double ani = luni / 12;
            Console.WriteLine("in aproximativ " + Math.Round(ani) + "ani" + "(" + Math.Round(luni) + " luni)" + "puterea va fi de " + n + " ori mai mare");
            Console.WriteLine("[" + ani + " ani " + "(" + luni + " luni)]");
            _ = Console.ReadKey();

        }
    }
}
