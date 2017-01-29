using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IndexofLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] chars = new char[26];

            for (var j = 0; j < chars.Length; j++)
            {
                chars[j] = (char)('a' + j);
            }

            for (int i = 0; i < input.Length; i++)

            {
                Console.WriteLine(input[i] + " -> " + Array.IndexOf(chars, input[i]));
            }
        }
    }
}
