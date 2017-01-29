using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> text = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var item in text)
            {
                bool isLowerCase = true;
                bool isUpperCase = true;
                for (int i = 0; i < item.Length; i++)
                {

                    if (char.IsLower(item[i]))
                    {
                        isUpperCase = false;
                    }
                    else if (char.IsUpper(item[i]))
                    {
                        isLowerCase = false;
                    }
                    else
                    {
                        isUpperCase = false;
                        isLowerCase = false;
                    }
                }
                if (isLowerCase)
                {
                    lowerCase.Add(item);
                }
                else if (isUpperCase)
                {
                    upperCase.Add(item);
                }
                else
                {
                    mixedCase.Add(item);
                }

            }


            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
