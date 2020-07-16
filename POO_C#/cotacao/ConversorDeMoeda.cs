namespace cotacao
{
    public class ConversorDeMoeda
    {

        public static double cotacao;
        public static double quantidade;
        public static double IOF = 6.0;
       

        public static double dolarParaReal(double quantidade, double cotacao) {
            double total = quantidade * cotacao;
            return total + total * IOF / 100;
        }

    }
}