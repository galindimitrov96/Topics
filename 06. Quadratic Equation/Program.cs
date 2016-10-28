using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - 4 * a * c;
            if (discriminant > 0)
            {
                double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
                double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("{0:F2}\n{1:F2}", x1, x2);
            }
            else if (discriminant == 0)
            {
                double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("{0:F2}",x1Andx2);
            }
            else if (discriminant < 0 )
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
