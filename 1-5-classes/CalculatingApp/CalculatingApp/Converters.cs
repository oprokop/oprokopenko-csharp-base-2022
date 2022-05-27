using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingApp
{
    public class Converters
    {
        public static void ToBinary(int number)
        {
            if(number >= 2)
            {
                int n = 0;
                int rest;
                for (int number1 = number; number1 >= 2;)
                {
                    if (number1 == 2 || number1 == 3)
                    {
                        n++;
                    }
                    number1 /= 2;
                    n++;
                }
                int[] mas = new int[n];
                for (int j = n - 1; j >= 0; j--)
                {

                    if (j == 0)
                    {
                        mas[0] = 1;
                    }
                    else
                    {
                        rest = number % 2;
                        mas[j] = rest;
                        number /= 2;
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[j]);
                }
                Console.WriteLine();
            }
            else if(number == 1 || number == 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Try again!");
            }

        }
        public static void ToHex(int number)
        {
            if (number >= 16)
            {
                int n = 0;
                int rest;
                for (var number1 = number; number1 >= 16;)
                {
                    if (number1 >= 16 && number1 <= 255)
                    {
                        n++;
                    }
                    number1 /= 16;
                    n++;
                }
                int[] mas = new int[n];
                for (int j = n - 1; j >= 0; j--)
                {

                    if (j == 0)
                    {
                        mas[0] = number;
                    }
                    else
                    {
                        rest = number % 16;
                        mas[j] = rest;
                        number /= 16;
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[j]);
                }
                Console.WriteLine();
            }
            else if (number >= 0 && number <= 9)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
        public static void ToOct(int number)
        {
            if (number >= 8)
            {
                int n = 0;
                int rest;
                for (var number1 = number; number1 >= 8;)
                {
                    if (number1 >= 8 && number1 <= 63)
                    {
                        n++;
                    }
                    number1 /= 8;
                    n++;
                }
                int[] mas = new int[n];
                for (int j = n - 1; j >= 0; j--)
                {

                    if (j == 0)
                    {
                        mas[0] = number;
                    }
                    else
                    {
                        rest = number % 8;
                        mas[j] = rest;
                        number /= 8;
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[j]);
                }
                Console.WriteLine();
            }
            else if(number >= 0 && number <= 7)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}
