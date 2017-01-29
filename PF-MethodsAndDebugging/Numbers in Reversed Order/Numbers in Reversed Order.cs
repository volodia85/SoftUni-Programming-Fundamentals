using System;


namespace Numbers_in_Reversed_Order
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
 
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        
        
        
        }
    }
}
