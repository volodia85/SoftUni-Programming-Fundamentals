using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Count_substring_occurrences
{
    static class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string search = Console.ReadLine().ToLower();

            int countOccurances = text.Split(new[] { search }, StringSplitOptions.None).Length - 1;
            Console.WriteLine(countOccurances);
        }
    }
}
