namespace sentnce
{
    internal class Program
    {
        public static int CountWords(string sentence)
        {
            int count = 0;
            for(int i = 0; i< sentence.Length;i++)
            {
                if (sentence[i] == ' ')
                {
                    count++;
                }

            }
            return count + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountWords("burak coderr byte"));
        }
    }
}
