using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _16.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();


            foreach (var num in input.Distinct().OrderBy(x => x))
            {
                Console.WriteLine(string.Join(" -> ",num, input.Count(x => x == num)));
            }
            
        }
    }
}
