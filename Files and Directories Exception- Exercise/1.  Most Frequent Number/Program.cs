using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mfn = new List<int>();
            List<int> mfn2 = new List<int>();

            int count = 1;
            int currentIndex = 0;
            for (int i = 1; i < n.Count; i++)
            {
                if (n[i] == n[currentIndex])
                    count++;
                else
                    count--;
                if (count == 0)
                {
                    currentIndex = i;
                    count = 1;
                }
            }
            
            int mostFreq = n[currentIndex];
            Console.WriteLine(mostFreq);
            //int count = 0;
            //for (int i = 0; i < n.Count - 1; i++)
            //{

            //    if (n[i] == n[i + 1] || n[i] == n[i - 1])
            //    {
            //        mfn.Add(n[i]);
            //        count++;
            //    }

            //}
            //foreach (var nums in mfn)
            //{
            //    if (nums == nums + 1 )
            //    {
            //        Console.WriteLine(string.Join(" ", nums));
            //    }
            //}
            //Console.WriteLine(string.Join(" ", mfn2[1]));
        }
    }
}
