using System;

namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {

            string str1 = (Console.ReadLine());
            string str2 = (Console.ReadLine()); 
            string str3 = (Console.ReadLine()); 
            string str4 = (Console.ReadLine()); 
            string str5 = (Console.ReadLine()); 
            string str6 = (Console.ReadLine()); 
            string str7 = (Console.ReadLine()); 
            string str8 = (Console.ReadLine());
            string str9 = (Console.ReadLine()); 

            string output1 = str1;
            string output2 = ("Address: " + str2);
            string output3 = ("Tel. " + str3);
            string output4 = ((str4 == "") ? "Fax: (no fax)" : ("Fax: " + str4));
            string output5 = ("Web site: " + str5);
            string output6 = ("Manager: " + str6);
            string output7 = str7;
            string output8 = ("age: " + str8);
            string output9 = ("tel. " + str9);

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5} {6} ({7}, {8})", output1, output2, output3, output4, output5, output6, output7, output8, output9);

        }
    }
}