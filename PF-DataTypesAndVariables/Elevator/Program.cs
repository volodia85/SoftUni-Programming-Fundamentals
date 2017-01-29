using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal people = int.Parse(Console.ReadLine());
            decimal courses = int.Parse(Console.ReadLine());

            decimal c = Math.Ceiling(people / courses);

            Console.WriteLine("{0}",c);
        }
    }
}
