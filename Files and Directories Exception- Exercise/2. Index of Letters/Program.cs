using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spliter = new string[] {"a", "b", "c", "d", "e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            string input = Console.ReadLine();

            List<char> chars = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < spliter.Length; j++)
                {
                    if (input[i].ToString().Contains(spliter[j]))
                    {
                        
                        chars.Add(input[i]);
                    }
                }
            }
        }
    }
}
