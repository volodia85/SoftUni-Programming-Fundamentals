using System;


namespace _8.Employee_Data
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            long UniqueEmployeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {UniqueEmployeeNumber}");

        }
    }
}
