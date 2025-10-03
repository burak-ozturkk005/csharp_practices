namespace dplicate
{
    internal class Program
    {
        public static int[] removeduplicate(int[] numbers)
        {
            List<int> result = new List<int>();
            foreach(var num in numbers)
            {
                if(!result.Contains(num))
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }
        static void Main(string[] args)
        {
            int[] numbers = { 3,3,2,2, 4, 5, 6, 6, 7, 8, 9, 10, 11 };
            int[] uniqueNum = removeduplicate(numbers);
            foreach(var num in uniqueNum)
            {
                Console.WriteLine(num);
            }
        }
    }
}
