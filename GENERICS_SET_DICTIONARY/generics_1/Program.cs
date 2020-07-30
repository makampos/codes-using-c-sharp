using System;

namespace generics_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();

            System.Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                 string x = (Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            System.Console.WriteLine();
            System.Console.WriteLine("First: " + printService.First());
        }
    }
}
