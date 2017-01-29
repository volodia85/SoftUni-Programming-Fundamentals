using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{


    class Program
    {

        static void Main(string[] args)
        {
            Rectangle rec1 = ReadRectangle();
            Rectangle rec2 = ReadRectangle();

            Console.WriteLine(rec1.IsInside(rec2) ? "Inside" : "Not inside");
        }
        static Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle side = new Rectangle();

            side.Left = input[0];
            side.Top = input[1];
            side.Width = input[2];
            side.Height = input[3];

            return side;
        }

    }
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
        public int Bottom
        {
            get
            {

                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }

    }
}
