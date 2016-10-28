using System;

class Program
{
    
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long x1 = 0;
        long x2 = 1;
        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
        Console.Write("{0}, {1}", x1, x2);
        for (long i = 2; i < n; i++)
        {
            long x3 = x1 + x2;
            Console.Write(", {0}", x3);
            x1 = x2;
            x2 = x3;
        }
    }
}
