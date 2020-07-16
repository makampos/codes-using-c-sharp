using System;
using System.Globalization;

namespace cotacao
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Qual é a cotação do dólar?");
           double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           Console.WriteLine("Quantos dólares você vai comprar?");
           double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          double resultado = ConversorDeMoeda.dolarParaReal(quantidade, cotacao);

          Console.WriteLine("Valor a ser pago em R$"+ resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
