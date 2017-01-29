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
            var input = Console.ReadLine().Split(' ');

            Dictionary<string, string> entry = new Dictionary<string, string>();
            List<string> search = new List<string>();

            string type = input[0];
            string name = input[1];
            string number = input[2];
            foreach (var item in input)
            {
                if (type == "A")
                {
                    entry[name] = number;
                }
                else if (type == "S")
                {
                    search.Add(name);
                }
            }
            if (entry.Equals(search[0]))
            {
                Console.WriteLine("{0} -> {1}", name, entry[name]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", name);
            }

        }
    }
}
