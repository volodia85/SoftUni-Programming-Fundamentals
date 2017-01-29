using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());

            }
            
            Console.WriteLine("Sum = {0}", input.Sum());
            Console.WriteLine("Min = {0}", input.Min());
            Console.WriteLine("Max = {0}", input.Max());
            Console.WriteLine("Average = {0}", input.Average());
        }

    }
}
