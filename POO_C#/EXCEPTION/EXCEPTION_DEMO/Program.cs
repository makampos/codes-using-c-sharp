using System;
using EXCEPTION_DEMO.Entities;
using EXCEPTION_DEMO.Entities.Exceptions;

namespace EXCEPTION_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
           try 
           {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date (dd/MMM/yyyy): ");
                DateTime checkOut  = DateTime.Parse(Console.ReadLine());
                
                Reservation  reservation = new Reservation(number, checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);

                System.Console.WriteLine();
                System.Console.WriteLine("Enter the data to update the reservation");
            
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date (dd/MMM/yyyy): ");
                checkOut  = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);           
                System.Console.WriteLine("Reservation: " + reservation);
           } 
           catch (DomainException e) 
           {
                System.Console.WriteLine("Error: " + e.Message);
           }     
           catch (FormatException e) 
           {
               System.Console.WriteLine("Format error: " + e.Message);
           }       
           catch (Exception e) 
           {
               System.Console.WriteLine("Unexpected error: " + e.Message);
           }                                
        }
    }
}