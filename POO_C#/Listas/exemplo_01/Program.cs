using System;
using System.Collections.Generic;

namespace exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List = new List<string>();
            
            List.Add("Maria");
            List.Add("Alex");
            List.Add("Bob");
            List.Add("Michael Anderson");

            foreach(string obj in List) {
                Console.WriteLine(obj);
            }

            System.Console.WriteLine("------");

            List.Insert(2,"Ryan");
            
            foreach(string obj in List) {
                Console.WriteLine(obj);
            }

            System.Console.WriteLine("------");

            string s1 = List.Find(x => x[0] == 'A');

            System.Console.WriteLine("Elemento: " + s1);

            int pos1 = List.FindIndex(x => x[0] == 'B');

            System.Console.WriteLine("Posição: " + pos1);

            List<string> list2 = List.FindAll(x => x.Length > 5);


            System.Console.WriteLine("----- Filtrando Nomes -----");
            foreach(string nome in list2) {
                Console.WriteLine(nome);                
            }
           
        }
    }
}
