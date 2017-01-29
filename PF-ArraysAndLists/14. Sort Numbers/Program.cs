using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            input.Sort((a, b) => a.CompareTo(b));
            

            List<string> print = new List<string>();

            foreach (var item in input)
            {
                print.Add(item.ToString());
            }
            Console.WriteLine(string.Join(" <= ", input)) ;
        }
    }
}
