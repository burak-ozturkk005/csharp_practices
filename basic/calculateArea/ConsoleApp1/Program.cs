namespace ConsoleApp1
{
    internal class Program
    {
        const double PI = 3.14159;
        public static double CalculateArea(double radius)
        {
            double result = PI * radius * radius;
            return result;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(5));
        }
    }
}
