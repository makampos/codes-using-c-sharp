using System;
using System.Globalization;
using Entities;
using Services;
using solucao_com_interface.Services;

namespace solucao_com_interface
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Enter rental data");
           System.Console.WriteLine("Car model: ");
           string model = Console.ReadLine();
           System.Console.WriteLine("Pickup (dd/MM/yyyy HH:mm): ");
           DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            System.Console.WriteLine("Return (dd/MM/yyyy HH:mm): ");
           DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            System.Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour , day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            System.Console.WriteLine("INVOICE: ");
            System.Console.WriteLine(carRental.Invoice);
        }
    }
}
