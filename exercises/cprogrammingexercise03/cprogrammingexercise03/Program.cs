using System;

namespace cprogrammingexercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool again = true;
                do
                {

                    try
                    {

                        Console.WriteLine("Part 1, circumference and area of a circle.");
                        Console.Write("Enter an integer for the radius: ");
                        string strradius = Console.ReadLine();
                        int intradius = int.Parse(strradius);
                        if (intradius < 0)
                            throw new ArgumentOutOfRangeException();
                        if (intradius == 0)
                            throw new DivideByZeroException();

                        double circumference = 2 * Math.PI * intradius;
                        Console.WriteLine($"the cirumference is {circumference}");
                        double area = Math.PI * (Math.Pow(intradius, 2));
                        Console.WriteLine($"The area is {area}");
                        again = false;
                    }
                    catch (FormatException fEx)
                    {
                        Console.WriteLine(fEx.Message);
                    }
                    catch (ArgumentOutOfRangeException Arg)
                    {
                        Console.WriteLine(Arg.Message);
                    }
                    catch (DivideByZeroException Zer)
                    {
                        Console.WriteLine(Zer.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Your number is ok");
                    }
                } while (again == true);


                bool again2 = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Part 2, volume of a hemisphere.");
                        Console.Write("Enter a number for the radius: ");
                        string xradius = Console.ReadLine();
                        int xntradius = int.Parse(xradius);
                        if (xntradius < 0)
                            throw new ArgumentOutOfRangeException();
                        if (xntradius == 0)
                            throw new DivideByZeroException();
                        double volume = (1.33 * Math.PI * (Math.Pow(xntradius, 3))) / 2;
                        Console.WriteLine($"The volume is {volume}");

                    }

                    catch (FormatException fEx)
                    {
                        Console.WriteLine(fEx.Message);
                    }
                    catch (ArgumentOutOfRangeException Arg)
                    {
                        Console.WriteLine(Arg.Message);
                    }
                    catch (DivideByZeroException Zer)
                    {
                        Console.WriteLine(Zer.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Your number is ok");
                    }
                } while (again2 == true);




                bool again3 = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Part 3, area of a triangle (Heron's Formula).");
                        Console.WriteLine("Please enter a number for side a: ");
                        string strsidea = Console.ReadLine();
                        int intsidea = int.Parse(strsidea);
                        if (intsidea < 0)
                            throw new ArgumentOutOfRangeException();
                        if (intsidea == 0)
                            throw new DivideByZeroException();
                        Console.WriteLine("Please enter a number for side b: ");
                        string strsideb = Console.ReadLine();
                        int intsideb = int.Parse(strsideb);
                        if (intsideb < 0)
                            throw new ArgumentOutOfRangeException();
                        if (intsideb == 0)
                            throw new DivideByZeroException();
                        Console.WriteLine("Please enter a number for side c: ");
                        string strsidec = Console.ReadLine();
                        int intsidec = int.Parse(strsidec);
                        if (intsidec < 0)
                            throw new ArgumentOutOfRangeException();
                        if (intsidec == 0)
                            throw new DivideByZeroException();

                        int P = (intsidea + intsideb + intsidec) / 2;
                        double areaheron = Math.Sqrt(P * (P - intsidea) * (P - intsideb) * (P - intsidec));
                        Console.WriteLine($"The area is {areaheron} ");
                    }
                    catch (FormatException fEx)
                    {
                        Console.WriteLine(fEx.Message);
                    }
                    catch (ArgumentOutOfRangeException Arg)
                    {
                        Console.WriteLine(Arg.Message);
                    }
                    catch (DivideByZeroException Zer)
                    {
                        Console.WriteLine(Zer.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Your number is ok");
                    }
                } while (again3 == true);




                bool again4 = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Part 4, Solving a quadratic equation. ");
                        Console.WriteLine("Please enter a non-negative whole number for coefficient 1: ");
                        string stra = Console.ReadLine();
                        int inta = int.Parse(stra);
                        if (inta < 0)
                            throw new ArgumentOutOfRangeException();
                        if (inta == 0)
                            throw new DivideByZeroException();
                        Console.WriteLine("Please enter a non-negative whole number for coefficient 2: ");
                        string strb = Console.ReadLine();
                        int intb = int.Parse(strb);
                        if (intb < 0)
                            throw new ArgumentOutOfRangeException();
                        if (intb == 0)
                            throw new DivideByZeroException();
                        Console.WriteLine("Please enter a non-negative whole number for coefficient 3: ");
                        string strc = Console.ReadLine();
                        int intc = int.Parse(strc);
                        double denominator = 2 * (inta);
                        double posnum = (-1 * intb) + Math.Sqrt(Math.Pow(intb, 2) - 4 * (inta) * (intc)) / denominator;
                        double negnum = (-1 * intb) - Math.Sqrt(Math.Pow(intb, 2) - 4 * (inta) * (intc)) / denominator;
                        Console.WriteLine($"The positive result is {posnum}, the negative result is {negnum} ");
                    }
                    catch (FormatException fEx)
                    {
                        Console.WriteLine(fEx.Message);
                    }
                    catch (ArgumentOutOfRangeException Arg)
                    {
                        Console.WriteLine(Arg.Message);
                    }
                    catch (DivideByZeroException Zer)
                    {
                        Console.WriteLine(Zer.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Your number is ok");
                    }
                } while (again4 == true);

            }
        }


    }
}