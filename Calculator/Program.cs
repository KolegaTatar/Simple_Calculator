﻿namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("         Menu");
                Console.WriteLine();
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Out");
                Console.WriteLine();
                Console.Write("Your chose: ");
                int chose = int.Parse(Console.ReadLine());

                if(chose == 1)
                {
                    Console.WriteLine("Calculator Menu");
                    Console.WriteLine();
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Divide");
                    Console.WriteLine("5. Out");
                    Console.WriteLine();
                    Console.Write("Your chose: ");
                    int chose2=int.Parse(Console.ReadLine());

                    if( chose2 == 1)
                    {

                    }
                    if(chose2 == 2)
                    {

                    }
                    if (chose2 == 3)
                    {

                    }
                    if (chose2 == 4)
                    {

                    }
                    if(chose2 == 5)
                    {
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("wrong number");
                    }
                }
                if(chose == 2)
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("Wrong anwser");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Thx for using this calculate");
        }
    }
}