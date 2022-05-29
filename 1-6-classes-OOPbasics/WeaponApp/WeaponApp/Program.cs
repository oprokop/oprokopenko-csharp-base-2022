using System;

namespace WeaponApp
{
    internal class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.WriteLine("Choose your weapon: \n gun \n rifle \n bow");
                Console.WriteLine("\n knife \n sword \n pike \n mace \n");
                Guns gun1 = new Guns();
                gun1.Name = "H&K Glock-17";
                Rifles rifle1 = new Rifles();
                rifle1.Name = "H&K G36";
                Bows bow1 = new Bows();
                bow1.Name = "Bowie";
                Knives knife1 = new Knives();
                knife1.Name = "Knife";
                Swords sword1 = new Swords();
                sword1.Name = "Excalibur";
                Pikes pike1 = new Pikes();
                pike1.Name = "Pike";
                Maces mace1 = new Maces();
                mace1.Name = "Mace";
                switch(Console.ReadLine())
                {
                    case "gun":
                        Console.WriteLine($"You chose" + " " + gun1.Name);
                        break;
                    case "rifle":
                        Console.WriteLine($"You chose" + " " + rifle1.Name);
                        break;
                    case "bow":
                        Console.WriteLine($"You chose" + " " + bow1.Name);
                        break;
                    case "knife":
                        Console.WriteLine($"You chose" + " " + knife1.Name);
                        break;
                    case "sword":
                        Console.WriteLine($"You chose" + " " + sword1.Name);
                        break;
                    case "pike":
                        Console.WriteLine($"You chose" + " " + pike1.Name);
                        break;
                    case "mace":
                        Console.WriteLine($"You chose" + " " + mace1.Name);
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Please make your choise!");
                        break;


                }

            }
            
        }
    }
}
