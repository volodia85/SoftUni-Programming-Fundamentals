using System;
using System.Numerics;

namespace _13.Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            
            Console.WriteLine(Factorial(n));
        }
        static BigInteger Factorial(BigInteger n)
        {
            BigInteger fact = 1;
            BigInteger b = 0;
            do
            {
                fact = fact * n;
                n--;
            } while (n > 1);
            return fact;
        }
    }
}
