using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            MiddleElement(input);
            
        }

        private static void MiddleElement(int[] input) 
        {

            int middleElement = input.Length / 2;
            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
                return;
            }
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[middleElement - 1]}, {input[middleElement]}");

            }
            else
            {
                Console.WriteLine($"{input[middleElement - 1]}, {input[middleElement]}, {input[middleElement + 1]}");

            }


        }

       
    }
}
