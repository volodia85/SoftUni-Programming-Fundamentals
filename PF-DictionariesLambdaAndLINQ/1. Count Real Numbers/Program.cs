using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList() ;
            
            var counts =  new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                var parsed = double.Parse(num);
                if (counts.ContainsKey(parsed))
                {
                    counts[parsed]++;
                }
                else
                {
                    counts[parsed] = 1;
                }
                
            }
            foreach (var nums in counts.Keys)
            {
                Console.WriteLine($"{nums} -> {counts[nums]}");
            }
        }

    }
}
