using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            string[] words = input.Split();

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]+= 1;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var result = new List<string>();

            foreach (var pair in counts.Keys)
            {
                if (counts[pair] % 2 == 1)
                {
                    result.Add(pair); 
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
