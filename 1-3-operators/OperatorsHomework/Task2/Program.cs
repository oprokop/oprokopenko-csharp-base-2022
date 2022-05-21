﻿using System;

namespace HardApp;
internal class Program
{
    public static void Main()
    {
        int[] masstest = new int[1];
        while (true)
        {
            //int[] masstest = new int[1];
            Console.WriteLine("\nСhoose option: \n 1. Enter array \n 2. Show array: in line");
            Console.WriteLine(" 3. Bubble sort \n 4. Sum of all elements \n 5. Multiplexing of all elements");
            Console.WriteLine(" 6. The biggest and the lowest elements \n 7. Reverse array \n 8. Add element by index");
            Console.WriteLine(" 9. Remove elements by index \n Or just type <exit>");
            
            if (int.TryParse(Console.ReadLine(), out int point))
            {
                if (point != 1)
                {
                    Console.WriteLine("You haven't entered array yet, press 1");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter count of array elements");
                    if (int.TryParse(Console.ReadLine(), out var length) && length > 0)
                    {
                        Console.WriteLine("Enter numbers one by one:");
                        masstest = MassEnter(length);
                    }
                    else
                    {
                        Console.WriteLine("Invalid data");
                        break;
                    }
                }
                
                while (true)
                {
                    Console.WriteLine("Now choose the array action (2-9)");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            break;
                        //    Console.WriteLine("Enter count of array elements");
                        //    if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
                        //    {
                        //        Console.WriteLine("Enter numbers one by one:");
                        //        masstest = MassEnter(length);
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Invalid data");
                        //        break;
                        //    }
                        //    break;
                        case "2":
                            Console.WriteLine("Your massive is ");
                            MassShow(masstest);
                            break;
                        case "3":
                            BubbleSorting(masstest);
                            Console.WriteLine("Your sorted massive is");
                            for (int i = 0; i < masstest.Length; i++)
                            {
                                Console.Write(masstest[i]);
                            }
                            Console.WriteLine("\n");
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        case "7":
                            break;
                        case "8":
                            break;
                        case "9":
                            break;
                        case "exit":
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }

                }




            }

        }
    }
    public static int[] MassEnter(int length)
    {
        int[] mas = new int[length];
        for (int n = 0; n < length; n++)
        {
            Console.WriteLine($"Enter {n} element of array");
            mas[n] = EnterNumber();
        }
        //Console.WriteLine("Now choose the array action (2-9)");
        return mas;
    }
    static int EnterNumber()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                return n;
            }
            else
            {
                Console.WriteLine("Invalid data, try again");
            }
        }
    }
    public static void MassShow(int[] masstest)
    {
        for (int n = 0; n < masstest.Length; n++)
        {
            Console.Write(masstest[n]);
        }
        Console.WriteLine("\n");
    }
    public static int[] BubbleSorting(int[] masstest)
    {
        int help;
        for (var i = 0; i < masstest.Length; i++)
        {
            for (var j = i+1; j < masstest.Length; j++)
            {
                if (masstest[i] > masstest[j])
                {
                    help = masstest[i];
                    masstest[i] = masstest[j];
                    masstest[j] = help;

                }
            }
        }
        return masstest;
    }
}


