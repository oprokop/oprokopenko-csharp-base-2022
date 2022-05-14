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
                case "int":
                    
                    bool x;
                    bool y;
                    Console.WriteLine("int is chosen");
                    Console.WriteLine("Enter first number");
                    
                    x = int.TryParse(Console.ReadLine(), out int fint);
                    if (x == true)
                        {
                        if (fint != 0)
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
                    y = int.TryParse(Console.ReadLine(), out int sint);
                    if (y == true)
                    {
                        if (sint != 0)
                        {
                            if (fint>sint)
                            {
                                Console.WriteLine("First number is bigger");
                            }
                            else if (fint < sint)
                            {
                                Console.WriteLine("Second number is bigger");
                            }
                            else { Console.WriteLine("Numbers are equal"); }
                            
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



                case "float":

                    Console.WriteLine("float is chosen");
                    Console.WriteLine("Enter first number");

                    x = float.TryParse(Console.ReadLine(), out float ffloat);
                    if (x == true)
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
                   
                    y = float.TryParse(Console.ReadLine(), out float sfloat);
                    if (y == true)
                    {
                        
                        if (sfloat != 0)
                        {
                            if(Math.Abs(ffloat-sfloat) < 0.0001)
                            { 
                                if (ffloat > sfloat)
                                {
                                    Console.WriteLine("First number is bigger");
                                }
                                else if (ffloat < sfloat)
                                {
                                    Console.WriteLine("Second number is bigger");
                                }
                                else { Console.WriteLine("Numbers are equal"); }
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
                                else { Console.WriteLine("Numbers are equal"); }
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

                    x = decimal.TryParse(Console.ReadLine(), out decimal fdec);
                    if (x == true)
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

                    y = decimal.TryParse(Console.ReadLine(), out decimal sdec);
                    if (y == true)
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
                                else { Console.WriteLine("Numbers are equal"); }
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
                                else { Console.WriteLine("Numbers are equal"); }
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

                    x = double.TryParse(Console.ReadLine(), out double fdouble);
                    if (x == true)
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

                    y = double.TryParse(Console.ReadLine(), out double sdouble);
                    if (y == true)
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
                                else { Console.WriteLine("Numbers are equal"); }
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
                                else { Console.WriteLine("Numbers are equal"); }
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

                    x = sbyte.TryParse(Console.ReadLine(), out sbyte fsbyte);
                    if (x == true)
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
                    y = sbyte.TryParse(Console.ReadLine(), out sbyte ssbyte);
                    if (y == true)
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
                            else { Console.WriteLine("Numbers are equal"); }

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

                    x = short.TryParse(Console.ReadLine(), out short fshort);
                    if (x == true)
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
                    y = int.TryParse(Console.ReadLine(), out int sshort);
                    if (y == true)
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
                            else { Console.WriteLine("Numbers are equal"); }

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

                    x = long.TryParse(Console.ReadLine(), out long flong);
                    if (x == true)
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
                    y = long.TryParse(Console.ReadLine(), out long slong);
                    if (y == true)
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
                            else { Console.WriteLine("Numbers are equal"); }

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

                    x = byte.TryParse(Console.ReadLine(), out byte fbyte);
                    if (x == true)
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
                    y = byte.TryParse(Console.ReadLine(), out byte secbyte);
                    if (y == true)
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
                            else { Console.WriteLine("Numbers are equal"); }

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

                    x = ushort.TryParse(Console.ReadLine(), out ushort fushort);
                    if (x == true)
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
                    y = ushort.TryParse(Console.ReadLine(), out ushort sushort);
                    if (y == true)
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
                            else { Console.WriteLine("Numbers are equal"); }

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

                    x = uint.TryParse(Console.ReadLine(), out uint fuint);
                    if (x == true)
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
                    y = uint.TryParse(Console.ReadLine(), out uint suint);
                    if (y == true)
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
                            else { Console.WriteLine("Numbers are equal"); }

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

                    x = ulong.TryParse(Console.ReadLine(), out ulong fulong);
                    if (x == true)
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
                    y = ulong.TryParse(Console.ReadLine(), out ulong sulong);
                    if (y == true)
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
                            else { Console.WriteLine("Numbers are equal"); }

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

        
    }
