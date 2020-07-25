using System;
using EXCEPTION_DEMO.Entities;

namespace EXCEPTION_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Check-out date (dd/MMM/yyyy): ");
            DateTime checkOut  = DateTime.Parse(Console.ReadLine());


            if (checkOut <= checkIn) 
            {
                System.Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                
            } 
            else
            {
                Reservation  reservation = new Reservation(number, checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);

                System.Console.WriteLine();
                System.Console.WriteLine("Enter the data to update the reservation");

                
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Check-out date (dd/MMM/yyyy): ");
                checkOut  = DateTime.Parse(Console.ReadLine());

               string error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null) 
                {
                    System.Console.WriteLine("Error: " + error);                   
                }
                else {
                    System.Console.WriteLine("Reservation: " + reservation);
                }                
            }         
        }
    }
}
