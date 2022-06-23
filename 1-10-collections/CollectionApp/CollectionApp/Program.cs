using System;
using System.Collections;
using System.Text;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myArrayList = new MyArrayList<string> {"sjsj", "2", "third"};
            var comparer = new MyArrayListComparer();
            while (true)
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("1. add element to the end of colelction");
                Console.WriteLine("2. insert element according to the index");
                Console.WriteLine("3. replace element by index");
                Console.WriteLine("4. remove all values for collection");
                Console.WriteLine("5. remove value by index");
                Console.WriteLine("6. reverses collection");
                Console.WriteLine("7. sort collection");
                Console.WriteLine("8. clear collection");
                Console.WriteLine("9. find value in collection");
                Console.WriteLine("10. get index of element equal to input value");
                Console.WriteLine("11. add multiple elements to the end of collection");
                Console.WriteLine("12. indexers: get - returns element by index, set - inserts element by index");
                int index;
                switch (Console.ReadLine())
                {
                    case "0":
                        foreach (var item in myArrayList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "1":
                        myArrayList.Add("test");
                        break;
                    case "2":
                        Console.WriteLine("Enter index");
                        if (int.TryParse(Console.ReadLine(), out index))
                            Console.WriteLine("Your index is" + index);
                        else
                        {
                            Console.WriteLine("Invalid data!");
                            break;
                        }
                        Console.WriteLine("Enter value");
                        myArrayList.InsertElementByIndex(index, Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Enter index");
                        try
                        {
                            if (int.TryParse(Console.ReadLine(), out index))
                                Console.WriteLine("Your index is" + index);
                            else Console.WriteLine("Invalid data!");
                            Console.WriteLine("Enter value");
                            var value = Console.ReadLine();
                            myArrayList.ReplaceElementByIndex(index, value);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Wrong index, try again!");
                        }
                        break;
                    case "4":
                        myArrayList.RemoveSimilar("test");
                        break;
                    case "5":
                        Console.WriteLine("Enter index");
                        try
                        {
                            if (int.TryParse(Console.ReadLine(), out index))
                            {
                                Console.WriteLine("Your index is" + index);
                            }
                            else
                            {
                                Console.WriteLine("Invalid data!");
                                break;
                            }
                            myArrayList.RemoveElementByIndex(index);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Wrong index, try again!");
                        }
                        break;
                    case "6":
                        myArrayList.Reverse();
                        break;
                    case "7":
                        myArrayList.Sort(comparer); 
                        break;
                    case "8":
                        myArrayList.Clear();
                        break;
                    case "9":
                        myArrayList.Contain("test");
                        break;
                    case "10":
                        myArrayList.GetIndexOf("test");
                        break;
                    case "11":
                        Console.WriteLine("Enter the number of massive elements...");
                        if (int.TryParse(Console.ReadLine(), out int masLength));
                        else
                        {
                            Console.WriteLine("Invalid data!");
                            break;
                        }
                        string[] addingMassive = new string[masLength];
                        for (int i = 0; i < masLength; i++)
                        {
                            addingMassive[i] = Console.ReadLine();
                        }
                        myArrayList.AddMany(addingMassive);
                        break;
                    case "12":
                        try
                        {
                            if (int.TryParse(Console.ReadLine(), out index))
                                Console.WriteLine("Your index is" + index);
                            else Console.WriteLine("Invalid data!");
                            Console.WriteLine("Enter value");
                            var value = Console.ReadLine();
                            myArrayList.Indexers(index, value);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Wrong index, try again!");
                        }
                        break;
                    case "13":
                        myArrayList.Contain("test", comparer);
                        break;
                    case "14":
                        myArrayList.RemoveSimilar("test", comparer);
                        break;
                    case "15":
                        myArrayList.GetIndexOf("test", comparer);
                        break;
                    case "Exit":
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid data, try again!");
                        break;
                        
                }
                    
            }
        }
    }
}