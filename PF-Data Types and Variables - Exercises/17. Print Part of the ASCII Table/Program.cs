using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputFirst = int.Parse(Console.ReadLine());
            int inputSecond = int.Parse(Console.ReadLine());

            for (int i = inputFirst; i <= inputSecond; i++)
            {
                Console.Write("{0} ",(char)i);
            }
            Console.WriteLine();
        }
    }
}
