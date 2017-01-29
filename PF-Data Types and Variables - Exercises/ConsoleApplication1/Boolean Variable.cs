using System;


namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool output = Convert.ToBoolean(input);

            if (output)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
