using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<Employee> list = new List<Employee>();
            System.Console.WriteLine("How many employees will be registered?");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i < number; i++) {

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Salary: ");
                double salary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary)) ;               
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int IdPerson = int.Parse(Console.ReadLine());

           Employee emp = list.Find(x => x.Id == IdPerson);
           
           if(emp != null) {
                Console.Write("Enter the percentage: ");
                double percent = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
           } else {
               System.Console.WriteLine("This id does not exist!");
           }

            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}
