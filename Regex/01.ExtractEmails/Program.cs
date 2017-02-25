using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Regex regex = new Regex(@"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
                
            }
        }
    }
}
