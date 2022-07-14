using System;
using System.Text.RegularExpressions;

namespace FileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDeposit = new Deposit 
            { 
                Name = "Deposit", 
                Duration = 12, 
                PercentProfit = 7.5 
            };

            var deposits = new List<Deposit>
            {
                new Deposit{Name = "LongDeposit", Duration = 12, PercentProfit = 6.9 },
                new Deposit{Name = "ShortDeposit", Duration = 3, PercentProfit = 5.9 },
                new Deposit{Name = "IrrevocableLongDeposit", Duration = 12, PercentProfit = 7.5, IsMonthlyCapitalized = true},
                new Deposit{Name = "IrrevocableShortDeposit", Duration = 3, PercentProfit = 6.5, IsMonthlyCapitalized = true},
                new Deposit{Name = "SuperLongDeposit", Duration = 24, PercentProfit = 7.9 },
            };

            while (true)
            {
                Console.WriteLine("Choose action:");
                Console.WriteLine("1.to write single object into file");
                Console.WriteLine("2.to read single object from file");
                Console.WriteLine("3.to write collection of objects into file");
                Console.WriteLine("4.to read collection of objects from file");

                switch (Console.ReadLine())
                {
                    case "1":

                        Console.WriteLine("Enter the name of file in accordance to format CSV");

                        Regex regexToWrite = new(@"[A-Z]?.csv");

                        var fileName = Console.ReadLine();

                        if (regexToWrite.IsMatch(fileName))
                        {
                            FileAction.Write(fileName, myDeposit);
                        }
                        else
                        {
                            Console.WriteLine("Wrong file name, try again!");
                            break;
                        }
                        break;

                    case "2":

                        Console.WriteLine("Enter the name of file in accordance to format CSV");
                        
                        Regex regexToRead = new (@"[A-Z]?.csv");

                        var fileNameToRead = Console.ReadLine();

                        if (regexToRead.IsMatch(fileNameToRead))
                        {
                            Console.WriteLine(FileAction.Read(fileNameToRead, Deposit.FromString));
                        }
                        
                        break;

                    case "3":

                        FileAction.Write("list.csv", deposits);

                        break;

                    case "4":

                        var result = FileAction.ReadMany("list.csv", Deposit.FromString);
                        
                        foreach(var item in result)
                        {
                            Console.WriteLine(item);
                        }
                       
                        break;

                    case "exit":

                        return;

                }
            }
        }
    }
}

