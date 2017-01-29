using System;





namespace CenterPoint
{
    public class CenterPoint
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double nearestPointToCenterA = ClosestPointToCenterA(x1, y1, x2, y2);
            double nearestPointToCenterC = ClosestPointToCenterA(x3, y3, x4, y4);

            double lineA = nearestPointToCenterA;
            double lineB = nearestPointToCenterC;

            if (lineA >= lineB)
            {
                
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
            }

        }

        static double ClosestPointToCenterA(double x1, double y1, double x2, double y2)
        {
            double closestPoint = Math.Sqrt((Math.Pow(x1 - x2, 2) + (Math.Pow(y1 - y2, 2))));
            return closestPoint;
        }



    }

}


