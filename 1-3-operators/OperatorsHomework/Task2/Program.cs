using System;

namespace HardApp;
internal class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nСhoose option: \n 1. Enter array \n 2. Show array: in line");
            Console.WriteLine(" 3. Bubble sort \n 4. Sum of all elements \n 5. Multiplexing of all elements");
            Console.WriteLine(" 6. The biggest and the lowest elements \n 7. Reverse array \n 8. Add element by index");
            Console.WriteLine(" 9. Remove elements by index \n Or just type <exit>");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter count of array elements");
                    if (int.TryParse(Console.ReadLine(), out int i) && i > 0)
                    {
                        Console.WriteLine("Enter numbers one by one:");
                        MassEnter(i);
                    }
                    else
                    {
                        Console.WriteLine("Invalid data");
                        break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Your massive is ");
                    MassShow(i);
                    break;
            }




        }

    }
    public static void MassEnter(int i)
    {
        int[] mas = new int[i];
        for (int n = 0; n < mas.Length; n++)
        {
            Console.WriteLine($"Enter {n} element of array");
            mas[n] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Now choose the array action (2-9)");
    }
    public static void MassShow(int i)
    {
        for (int n = 0; n < i; n++)
        {
            Console.Write(mas[n]);
        }
    }

}


