using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.Sort((a, b) => a.CompareTo(b));

            List<int> numbers = new List<int>();

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i - 1] == input[i])
                {
                    numbers.Add(input[i-1]);
                    input.RemoveAt(input[i-1]);
                    i = 0;
                }
                else if (input[i-1] != input[i])
                {
                    input.RemoveAt(input[i - 1]);
                    i = 0;
                }
            }
           
            Console.WriteLine(string.Join(""));
        }
    }
}
