namespace fac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to factorial app");
            int fact=1;
            int n = Convert.ToInt32(Console.ReadLine());
            if(n == 0)
            {
                Console.WriteLine(1);
            }else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine($"{n}'s factorial is {fact}");
            }
                
        }
    }
}
