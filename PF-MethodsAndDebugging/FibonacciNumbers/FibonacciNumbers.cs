using System;


namespace FibonacciNumbers
{
    public class FibonacciNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FibonacciNum(n);
            

        }
        static int FibonacciNum(int num)
        {
            int f0 = 1;
            int f1 = 1;
            for (int i = 0; i < num-1; i++)
            {
                int fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine(f1);
            return f1;
        }
    }
}
