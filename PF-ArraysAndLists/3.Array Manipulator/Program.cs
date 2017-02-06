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
            List<string> nextInput = new List<string>();
            int[] nn = new int[input.Count];
            var endInput = input.Count;
            while (!input.Equals("print"))
            {
                nextInput = Console.ReadLine().Split().ToList();
                if (nextInput.Contains("add"))
                {
                    nextInput.Remove(nextInput[0]);
                    List<int> nums = nextInput.Select(int.Parse).ToList();
                    int index = nums[0];
                    int num = nums[1];
                    input.Insert(index, num);

                }
                else if (nextInput.Contains("addMany"))
                {
                    nextInput.Remove(nextInput[0]);
                    List<int> nums = nextInput.Select(int.Parse).ToList();
                    int index = nums[0];
                    int num = nums[1];
                    input.AddRange(nums);
                    
                }
                else if (nextInput.Contains("contains"))
                {
                    nextInput.Remove(nextInput[0]);
                    List<int> nums = nextInput.Select(int.Parse).ToList();
                    int num = nums[0];
                    if (input.Contains(num))
                    {
                        Console.WriteLine(nums.IndexOf(num));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (nextInput.Contains("remove"))
                {
                   nextInput.Remove(nextInput[0]);
                    List<int> nums = nextInput.Select(int.Parse).ToList();
                    int index = nums[0];
                    input.RemoveAt(index);
                    
                }
                else if (nextInput.Contains("shift"))
                {
                    nextInput.Remove(nextInput[0]);
                    List<int> nums = nextInput.Select(int.Parse).ToList();
                    int rotations = nums[0];
                    RotateRight(input,rotations);
                }else if (nextInput.Contains("sumPairs"))
                {

                    for (int i = 1; i < input.Count; i++)
                    {
                        var sum = input[i-1] + input[i];

                    }
                }
            Console.WriteLine("[{0}]",string.Join(" ",input));
            }
        }
        public static void RotateRight(List<int> input, int right)
        {
            for (var i = 0; i < right; i += 1)
            {
                RotateRightOne(input);
            }
        }

        public static void RotateRightOne(List<int> input)
        {
            var last = input.Count - 1;
            for (var i = 0; i < last; i += 1)
            {
                input[i] ^= input[last];
                input[last] ^= input[i];
                input[i] ^= input[last];
            }
        }
    }
}
