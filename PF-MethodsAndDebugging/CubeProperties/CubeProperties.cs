using System;


namespace CubeProperties
{
    public class CubeProperties
    {
        public static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameterOfCube = Console.ReadLine();
            

            switch (parameterOfCube)
            {
                case "face":
                    Console.WriteLine("{0:f2}", GetFace(sideOfCube));
                    break;
                case "space":
                    Console.WriteLine("{0:f2}", GetSpace(sideOfCube));
                    break;
                case "volume":
                    Console.WriteLine("{0:f2}", GetVolume(sideOfCube));
                    break;
                case "area":
                    Console.WriteLine("{0:f2}", GetArea(sideOfCube));
                    break;
            }

        }
        static double GetFace(double side)
        {
            double face = Math.Sqrt(2 * (side * side));
            return face;
        }
        static double GetSpace(double side)
        {
            double space = Math.Sqrt(3 * (side * side));
            return space;
        }
        static double GetVolume(double side)
        {
            double volume = side * side * side;
            return volume;
        }
        static double GetArea(double side)
        {
            double area = 6 * (side * side);
            return area;
        }
    }
}
