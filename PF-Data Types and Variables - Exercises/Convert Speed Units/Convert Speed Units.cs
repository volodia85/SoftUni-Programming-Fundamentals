using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;
            float metersPerSecond = meters / 1000.0f / hourTime;
            float kmPerHour = metersPerSecond / 3.6f;
            float milesPerHour = meters / 1609.0f / hourTime;

            Console.WriteLine(kmPerHour);
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(milesPerHour);
        }
    }
}