using System;
using System.Text.RegularExpressions;

namespace FileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deposits = new List<Deposit>();

            while (true)
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("show. You'll see your current deposits");
                Console.WriteLine("clear. to make your collection empty");
                Console.WriteLine("0.to add another deposit");
                Console.WriteLine("1.to write single object into csv file");
                Console.WriteLine("2.to read single object from csv file");
                Console.WriteLine("3.to write collection of objects into csv file");
                Console.WriteLine("4.to read collection of objects from csv file");
                Console.WriteLine("5.to write single object into json file");
                Console.WriteLine("6.to read single object from json file");
                Console.WriteLine("7.to write collection of objects into json file");
                Console.WriteLine("8.to read collection of objects from json file");
                Console.WriteLine("9.to write single object into xml file");
                Console.WriteLine("10.to read single object from xml file");
                Console.WriteLine("11.to write collection of objects into xml file");
                Console.WriteLine("12.to read collection of objects from xml file");
                Console.WriteLine("13.to read single object from xml file via generic method");
                Console.WriteLine("14.to read collection of objects from xml file via generic method");

                switch (Console.ReadLine())
                {
                    case "show":

                        foreach(var deposit in deposits)
                        {
                            Console.WriteLine(deposit);
                        }

                        break;

                    case "clear":

                        deposits.Clear();
                        Console.WriteLine("Your collection is empty!");
                        break;

                    case "0":

                        var myDeposit = new Deposit();

                        Console.WriteLine("Enter Name of deposit");
                        var depositName = Console.ReadLine();
                        myDeposit.Name = depositName;

                        Console.WriteLine("Enter duration of deposit");
                        if (int.TryParse(Console.ReadLine(), out var depositDuration))
                        {
                            myDeposit.Duration = depositDuration;
                        }
                        else
                        {
                            Console.WriteLine("Wrong data, try again!");
                            break;
                        }

                        Console.WriteLine("Enter percent of profit of deposit");
                        if (double.TryParse(Console.ReadLine(), out var depositPersantage))
                        {
                            myDeposit.PercentProfit = depositPersantage;
                        }
                        else
                        {
                            Console.WriteLine("Wrong data, try again!");
                            break;
                        }

                        Console.WriteLine("Enter if percents of this deposit are monthly capitalized");
                        Console.WriteLine("1 - yes, 0 - no");
                        var answer = Console.ReadLine();
                        if (answer == "1")
                        {
                            myDeposit.IsMonthlyCapitalized = true;
                        }
                        else if (answer == "0")
                        {
                            myDeposit.IsMonthlyCapitalized = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong data, try again!");
                            break;
                        }

                        deposits.Add(myDeposit);
                        break;

                    case "1":

                        Console.WriteLine("Choose the number of deposit you want to write into file");
                       
                        if(int.TryParse(Console.ReadLine(), out int index) && index < deposits.Count)
                        {
                            Console.WriteLine("Enter the name of file in accordance to format CSV");

                            Regex regexToWrite = new(@"[A-Z]?.csv");

                            var fileName = Console.ReadLine();

                            if (regexToWrite.IsMatch(fileName))
                            {
                                FileAction.Write(fileName, deposits[index]);
                            }
                            else
                            {
                                Console.WriteLine("Wrong file name, try again!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong index!!!");
                            break;
                        }
                        break;

                    case "2":

                        Console.WriteLine("Enter the name of file in accordance to format CSV");
                        
                        Regex regexToRead = new Regex(@"[A-Z]?.csv");

                        var fileNameToRead = Console.ReadLine();

                        if (regexToRead.IsMatch(fileNameToRead))
                        {
                            Console.WriteLine(FileAction.Read(fileNameToRead, Deposit.FromString));
                        }
                        break;

                    case "3":

                        Console.WriteLine("Enter the name of file in accordance to format CSV");

                        Regex regexToWriteMany = new(@"[A-Z]?.csv");

                        var fileNameToWriteCsv = Console.ReadLine();

                        if (regexToWriteMany.IsMatch(fileNameToWriteCsv))
                        {
                            FileAction.Write(fileNameToWriteCsv, deposits);
                        }
                        else
                        {
                            Console.WriteLine("Wrong file name, try again!");
                            break;
                        }
                        break;

                    case "4":

                        Console.WriteLine("Enter the name of file in accordance to format CSV");

                        Regex regexToReadMany = new Regex(@"[A-Z]?.csv");

                        var fileNameToReadCsv = Console.ReadLine();

                        if (regexToReadMany.IsMatch(fileNameToReadCsv))
                        {
                            var result = FileAction.ReadMany(fileNameToReadCsv, Deposit.FromString);

                            foreach (var item in result)
                            {
                                Console.WriteLine(item);
                            }
                        }

                        
                        break;

                    case "5":

                        Console.WriteLine("Choose the number of deposit you want to write into file");

                        if (int.TryParse(Console.ReadLine(), out int indexForJson) && indexForJson < deposits.Count)
                        {
                            Console.WriteLine("Enter the name of file in accordance to format json");

                            Regex regexToWriteJson = new(@"[A-Z]?.json");

                            var fileNameJson = Console.ReadLine();

                            if (regexToWriteJson.IsMatch(fileNameJson))
                            {
                                JsonFileAction<Deposit>.Write(deposits[indexForJson], fileNameJson);
                            }
                            else
                            {
                                Console.WriteLine("Wrong file name, try again!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong index!!!");
                            break;
                        }
                        break;

                    case "6":

                        Console.WriteLine("Enter the name of file in accordance to format json");

                        Regex regexToReadFromJson = new Regex(@"[A-Z]?.json");

                        var fileNameToReadFromJson = Console.ReadLine();

                        if (regexToReadFromJson.IsMatch(fileNameToReadFromJson))
                        {
                            Console.WriteLine(JsonFileAction<Deposit>.Read(fileNameToReadFromJson));
                        }
                        break;

                    case "7":

                        Console.WriteLine("Enter the name of file in accordance to format json");

                        Regex regexToWriteManyJson = new(@"[A-Z]?.json");

                        var fileNameToWriteJson = Console.ReadLine();

                        if (regexToWriteManyJson.IsMatch(fileNameToWriteJson))
                        {
                            JsonFileAction<Deposit>.Write(deposits, fileNameToWriteJson);
                        }
                        else
                        {
                            Console.WriteLine("Wrong file name, try again!");
                            break;
                        }
                        break;

                    case "8":

                        Console.WriteLine("Enter the name of file in accordance to format json");

                        Regex regexToReadManyJson = new Regex(@"[A-Z]?.json");

                        var fileNameToReadJson = Console.ReadLine();

                        if (regexToReadManyJson.IsMatch(fileNameToReadJson))
                        {
                            var result = JsonFileAction<Deposit>.ReadMany(fileNameToReadJson);

                            foreach (var item in result)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;

                    case "9":

                        Console.WriteLine("Choose the number of deposit you want to write into file");

                        if (int.TryParse(Console.ReadLine(), out int indexForXml) && indexForXml < deposits.Count)
                        {
                            Console.WriteLine("Enter the name of file in accordance to format xml");

                            Regex regexToWrite = new(@"[A-Z]?.xml");

                            var fileName = Console.ReadLine();

                            if (regexToWrite.IsMatch(fileName))
                            {
                                XmlFileAction.Write(deposits[indexForXml], fileName);
                            }
                            else
                            {
                                Console.WriteLine("Wrong file name, try again!");
                                break;
                            }
                        }
                        break;

                    case "10":

                        Console.WriteLine("Enter the name of file in accordance to format xml");

                        Regex regexToReadFromXml = new Regex(@"[A-Z]?.xml");

                        var fileNameToReadFromXml = Console.ReadLine();

                        if (regexToReadFromXml.IsMatch(fileNameToReadFromXml))
                        {
                            Console.WriteLine(XmlFileAction.Read(fileNameToReadFromXml));
                        }
                        break;

                    case "11":

                        Console.WriteLine("Enter the name of file in accordance to format xml");

                        Regex regexToWriteManyXml = new(@"[A-Z]?.xml");

                        var fileNameToWriteXml = Console.ReadLine();

                        if (regexToWriteManyXml.IsMatch(fileNameToWriteXml))
                        {
                            XmlFileAction.Write(deposits, fileNameToWriteXml);
                        }
                        else
                        {
                            Console.WriteLine("Wrong file name, try again!");
                            break;
                        }
                        break;

                    case "12":

                        Console.WriteLine("Enter the name of file in accordance to format xml");

                        Regex regexToReadManyXml = new Regex(@"[A-Z]?.xml");

                        var fileNameToReadXml = Console.ReadLine();

                        if (regexToReadManyXml.IsMatch(fileNameToReadXml))
                        {
                            var result = XmlFileAction.ReadMany(fileNameToReadXml);

                            foreach (var item in result)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;

                    case "13":

                        Console.WriteLine("Enter the name of file in accordance to format xml");

                        Regex regexToReadFromXmlGeneric = new Regex(@"[A-Z]?.xml");

                        var fileNameToReadFromXmlGeneric = Console.ReadLine();

                        if (regexToReadFromXmlGeneric.IsMatch(fileNameToReadFromXmlGeneric))
                        {
                            XmlGenericFileAction<Deposit>.Read(fileNameToReadFromXmlGeneric);
                        }
                        break;
                    case "14":

                        Console.WriteLine("Enter the name of file in accordance to format xml");

                        Regex regexToReadManyXmlGeneric = new Regex(@"[A-Z]?.xml");

                        var fileNameToReadXmlGeneric = Console.ReadLine();

                        if (regexToReadManyXmlGeneric.IsMatch(fileNameToReadXmlGeneric))
                        {
                            var result = XmlFileAction.ReadMany(fileNameToReadXmlGeneric);

                            foreach (var item in result)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Wrong choice, try again...");
                        break;

                    case "exit":
                        return;
                }
            }
        }
    }
}

