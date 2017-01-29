using System;
using System.Linq;

namespace _12.MasterNumber
{
    public class MasterNumber
    {
        public static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (isPalindrome(i) && SumOfDigit(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }


        }
        static bool isPalindrome(long num)
        {
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length; i++)

                if (sNum[i] != sNum[sNum.Length - 1 - i]) return false;
            return true;
        }
        static bool SumOfDigit(long num)
        {
            long sum = 0;
            while (num > 0)
            {
                sum = sum + (num % 10);
                num = num / 10;
            }
            if (sum % 7 == 0)
            {
                return true; ;
            }
            else
            {
                return false;
            }



        }
        static bool ContainsEvenDigit(long num)
        {
            string n = num.ToString();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
