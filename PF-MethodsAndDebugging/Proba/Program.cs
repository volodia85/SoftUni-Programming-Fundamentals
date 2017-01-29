using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());

            List<long> primes = new List<long>();
            for (long i = start; i <= end; i++)
            {
                if (PrimeCheck(i))
                {
                    primes.Add(i);
                }
            }
            bool isPrime = PrimeCheck(start);
            Console.WriteLine("{0}",string.Join(", ",primes));


        }
        static bool PrimeCheck(long n)
        {
            for (int i = 1; i <= Math.Sqrt(n) + 1; i++)
            {
                if (n == 0 || n == 1)
                {
                    return false;
                }
                if (n % i == 0)
                {
                    if (i == n)
                    {
                        return true;
                    }
                    else if (i == 1)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                        break;
                    }
                }
            }

            return true;
        }   
    }
}