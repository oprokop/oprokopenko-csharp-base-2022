using System;

namespace CalculatingApp;
internal class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter the number:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Choose numeral system: bin, hex or oct");
                switch (Console.ReadLine())
                {
                    case "bin":
                    case "ишт":
                    case "2":
                        Converters.ToBinary(number);
                        break;
                    case "hex":
                    case "руч":
                    case "16":
                        Converters.ToHex(number);
                        break;
                    case "oct":
                    case "щсе":
                    case "8":
                        Converters.ToOct(number);
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Such name doesn't exist, try again!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid data. Try again...");
            }
            
        }
    }
}
