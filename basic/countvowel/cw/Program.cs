namespace cw
{
    internal class Program
    {
        public  static int CountVowels(string text)
        {
            int count = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('a') || text[i].Equals('e')|| text[i].Equals('i') || text[i].Equals('o') || text[i].Equals('u'))
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountVowels("Hello World")); //3
        }
    }
}
