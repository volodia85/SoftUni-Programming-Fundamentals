using System;


namespace _11.GeometryCalculator
{
    public class GeometryCalculator
    {
        public static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double side = 0;
            double height = 0;
            if (figure == "triangle")
            {
                side = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", AreaOfTriangle(side,height));
            }
            else if (figure == "square")
            {
                side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", AreaOfSquare(side));
            }
            else if (figure == "rectangle")
            {
                side = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", AreaOfRectangle(side, height));
            }
            else if (figure == "circle")
            {
                side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", AreaOfCircle(side));
            }

        }
        static double AreaOfTriangle(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }
        static double AreaOfSquare(double side)
        {
            double area =(side * side);
            return area;
        }
        static double AreaOfRectangle(double side, double height)
        {
            double area = side * height;
            return area;
        }
        static double AreaOfCircle(double side)
        {
            double area = Math.PI * (side * side);
            return area;
        }
    }
}
