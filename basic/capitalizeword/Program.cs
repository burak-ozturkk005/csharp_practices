namespace capitalizeword
{
    internal class Program
    {
        public static string Capitalize(string sentence)
        {
            char[] chars = sentence.ToCharArray();
                for(int i = 0; i< chars.Length;i++)
            {
                if(i == 0 || chars[i - 1] == ' ')
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
            }
            string result = new string(chars);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Capitalize("burak ozturk"));
        }
    }
}
