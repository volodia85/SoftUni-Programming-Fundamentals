namespace _04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var list = new List<string>();

            foreach (var word in input)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    list.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", list.OrderBy(a => a).Distinct()));
        }
    }
}