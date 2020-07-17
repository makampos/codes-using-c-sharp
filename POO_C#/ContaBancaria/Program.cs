using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.Write("Entre o número da conta: ");
            conta.setNumeroConta(int.Parse(Console.ReadLine()));

            Console.Write("Entre com o títular da conta: ");
            conta.SetTitular(Console.ReadLine());

            Console.Write("Haverá deposito Inicial ?: ");
            string resposta = Console.ReadLine();

            if(resposta == "sim") {
                Console.Write("Entre com o valor de depósito inicial: ");
                conta.setDepositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                       
                Console.WriteLine(conta);
            } 

            Console.WriteLine(conta);

            Console.Write("Depositar um valor: ");
            conta.setDepositar(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            
            Console.WriteLine(conta);

            Console.Write("Gostaria de fazer um saque?");
            resposta = Console.ReadLine();

            if(resposta == "sim") {
                Console.Write("Informe o Valor que deseja sacar?: ");
                conta.setEfetuarSaque(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            
            Console.WriteLine(conta);
                         
        }
    }
}
