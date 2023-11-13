using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaIspitZadatak6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan cijeli broj: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite decimalan broj: ");
            double b = Convert.ToDouble(Console.ReadLine());
            int x = a * 2;
            double y = b * 2;
            Console.WriteLine("dvostruki prvi broj je: " + x);
            Console.WriteLine("dvostruki drugi broj je: " + y);
            Console.ReadKey();

        }
    }
}
