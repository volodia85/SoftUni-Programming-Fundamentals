using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split();

            HashSet<char> arr1 = new HashSet<char>(input[0]);
            HashSet<char> arr2 = new HashSet<char>(input[1]);

            if (arr1.Count == arr2.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
