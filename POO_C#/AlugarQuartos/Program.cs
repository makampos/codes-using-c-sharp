using System;

namespace AlugarQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] vectStudents = new Students[10];
            Console.WriteLine("How many rooms will be rented?");
            int qtdRooms = int.Parse(Console.ReadLine());

            for(int i = 1 ; i <= qtdRooms; i ++) {
                Console.Write($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                 Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                 vectStudents[room] = new Students( name, email);
            }    

            Console.WriteLine("Busy Rooms");
            for(int i = 0; i < 10; i ++) {
                if(vectStudents[i] != null) {
                    Console.WriteLine(i + ":" + vectStudents[i]);
                }
            }
        }
    }
}
