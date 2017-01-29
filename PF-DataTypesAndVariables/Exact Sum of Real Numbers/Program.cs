using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal numb = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                numb += num;
            }
            Console.WriteLine(numb);
        }
    }
}
