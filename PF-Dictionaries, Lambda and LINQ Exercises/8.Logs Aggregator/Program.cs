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


            var users = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var ip = input[0];
                var userName = input[1];
                var duration = int.Parse(input[2]);
                

                if (!users.ContainsKey(userName))
                {
                    users.Add(userName, new SortedDictionary<string, int>());
                }
                if (!users[userName].ContainsKey(ip))
                {
                    users[userName][ip] = duration;
                }
                else
                {
                    users[userName][ip] += duration;
                }

            }
            foreach (var pairs in users)
            {
                var sum = pairs.Value.Values.Sum();
                Console.WriteLine("{0}: {1} [{2}]", pairs.Key, sum, string.Join(", ", pairs.Value.Keys));
            }

        }
    }
}
