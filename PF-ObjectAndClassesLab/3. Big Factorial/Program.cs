using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = 1;
            BigInteger b = 0;
            do
            {
                fact = fact * n;
                n--;
            } while (n > 1);
            Console.WriteLine(fact);
        }
    }
}
