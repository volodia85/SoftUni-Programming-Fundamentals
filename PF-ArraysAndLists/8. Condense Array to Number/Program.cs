using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lenght = num.Length - 1;

            while (num.Length > 1)
            {
                int[] condensed = new int[num.Length - 1];
                for (int i = 0; i < num.Length - 1; i++)
                {
                    condensed[i] = num[i] + num[i + 1];
                }
                num = condensed;
            }

            Console.WriteLine(string.Join(" ", num[0]));

            
        }

    }
}
