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

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now) 
                {
                    System.Console.WriteLine("Error in reservation: Reservation date for updates must be future dates ");
                } 
                else if ( checkOut <= checkIn) 
                {
                        System.Console.WriteLine("Error in reservation: Check-out must be after check-in date ");
                }

                else {
                    reservation.UpdateDates(checkIn, checkOut);
                    System.Console.WriteLine("Reservation: " + reservation);
                }
            }
          
        }
    }
}
