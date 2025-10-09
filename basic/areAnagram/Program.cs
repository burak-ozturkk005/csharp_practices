namespace areAnagram
{
    internal class Program
    {
        public bool AreAnagrams(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
                return false;

            char[] a = firstWord.ToLower().ToCharArray();
            char[] b = secondWord.ToLower().ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            return new string(a) == new string(b);
           
        }
        static void Main(string[] args)
        {
           
        }
    }
}
