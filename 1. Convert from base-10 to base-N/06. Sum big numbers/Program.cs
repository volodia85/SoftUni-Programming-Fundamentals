using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            string input2 = Console.ReadLine().Trim();

            Console.WriteLine(Sum(input, input2));

        }
        public static string Sum(string input, string input2)
        {
            int maxLenght = Math.Max(input.Length, input2.Length);
            input = input.PadLeft(maxLenght + 1, '0');
            input2 = input2.PadLeft(maxLenght + 1, '0');

            int[] arr1 = input.Select(x => int.Parse(x.ToString())).ToArray();
            int[] arr2 = input2.Select(x => int.Parse(x.ToString())).ToArray();

            int[] sum = new int[arr1.Length];
            int carry = 0;

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                int total = arr1[i] + arr2[i] + carry;
                sum[i] = total % 10;
                if (total > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            return string.Join("", sum.SkipWhile(x => x == 0));
            

        }
    }
}
