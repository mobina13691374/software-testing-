using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForatiHw1
{
    internal class TestPolygon
    {

        /// <summary>
        /// This function gets inputs and create polygon object and call CalculateArea function.
        /// </summary>
        public void StaticTest(List<Point> points)
        {
            var polygonBuilder = new PolygonBuilder();
            polygonBuilder.AddPointRange(points);

            AreaCalculator calculator = new AreaCalculator(polygonBuilder.Build());
            double area = calculator.CalculateArea();

            Console.WriteLine($"Calculated Area: {area}");

        }

        /// <summary>
        /// This function gets inputs from Console and create polygon object and call CalculateArea function.
        /// </summary>
        public void DynamicTest()
        {
            var polygonBuilder = new PolygonBuilder();

            Console.Write("enter number of sides (n > 3)");
            int count = int.Parse(Console.ReadLine() ?? "0");

            if (count < 3)
            {
                throw new InvalidDataException();
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write("enter point {0} x: ", i + 1);
                double x = double.Parse(Console.ReadLine() ?? "0");
                Console.Write("enter point {0} y: ", i + 1);
                double y = double.Parse(Console.ReadLine() ?? "0");
                polygonBuilder.AddPoint(x, y);
            }

            AreaCalculator calculator = new AreaCalculator(polygonBuilder.Build());
            double area = calculator.CalculateArea();

            Console.WriteLine($"Calculated Area: {area}");

        }
    }
}
