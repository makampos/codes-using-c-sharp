using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();

            Console.WriteLine("Nome: ");           
            fun.Nome = Console.ReadLine();

            Console.WriteLine("Salário bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioLiquido = fun.SalarioLiquido();
            Console.WriteLine(SalarioLiquido);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
             fun.AumentarSalario(porcentagem);
           
            
            Console.WriteLine("Dados Atualizados: " + fun);

        }
    }
}
