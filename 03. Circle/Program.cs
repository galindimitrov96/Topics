using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double perimeter = 0;
            double area = 0;
            perimeter = 2 * Math.PI * r;
            area = Math.PI * r * r;
            Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
        }
    }
}

