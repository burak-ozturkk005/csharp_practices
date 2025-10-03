namespace avv
{
    internal class Program
    {
        public double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum / numbers.Length;

            }
        }
        static void Main(string[] args)
        {
           
        }
    }
}
