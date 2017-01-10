using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Number A?");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Wrong number");
            }

            Console.WriteLine("Number B?");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Wrong number");
            }

            Console.WriteLine("Number C?");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Wrong number");
            }
            Console.WriteLine();

            
            if (a == b && b == c)
                Console.WriteLine("No Maximum");
            else
            {
                int maxN;

                if (a > b)
                    maxN = a;
                else maxN = b;

                if (c > maxN)
                    maxN = c;

                Console.WriteLine("Maximum number {0}", maxN);
            }
            Console.ReadKey(true);
        }
    }
}
