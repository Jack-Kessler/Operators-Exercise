using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Exercise_2
    {
        public static double AreaOfCircle(double radius)
        {
            Console.WriteLine("What is the radius of your circle?");
            radius = double.Parse(Console.ReadLine());
            double areaOfCir = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCir}");
            return areaOfCir;
        }
    }
}
