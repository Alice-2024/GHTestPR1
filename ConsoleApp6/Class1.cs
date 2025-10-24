using System;
using System.Threading.Tasks;

internal class Class1
{
    public static void Main()
    {
        Parallel.For(0, 10, i =>
        {
            Console.WriteLine($"Processing item {i}");
        });
    }
}