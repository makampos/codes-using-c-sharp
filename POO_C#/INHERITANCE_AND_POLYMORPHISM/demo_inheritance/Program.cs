using System;
using demo_inheritance.Entities;

namespace demo_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010 ,"Bob Brow", 100.0, 500.0);

            System.Console.WriteLine(account.Balance);

            // account.Balance = 200;
        }
    }
}
