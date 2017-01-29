using System;


namespace MaxMethod
{
    public class MaxMethod
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int printMax = GetMax(first,second,third);
            Console.WriteLine(printMax);
        }
        static int GetMax(int first, int second, int third)
        {
            int Max = Math.Max(first, second);
            if (Max < third)
            {
                Max = third;
            }
            return Max;
        }
    }
}
