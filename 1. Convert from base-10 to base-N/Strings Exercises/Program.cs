using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Strings_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var baseN = BigInteger.Parse(input[0]);
            var baseTen = BigInteger.Parse(input[1]);

            BigInteger remainder;
            string result = string.Empty;
            while (baseTen > 0)
            {
                remainder = baseTen % baseN;
                baseTen /= baseN;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("{0}", result);
        }
    }
}
