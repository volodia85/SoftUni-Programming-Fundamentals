using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = input.Length / 4;

            int[] leftRow = input.Take(k).Reverse().ToArray();
            int[] rightRow = input.Reverse().Take(k).ToArray();
            int[] row1 = leftRow.Concat(rightRow).ToArray();
            int[] row2 = input.Skip(k).Take(2 * k).ToArray();

            var sum = row1.Select((x, y) => x + row2[y]);

            Console.WriteLine(string.Join(" ", sum));



        }
    }
}
