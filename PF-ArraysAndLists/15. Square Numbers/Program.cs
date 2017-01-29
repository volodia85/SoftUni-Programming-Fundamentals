using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> sqrtNumbers = new List<int>();

            foreach (var item in input)
            {

                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    sqrtNumbers.Add(item);
                }
            }

            sqrtNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", sqrtNumbers));
        }
    }
}
