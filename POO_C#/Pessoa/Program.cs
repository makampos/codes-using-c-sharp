using System;

namespace Pessoa
{
    class Program
    {                
        static void Main(string[] args)
        {            
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Digite o nome: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p1.idade = int.Parse(Console.ReadLine());

           Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Digite o nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            
        if (p2.idade > p1.idade) {
            Console.WriteLine("Mais velha: " + p2.nome);
        } else {
            Console.WriteLine("Mais velha: " + p1.nome);
        }

        }
    }
}
