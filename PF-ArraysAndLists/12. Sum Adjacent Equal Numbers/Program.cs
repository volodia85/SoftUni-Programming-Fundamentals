using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = new List<double>(Console.ReadLine().Split().Select(double.Parse).ToList());

            
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i - 1] == input[i])
                {
                    input[i - 1] += input[i];

                    input.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
