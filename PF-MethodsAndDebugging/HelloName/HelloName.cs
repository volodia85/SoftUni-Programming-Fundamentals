using System;


namespace HelloName
{
    public class HelloName
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintNAme(name);
        }
        static string PrintNAme(string name)
        {
            Console.Write("Hello, ");
            Console.WriteLine("{0}!", name);
            return name;
        }
         
    }
}
