using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Dictionary<string, string> entry = new Dictionary<string, string>();
            List<string> search = new List<string>();

            string type = input[0];
            string name = input[1];
            string number = input[2];


            while (input[0] != "END")
            {
                if (input[0] == "S")
                {
                    if (!entry.ContainsKey(input[1]))
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", input[1], entry[input[1]]);
                    }
                }
                else
                {
                    entry[input[1]] = input[2];
                }
                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}
