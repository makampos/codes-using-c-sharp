namespace Vetor_params
{
    public class Calculator
    {
        public static int Calc(params int[] numbers) {
            int Sum = 0;
            for(int i = 0 ; i < numbers.Length; i++) {
                Sum += numbers[i];
            }
            return Sum;
        }
    }
}