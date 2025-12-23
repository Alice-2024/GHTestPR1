namespace ConsoleApp6
{
    public class Class1
    {
        public static void Main()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"Item {i} processed.");
                Console.WriteLine($"Item {i} completed.");
            });
        }
    }
}