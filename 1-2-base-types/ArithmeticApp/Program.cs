using System;

namespace typesApp;
internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Input x");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Input y");
        float y = float.Parse(Console.ReadLine());
        Console.WriteLine("Input z");
        float z = float.Parse(Console.ReadLine());

        float f = (x + y + z) * (x - z) / (y * y) + 2 * z;
        Console.WriteLine($"F = {f.ToString("0.00")}");
    }

}
