﻿Console.Write("Enter the number of the day: ");
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1: Console.WriteLine("Monday");
                            break;
                        case 2: Console.WriteLine("Tuesday");
                            break;
                        case 3: Console.WriteLine("Wednsday");
                            break;
                        case 4: Console.WriteLine("Thursday");
                            break;
                        case 5: Console.WriteLine("Friday");
                            break;
                        case 6: Console.WriteLine("Saturday");
                            break;
                        case 7: Console.WriteLine("Sunday");
                            break;
                        default:
                            Console.WriteLine("This number of day  doesnt exists");
                            break;
                    }
                }
            catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }