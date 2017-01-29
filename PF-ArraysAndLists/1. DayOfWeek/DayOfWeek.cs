using System;


namespace _1.DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            string[] DaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (dayNumber > 0 && dayNumber < 8)
            {

                Console.WriteLine(DaysOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
