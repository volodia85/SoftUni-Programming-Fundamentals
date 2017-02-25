using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {


            var input = Console.ReadLine();

            while (input != "end")
            {
                string result = Regex.Replace(input, @"<a.*?href.*?=(.*?)>(.*?)<\/a>", @"[URL href=$1]$2[/URL]");

                Console.WriteLine(result);
                input = Console.ReadLine();
            }
            
            



        }
    }
}
