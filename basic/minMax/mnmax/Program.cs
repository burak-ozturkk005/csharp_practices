namespace mnmax
{
    internal class Program
    {
        public (int, int) minMax(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array can not be empty!");
            }
            else
            {
                int min = numbers[0];
                int max = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                return (min, max);
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
