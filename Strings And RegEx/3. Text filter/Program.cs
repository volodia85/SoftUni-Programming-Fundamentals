using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ' ', '.' };
            List<string> banWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            string text = Console.ReadLine();

            text = banWords.Aggregate(text, (current, word) => current.Replace(word, new string('*', word.Length)));
            
            Console.WriteLine(text);
        }
    }
}
