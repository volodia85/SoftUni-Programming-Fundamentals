using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int number = 0;
            int sumOfNumber = 0;
            bool special = false;

            for (int numb = 1; numb <= num; numb++)
            {
                sumOfNumber = numb;
                while (numb > 0)
                {
                    number += numb % 10;
                    numb = numb / 10;
                }
                special = (number == 5) || (number == 7) || (number == 11);
                Console.WriteLine($"{sumOfNumber} -> {special}");
                number = 0;
                numb = sumOfNumber;
            }

        }
    }
}
