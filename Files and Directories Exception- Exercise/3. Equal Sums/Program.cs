using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumL = 0;
            int sumR = 0;
            List<int> leftSum = new List<int>();
            List<int> rightSum = new List<int>();
            bool isFound = false;
            if (input.Length == 1)
            {
                Console.WriteLine("0");

                return;
            }

            else if (input.Length <= 2)
            {
                Console.WriteLine("no");
                return;
            }

            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    sumL += input[i];
                    leftSum.Add(sumL);
                    int j = input.Length - 1;
                    sumR = 0;
                    for (j = input.Length - 1; j >= 0; j--)
                    {
                        sumR += input[j];
                        rightSum.Add(sumR);
                        if (sumL == sumR)
                        {
                            Console.WriteLine(i + 1);
                            isFound = true;
                            break;
                        }
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
