using System;

namespace CircleAppGroup1
{
    class Program
    {
        public static double RequestRadius()
        {
            Console.WriteLine("Please enter radius:");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double RequestHeight()
        {
            Console.WriteLine("Please enter height:");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double CalculateArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            return area;
        }

        public static double CalculateVolume(double radius, double height)
        {
            return CalculateArea(radius) * height;
        }

        public static void OutputArea(double radius, double area)
        {
            Console.WriteLine("For a circle with a radius of "
                + radius + " the area is " + area);
        }

        public static void OutputVolume(double radius, double height,
            double volume)
        {
            Console.WriteLine("For a cilinder with a radius of "
                + radius + " and a height of " + height + " the "
                + "volume is " + volume);
        }

        static void Main(string[] args)
        {
            // 1 - Wat is de straal ?
            double radius = RequestRadius();

            // 2 - Wat is de hoogte (cilinder)
            double height = RequestHeight();

            // 3 - Oppervlakte berekenen
            double area = CalculateArea(radius);

            // 4 - Volume of cilinder
            double volume = CalculateVolume(radius, height);

            // 5 - Resultaat
            OutputArea(radius, area);
            OutputVolume(radius, height, volume);
        }
    }
}
