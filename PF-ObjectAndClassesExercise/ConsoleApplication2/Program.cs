using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Circle firstCircle = new Circle();
            firstCircle.X = firstCircleInput[0];
            firstCircle.Y = firstCircleInput[1];
            firstCircle.Radius = firstCircleInput[2];

            Circle secondCircle = new Circle();
            secondCircle.X = secondCircleInput[0];
            secondCircle.Y = secondCircleInput[1];
            secondCircle.Radius = secondCircleInput[2];
            bool IsIN = IsIntesect(firstCircle, secondCircle);
            if (IsIN)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        static bool IsIntesect(Circle c1, Circle c2)
        {

            var distance = Math.Sqrt(Math.Pow(c2.X - c1.X, 2) + Math.Pow(c2.Y - c1.Y, 2));

            if (distance <= c1.Radius + c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
    }
}