using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> num = new Dictionary<string, long>();
            string input = Console.ReadLine().Trim();

            while (input != "stop")
            {
                int input2 = int.Parse(Console.ReadLine().Trim());

                if (num.ContainsKey(input))
                {
                    num[input] += input2;
                }
                else
                {
                    num.Add(input, input2);
                }
                input = Console.ReadLine();
            }
            foreach (var item in num)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }


        }
    }
}
