namespace sr
{
    internal class Program
    {
        public static string ReverseString(string Text)
        {
            string reversed = "";
            for(int i = Text.Length -1; i>= 0;i--)
            {
                reversed += Text[i];
            }
            return reversed;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Burak"));
        }
    }
}
