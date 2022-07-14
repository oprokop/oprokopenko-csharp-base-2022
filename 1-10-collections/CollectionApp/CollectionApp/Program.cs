using System;
using System.Collections;
using System.Text;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myArrayList = new MyArrayList<string> {};
            var comparer = new MyArrayListComparer();
            while (true)
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("0. show array");
                Console.WriteLine("1. add element to the end of colelction");
                Console.WriteLine("2. insert element according to the index");
                Console.WriteLine("3. replace element by index");
                Console.WriteLine("4. remove all such values for collection");
                Console.WriteLine("5. remove value by index");
                Console.WriteLine("6. reverses collection");
                Console.WriteLine("7. sort collection");
                Console.WriteLine("8. clear collection");
                Console.WriteLine("9. if value is in collection");
                Console.WriteLine("10. get index of element equal to input value");
                Console.WriteLine("11. add multiple elements to the end of collection");
                Console.WriteLine("12. indexers: get - returns element by index, set - inserts element by index");
                Console.WriteLine("13. if value is in collection with Comparer");
                Console.WriteLine("14. remove all such values for collection with Comparer");
                Console.WriteLine("15. indexers with Comparer: get - returns element by index, set - inserts element by index");
                Console.WriteLine("16. if value is in collection with delegate");
                Console.WriteLine("17. remove all such values for collection with delegate");
                Console.WriteLine("18. get index of element equal to input value with delegate");
                Console.WriteLine("19. sort collection with delegate");
                Console.WriteLine("20. update");
                Console.WriteLine("21. update with conditions");
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
                        Console.WriteLine("Enter value");
                        var valueToAdd = Console.ReadLine();
                        myArrayList.Add(valueToAdd);
                        break;
                    case "2":
                        Console.WriteLine("Enter index");
                        try
                        {
                            if (int.TryParse(Console.ReadLine(), out index))
                                Console.WriteLine("Your index is " + index);
                            else
                            {
                                Console.WriteLine("Invalid data!");
                                break;
                            }
                            Console.WriteLine("Enter value");
                            myArrayList.InsertElementByIndex(index, Console.ReadLine());
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Wrong index, try again!");
                            break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter index");
                        try
                        {
                            if (int.TryParse(Console.ReadLine(), out index))
                                Console.WriteLine("Your index is " + index);
                            else Console.WriteLine("Invalid data!");
                            Console.WriteLine("Enter value");
                            var value = Console.ReadLine();
                            myArrayList.ReplaceElementByIndex(index, value);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Wrong index, try again!");
                            break;
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
                        myArrayList.Contain("test9");
                        break;
                    case "10":
                        myArrayList.GetIndexOf("test10");
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
                        myArrayList.Contain("test13", comparer);
                        break;
                    case "14":
                        myArrayList.RemoveSimilar("test14", comparer);
                        break;
                    case "15":
                        myArrayList.GetIndexOf("test15", comparer);
                        break;
                    case "16":
                        Console.WriteLine("Enter the value");
                        myArrayList.Contain(Console.ReadLine(), ValueCompare);
                        break;
                    case "17":
                        Console.WriteLine("Enter the value");
                        myArrayList.RemoveSimilar(Console.ReadLine(), ValueCompare);
                        break;
                    case "18":
                        Console.WriteLine("Enter the value");
                        myArrayList.GetIndexOf(Console.ReadLine(), ValueCompare);
                        break;
                    case "19":
                        myArrayList.Sort((left, right) => left.CompareTo(right));
                        break;
                    case "20":
                        myArrayList.Update(ToUpper);
                        break;
                    case "21":
                        myArrayList.ConditionalUpdate(ToUpper, element => element.Length < 4);
                        break;
                    case "Exit":
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid data, try again!");
                        break;
                        
                }
            }
            static int ValueCompare(string left, string right)
            {
                return left.CompareTo(right);
            }
            static void ToUpper(string element)
            {
                Console.WriteLine(element.ToUpper());
            }
        }
    }
}