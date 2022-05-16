using System;

namespace HardApp;
internal class Program
{
    public static void Main()
    {
        while (true)
        {
            bool n;
            Console.WriteLine("Сhoose option: \n 1. Enter count of array elements \n 2. Show array: in line");
            Console.WriteLine(" 3. Bubble sort \n 4. Sum of all elements \n 5. Multiplexing of all elements");
            Console.WriteLine(" 6. The biggest and the lowest elements \n 7. Reverse array \n 8. Add element by index");
            Console.WriteLine(" 9. Remove elements by index \n Or just type <exit>");
            switch (Console.ReadLine())

            {
                case "1":
                    n = int.TryParse(Console.ReadLine(), out int i);
                    if (n == true)
                    {
                        int[] mas = new int[i];
                    }
                    else
                    {
                        Console.WriteLine("Invalid data");
                    }
                    break;
            }




        }

    }
}