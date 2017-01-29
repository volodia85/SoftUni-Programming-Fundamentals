using System;


namespace Practice_Chars_And_Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char symbol3 = char.Parse(Console.ReadLine());
            string secondName = Console.ReadLine();


            Console.WriteLine(firstName);
            Console.WriteLine((char)(symbol1));
            Console.WriteLine(symbol2);
            Console.WriteLine(symbol3);
            Console.WriteLine(secondName);
        }
    }
}
