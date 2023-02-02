using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Exercise_1
    {
        public static void AdditionMethod(int a, int b)
        {
            int c = a + b;
            //Console.WriteLine(c);
        }
        public static void SubtractionMethod(int a, int b)
        {
            int c = a - b;
           // Console.WriteLine(c);
        }
        public static void MultiplcationMethod(int a, int b)
        {
            int c = a * b;
          //  Console.WriteLine(c);
        }
        public static void DivisionMethod(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
        }
    }
}
