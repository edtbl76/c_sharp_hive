using System;

namespace ArchitectArithmetic
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Should Print 20
            Console.WriteLine(GetRectangleArea(4, 5));
            
            // Should print 50.26548245743669
            Console.WriteLine(GetCircleArea(4));
            
            // Should print 45
            Console.WriteLine(GetTriangleArea(10, 9));
            
            /*
             * Floor plan
             * Rectangle of 1500, 2500
             * Circle w/ diameter of 375 (but we need half the area)
             * Triangle w/ base 750, height 500
             */

            var rectangle = GetRectangleArea(1500, 2500);
            var halfCircle = GetCircleArea(375.0 / 2) / 2;
            var triangle = GetTriangleArea(750, 500);
            var totalArea = rectangle + halfCircle + triangle;
            Console.WriteLine($"Total Area: {totalArea}");
            
        }

        private static double GetRectangleArea(double length, double width)
        {
            return length * width;
        }

        private static double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private static double GetTriangleArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
        
    }
}