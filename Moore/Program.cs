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
            Console.WriteLine("Amplificarea puterii");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Numarul trebuie sa fie intreg", e.Message);
                return;
            }
            double rezultatluni;
            rezultatluni = (Math.Log(n, 2) * 18);
            double rezultatani = rezultatluni / 12;
            Console.WriteLine("in aproximativ " + Math.Round(rezultatani) + "ani" + "(" + Math.Round(rezultatluni) + "luni)" + "puterea va fi de " + n + "ori mai mare");
            Console.WriteLine("[" + rezultatani + " ani" + "(" + rezultatluni + "luni)]");
            _ = Console.ReadKey();

        }
    }
}
