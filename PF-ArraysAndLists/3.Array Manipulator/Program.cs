using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var nextInput = "";
            int[] nn = new int[input.Count];
            while (!input.Equals("print"))
            {
                nextInput = Console.ReadLine();
                if (nextInput.Contains("add"))
                {
                    var next = nextInput.Remove(nextInput[0]);
                    next.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    input[nextInput[1]] = nextInput[1];

                }
                else if (nextInput.Contains("addMany"))
                {
                    nextInput.Split().Select(int.Parse).ToList();
                    input.Add(nextInput[1]);
                }else if (nextInput.Contains("contains"))
                {
                    
                }
            }
        }
    }
}
