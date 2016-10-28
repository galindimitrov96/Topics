using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            string hexValue = a.ToString("X");//heximal representation
            string binary = Convert.ToString(a, 2).PadLeft(32, '0');//binary representation
            Console.Write("{0} {1} {2:F2} {3:F3}", hexValue, binary, b, c);
            Console.ReadLine();
        }
    }
}
