using System;
using Abstract;

namespace Ex32
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectAngle = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 7);
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(1, 2, 3);
            Surface[] surfaces = { rectAngle, rightTriangle, circle, triangle };
            for (var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"{surfaces[i]}の面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"{surfaces[i]}の周囲長は{surfaces[i].GetCircumference()}");
                surfaces[i].GetBounds(out float beside, out float vertical);
                Console.WriteLine($"{surfaces[i]}のその形が入る長方形の幅と高さは,縦：{vertical}横：{beside}");
            }
        }
    }
}