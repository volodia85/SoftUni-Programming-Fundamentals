using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Closest_Two_Points
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point FirstPoint = ReadPoint();
            //Point secondPoint = ReadPoint();

            Console.WriteLine("{0:f3}", FindClosesPoint(FirstPoint, secondPoint));
        }
        static Point[] ReadPoint()
        {
            int input = int.Parse(Console.ReadLine());
            double[] p1 = new double[input];
            Dictionary < double, double> pointsOf = new Dictionary<double, double>();
            for (int i = 0; i < input; i++)
            {
                 p1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
                pointsOf.Add(p1[0],p1[1]);
            }
            Point points = new Point() { X = p1[0], Y = p1[1] };
           

            return pointsOf[points];
        }

        static double CalcPoints(Point p1, Point p2)
        {
            var sideA = p1.X - p2.X;
            var sideB = p1.Y - p2.Y;

            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;

        }
        static double FindClosesPoint(Point p1 , Point p2)
        {
            
            var sideA = p1.X - p2.X;
            var sideB = p1.Y - p2.Y;
            double clp = Math.Sqrt(Math.Pow(sideA, sideB));
            return clp;
        }
    }
}
