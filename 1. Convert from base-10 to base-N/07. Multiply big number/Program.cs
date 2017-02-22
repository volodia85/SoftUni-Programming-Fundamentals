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
            string input = Console.ReadLine();
            int multiply = int.Parse(Console.ReadLine());
            input = input.PadLeft(input.Length + 2, '0');
            int[] arr = input.Select(x => int.Parse(x.ToString())).ToArray();
            int[] sum = new int[arr.Length];
            int carry = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int total = arr[i] * multiply + carry;
                sum[i] = total % 10;
                if (total > 9) carry = total / 10;
                else carry = 0;
            }
            Console.WriteLine(string.Join("", sum.SkipWhile(x => x == 0)));

        }

    }
}
