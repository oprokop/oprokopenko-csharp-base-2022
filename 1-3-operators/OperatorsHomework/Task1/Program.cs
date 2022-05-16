using System;

namespace SimpleApp;
    internal class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter number type");
                switch (Console.ReadLine())
                {
                    case "int": Intcase();
                        break;
                    case "float":
                        Console.WriteLine("float is chosen");
                        Console.WriteLine("Enter first number");
                        if (float.TryParse(Console.ReadLine(), out float ffloat))
                        {
                            if (ffloat != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (float.TryParse(Console.ReadLine(), out float sfloat))
                        {
                            if (sfloat != 0)
                            {
                                if(Math.Abs(ffloat - sfloat) < 0.0001)
                                { 
                                    if (ffloat > sfloat)
                                    {
                                        Console.WriteLine("First number is bigger");
                                    }
                                    else if (ffloat < sfloat)
                                    {
                                        Console.WriteLine("Second number is bigger");
                                    }
                                    else 
                                    { 
                                        Console.WriteLine("Numbers are equal"); 
                                    }
                                }
                                else
                                {
                                    if (Math.Round(ffloat, 4) > Math.Round(sfloat, 4))
                                    {
                                        Console.WriteLine("First number is bigger");
                                    }
                                    else if (Math.Round(ffloat, 4) < Math.Round(sfloat, 4))
                                    {
                                        Console.WriteLine("Second number is bigger");
                                    }
                                    else 
                                    { 
                                        Console.WriteLine("Numbers are equal"); 
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "decimal":
                        Console.WriteLine("decimal is chosen");
                        Console.WriteLine("Enter first number");
                        if (decimal.TryParse(Console.ReadLine(), out decimal fdec))
                        {
                            if (fdec != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (decimal.TryParse(Console.ReadLine(), out decimal sdec))
                        {
                            if (sdec != 0)
                            {
                                if (Math.Abs(fdec - sdec) < 0.0001m)
                                {
                                    if (fdec > sdec)
                                    {
                                        Console.WriteLine("First number is bigger");
                                    }
                                    else if (fdec < sdec)
                                    {
                                        Console.WriteLine("Second number is bigger");
                                    }
                                    else 
                                    { 
                                        Console.WriteLine("Numbers are equal"); 
                                    }
                                }
                                else
                                {
                                    if (Math.Round(fdec, 4) > Math.Round(sdec, 4))
                                    {
                                        Console.WriteLine("First number is bigger");
                                    }
                                    else if (Math.Round(fdec, 4) < Math.Round(sdec, 4))
                                    {
                                        Console.WriteLine("Second number is bigger");
                                    }
                                    else 
                                    { 
                                        Console.WriteLine("Numbers are equal"); 
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;

                    case "double":
                        Console.WriteLine("double is chosen");
                        Console.WriteLine("Enter first number");
                        if (double.TryParse(Console.ReadLine(), out double fdouble))
                        {
                            if (fdouble != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (double.TryParse(Console.ReadLine(), out double sdouble))
                        {
                            if (sdouble != 0)
                            {
                                if (Math.Abs(fdouble - sdouble) < 0.0001)
                                {
                                    if (fdouble > sdouble)
                                    {
                                        Console.WriteLine("First number is bigger");
                                    }
                                    else if (fdouble < sdouble)
                                    {
                                        Console.WriteLine("Second number is bigger");
                                    }
                                    else 
                                    { 
                                        Console.WriteLine("Numbers are equal"); 
                                    }
                                }
                                else
                                {
                                    if (Math.Round(fdouble, 4) > Math.Round(sdouble, 4))
                                    {
                                        Console.WriteLine("First number is bigger");
                                    }
                                    else if (Math.Round(fdouble, 4) < Math.Round(sdouble, 4))
                                    {
                                        Console.WriteLine("Second number is bigger");
                                    }
                                    else 
                                    { 
                                        Console.WriteLine("Numbers are equal"); 
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "sbyte":
                        Console.WriteLine("sbyte is chosen");
                        Console.WriteLine("Enter first number");
                        if (sbyte.TryParse(Console.ReadLine(), out sbyte fsbyte))
                        {
                            if (fsbyte != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (sbyte.TryParse(Console.ReadLine(), out sbyte ssbyte))
                        {
                            if (ssbyte != 0)
                            {
                                if (fsbyte > ssbyte)
                                {
                                    Console.WriteLine("First number is bigger");
                                }
                                else if (fsbyte < ssbyte)
                                {
                                    Console.WriteLine("Second number is bigger");
                                }
                                else 
                                { 
                                    Console.WriteLine("Numbers are equal"); 
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "short":
                        Console.WriteLine("short is chosen");
                        Console.WriteLine("Enter first number");
                        if (short.TryParse(Console.ReadLine(), out short fshort))
                        {
                            if (fshort != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (int.TryParse(Console.ReadLine(), out int sshort))
                        {
                            if (sshort != 0)
                            {
                                if (fshort > sshort)
                                {
                                    Console.WriteLine("First number is bigger");
                                }
                                else if (fshort < sshort)
                                {
                                    Console.WriteLine("Second number is bigger");
                                }
                                else 
                                { 
                                    Console.WriteLine("Numbers are equal"); 
                                }

                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "long":
                        Console.WriteLine("long is chosen");
                        Console.WriteLine("Enter first number");
                        if (long.TryParse(Console.ReadLine(), out long flong))
                        {
                            if (flong != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (long.TryParse(Console.ReadLine(), out long slong))
                        {
                            if (slong != 0)
                            {
                                if (flong > slong)
                                {
                                    Console.WriteLine("First number is bigger");
                                }
                                else if (flong < slong)
                                {
                                    Console.WriteLine("Second number is bigger");
                                }
                                else 
                                { 
                                    Console.WriteLine("Numbers are equal"); 
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "byte":
                        Console.WriteLine("byte is chosen");
                        Console.WriteLine("Enter first number");
                        if (byte.TryParse(Console.ReadLine(), out byte fbyte))
                        {
                            if (fbyte != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (byte.TryParse(Console.ReadLine(), out byte secbyte))
                        {
                            if (secbyte != 0)
                            {
                                if (fbyte > secbyte)
                                {
                                    Console.WriteLine("First number is bigger");
                                }
                                else if (fbyte < secbyte)
                                {
                                    Console.WriteLine("Second number is bigger");
                                }
                                else 
                                { 
                                    Console.WriteLine("Numbers are equal"); 
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "ushort":
                        Console.WriteLine("ushort is chosen");
                        Console.WriteLine("Enter first number");
                        if (ushort.TryParse(Console.ReadLine(), out ushort fushort))
                        {
                            if (fushort != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (ushort.TryParse(Console.ReadLine(), out ushort sushort))
                        {
                            if (sushort != 0)
                            {
                                if (fushort > sushort)
                                {
                                    Console.WriteLine("First number is bigger");
                                }
                                else if (fushort < sushort)
                                {
                                    Console.WriteLine("Second number is bigger");
                                }
                                else 
                                { 
                                    Console.WriteLine("Numbers are equal"); 
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "uint":
                        Console.WriteLine("uint is chosen");
                        Console.WriteLine("Enter first number");
                        if (uint.TryParse(Console.ReadLine(), out uint fuint))
                        {
                            if (fuint != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (uint.TryParse(Console.ReadLine(), out uint suint))
                        {
                            if (suint != 0)
                            {
                                if (fuint > suint)
                                {
                                    Console.WriteLine("First number is bigger");
                                }
                                else if (fuint < suint)
                                {
                                    Console.WriteLine("Second number is bigger");
                                }
                                else 
                                { 
                                    Console.WriteLine("Numbers are equal"); 
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "ulong":
                        Console.WriteLine("ulong is chosen");
                        Console.WriteLine("Enter first number");
                        if (ulong.TryParse(Console.ReadLine(), out ulong fulong))
                        {
                            if (fulong != 0)
                            {
                                Console.WriteLine("Enter second number");
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        if (ulong.TryParse(Console.ReadLine(), out ulong sulong))
                        {
                            if (sulong != 0)
                            {
                                if (fulong > sulong)
                                {
                                    Console.WriteLine("First number is bigger");
                                }
                                else if (fulong < sulong)
                                {
                                    Console.WriteLine("Second number is bigger");
                                }
                                else 
                                { 
                                    Console.WriteLine("Numbers are equal"); 
                                }
                            }
                            else
                            {
                                Console.WriteLine("Value must be not null");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid data");
                            break;
                        }
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect type");
                        break;
                }
            }
        }
        static void Intcase()
        {
            Markint:
            Console.WriteLine("int is chosen");
            Console.WriteLine("Enter first number");
            if (int.TryParse(Console.ReadLine(), out int fint))
            {
                if (fint != 0)
                {
                    Console.WriteLine("Enter second number");
                }
                else
                {
                    Console.WriteLine("Value must be not null");
                    goto Markint;
                }
            }
            else
            {
                Console.WriteLine("Invalid data");
                goto Markint;
            }
            if (int.TryParse(Console.ReadLine(), out int sint))
            {
                if (sint != 0)
                {
                    if (fint > sint)
                    {
                        Console.WriteLine("First number is bigger");
                    }
                    else if (fint < sint)
                    {
                        Console.WriteLine("Second number is bigger");
                    }
                    else
                    {
                        Console.WriteLine("Numbers are equal");
                    }
                }
                else
                {
                    Console.WriteLine("Value must be not null");
                    goto Markint;
                }
            }
            else
            {
                Console.WriteLine("Invalid data");
                goto Markint;
            }
        
        }
        
    }
