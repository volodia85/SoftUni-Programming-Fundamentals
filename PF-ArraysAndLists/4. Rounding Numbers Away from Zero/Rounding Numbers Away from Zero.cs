using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
        
   
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int[] rounded = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                rounded[i] = (int)(Math.Round(input[i], MidpointRounding.AwayFromZero));
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} => {1}", input[i], rounded[i]);
            }
                
        }
    }
}
