using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            List<int> result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                 
                if (input[i] > 0)
                {
                    result.Add(input[i]);

                }

                
            }
            if (result.Any())
            {
                result.Reverse();
                foreach (var item in result)
                {
                    Console.Write($"{item} ");
                }
                
            }
            else
            {
                Console.WriteLine("empty");
            }
            

            
        }
    }
}
