using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            short years =(short) (centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = 60 * hours;
            long seconds = 60 * minutes;
            long miliseconds = 1000 * seconds;
            long microseconds = 1000 * miliseconds;
            BigInteger nanoseconds = BigInteger.Multiply(1000,  microseconds);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
