using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _7.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr = new int[input.Length];

            var max = 0;
           
            for (int i = 0, j = 0; i < input.Length; i++, j++)

            {

                arr[i] = input[i] + input2[j];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Read();
            int[] longestArr = new int[0];

            var counter1 = 0;
            var counter2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                counter1++;
            }
            for (int i = 0; i < input2.Length; i++)
            {
                counter2++;
            }
            if (counter1 > counter2)
            {
                longestArr = input;

            }
            else if(counter1 < counter2)
            {
                longestArr = input2;
            }
            Console.WriteLine(string.Join(" ",longestArr));
        }
        
    }
    
}
