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

            double nearestPointToCenter = 0;
            if (ClosestPointToCenterA(x1,y1) < ClosestPointToCenterA(x2, y2))
            {
                nearestPointToCenter = (ClosestPointToCenterA(x1, y1));
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                nearestPointToCenter = ClosestPointToCenterA(x2, y2);
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
        static double ClosestPointToCenterA(double x1, double y1)
        {
            double closestPoint = Math.Sqrt((Math.Pow(x1, y1)));
            return closestPoint;
        }
        
        
        
    }
}
