using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        char letter = (char)('a' + i);
                        char letter1 = (char)('a' + b);
                        char letter2 = (char)('a' + c);
                        Console.WriteLine("{0}{1}{2}", letter, letter1, letter2);
                    }
                }
            }
        }
    }
}
