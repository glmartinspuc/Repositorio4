using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c___1__exc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, p, a, d;

            Console.WriteLine("Digite o valor do lado do quadrado: ");
            l = int.Parse(Console.ReadLine());

            p = 4 * l;
            a = (int)Math.Pow(l, 2);
            d = l * (int)Math.Sqrt(2);

            Console.WriteLine("O valor do perímetro do quadrado é: " + p);
            Console.WriteLine("O valor da área é: " + a);
            Console.WriteLine("O valor da diagonal é: " + d);
            Console.ReadKey();

        }
    }
}
