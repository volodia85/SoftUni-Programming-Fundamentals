using System;


namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();

            int decimalFormat = Convert.ToInt32(hexadecimal, 16);

            Console.WriteLine(decimalFormat);
        }
    }
}
