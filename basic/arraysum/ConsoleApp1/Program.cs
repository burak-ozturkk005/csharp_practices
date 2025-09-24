namespace ConsoleApp1
{
    internal class Program
    {
        public static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length;i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] sayilar = { 3, 4, 6, 7, 8, 9 };
            Console.WriteLine(CalculateSum(sayilar));
        }
    }
}
