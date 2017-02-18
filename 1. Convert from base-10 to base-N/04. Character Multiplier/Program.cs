using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        string str1 = input[0];
        string str2 = input[1];

        int minLenght = Math.Min(str1.Length, str2.Length);
        int maxLenght = Math.Max(str1.Length, str2.Length);
        int sum = 0;

        for (int i = 0; i < minLenght; i++)
        {
            sum += MultiplyChars(str1[i], str2[i]);
        }

        if (str1.Length != str2.Length)
        {
            string longerInput = str1.Length > str2.Length ? longerInput = str1 : longerInput = str2;
            for (int i = minLenght; i < maxLenght; i++)
            {
                sum += longerInput[i];
            }
        }
        Console.WriteLine(sum);
    }

    static int MultiplyChars(char let1, char let2)
    {
        int multiply = let1 * let2;
        return multiply;
    }
}