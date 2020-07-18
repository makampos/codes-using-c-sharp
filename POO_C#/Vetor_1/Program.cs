using System;
using System.Globalization;

namespace Vetor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tamanho do vetor?");

            int n = int.Parse(Console.ReadLine());
            double [] vect = new double[n];

            for (int i = 0; i < n; i ++) {
                Console.Write("Entre com o valor: ");
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            for(int i = 0; i < vect.Length; i ++) {
                Console.WriteLine("{0}", vect[i],"F2",CultureInfo.InvariantCulture );
            }

            double sum = 0;

            for(int i = 0; i < vect.Length; i ++) {
                Console.WriteLine("{0} somado até o momento: ", sum += vect[i],"F2",CultureInfo.InvariantCulture );
            }
             
           double average = sum / n ;
            Console.WriteLine("***** Média ***** \n");
            Console.WriteLine(average.ToString("0.00"),CultureInfo.InvariantCulture);
        }
    }
}
