using System;


namespace PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime = PrimeCheck(n);
            Console.WriteLine(isPrime);
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
