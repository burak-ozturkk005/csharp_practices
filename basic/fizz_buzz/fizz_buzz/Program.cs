namespace fizz_buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz app");
            for(int i = 0; i< 101;i++)
            {
                if( i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
