﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (var i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(string.Join(" ", input[i]));
            }
            Console.WriteLine();
        }
    }
}
