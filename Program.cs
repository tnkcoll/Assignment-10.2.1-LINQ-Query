namespace Assignment_10._2._1_LINQ_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, -1, 3, -3, 10, -200 };

            var numQuery = from num in ints
                           where num > 0 
                           select num;

            foreach (var num in numQuery)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
