﻿using System;
using demo_inheritance.Entities;

namespace demo_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           Account acc = new Account(1001, "Alex", 0.0);
           BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

           // UPCASTING

           Account acc1 = bacc;
           Account acc2 = new BusinessAccount(1003, "Bob", 0.0 ,200.0);
           Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);


           // DOWNCASTING 

           BusinessAccount acc4 = (BusinessAccount)acc2;
           acc4.Loan(100.0);

           //BusinessAccount acc5 = (BusinessAccount)acc3;

           if(acc3 is BusinessAccount) {
             // Other syntax
            //  BusinessAccount acc5 = (BusinessAccount)acc3;
               BusinessAccount acc5 = acc3 as BusinessAccount;
               acc5.Loan(200.0);
               System.Console.WriteLine("Loan!");
           }

           if(acc3 is SavingsAccount) 
           {
               SavingsAccount acc5 = (SavingsAccount)acc3;
               acc5.UpdateBalance();
               System.Console.WriteLine("Update!");
           }
        }
    }
}
