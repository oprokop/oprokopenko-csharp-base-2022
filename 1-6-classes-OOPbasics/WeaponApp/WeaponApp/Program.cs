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
                Gun gun1 = new Gun();
                gun1.Name = "H&K Glock-17";
                Rifle rifle1 = new Rifle();
                rifle1.Name = "H&K G36";
                Bow bow1 = new Bow();
                bow1.Name = "Bowie";
                Knife knife1 = new Knife();
                knife1.Name = "Knife";
                Sword sword1 = new Sword();
                sword1.Name = "Excalibur";
                Pike pike1 = new Pike();
                pike1.Name = "Pike";
                Mace mace1 = new Mace();
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
