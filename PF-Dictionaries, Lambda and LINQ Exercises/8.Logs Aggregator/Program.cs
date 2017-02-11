using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            
            var users = new SortedDictionary<string,SortedDictionary<string,List<int>>>();
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var ip = input[0];
                var userName = input[1];
                var duration = int.Parse(input[2]);
                users[userName] = new SortedDictionary<string,List<int>>();
                users[userName][ip] = new List<int> { duration };
                
               
                
            }
                foreach (var use in users)
                {
                    //Console.WriteLine($"{use.ToString()}: {duration.ToString()} {ip.ToString()}");
                }
            Console.WriteLine("s");
        }
    }
}
