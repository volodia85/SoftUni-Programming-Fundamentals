using System;


namespace Exchange_Variable_Values
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before: \na = {a} \nb = {b}");

            
            Console.WriteLine($"After: \na = {b} \nb = {a}");
        }
    }
}
