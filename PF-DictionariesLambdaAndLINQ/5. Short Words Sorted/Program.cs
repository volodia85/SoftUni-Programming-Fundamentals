using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[] { '.', ',', ':', ';', '(', ')','[', ']', '"', '\'', '\\', '/', '!', '?' ,' '};

            var input = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var shortw = new List<string>();

            foreach (var item in input)
            {
                if (item.Length < 5)
                {
                    shortw.Add(item);
                }
            }

            var shortestWord = shortw.OrderBy(w => w).Distinct(); 
            

            Console.WriteLine(string.Join(", ", shortestWord));
        }
    }
}
