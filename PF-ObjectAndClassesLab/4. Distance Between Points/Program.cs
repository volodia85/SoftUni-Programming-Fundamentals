using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}
namespace _4.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point FirstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            Console.WriteLine("{0:f3}", CalcPoints(FirstPoint,secondPoint));
        }
        static Point ReadPoint()
        {
            var p1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point points = new Point() { X = p1[0], Y = p1[1] };

            return points;
        }
        
        static double CalcPoints(Point p1, Point p2)
        {
            var sideA = p1.X - p2.X;
            var sideB = p1.Y - p2.Y;

            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;

        }
    }
}
