using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length - 1; i++)
            {
                int next = rnd.Next(words.Length);
                string old = words[i];
                words[i] = words[next];
                words[next] = old; 
            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
