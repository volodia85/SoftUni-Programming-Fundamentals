using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>(Console.ReadLine().Split('|').ToArray());

            var result = new List<string>();
            input.Reverse();
            foreach (var item in input)
            {
                List<string> nums = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }
            Console.WriteLine(string.Join(" ", result));
            

        }
    }
}
