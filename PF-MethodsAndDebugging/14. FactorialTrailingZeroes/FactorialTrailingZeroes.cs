using System;
using System.Numerics;

namespace _13.Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger zerosInFactorial = Factorial(n);
            BigInteger num = 0;
            int counter = 0;
            for (int i = 0; i <= zerosInFactorial; i++)
            {
                counter++;
                num = num + (zerosInFactorial % 10);
                zerosInFactorial = zerosInFactorial / 10;
                if (num != 0)
                {
                    break;
                }
            }
            Console.WriteLine(counter - 1);
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

