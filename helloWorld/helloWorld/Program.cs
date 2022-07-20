using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop & Control Statement");

            //if statement
            Console.WriteLine("Enter age of user:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Valid Driver");
            }
            else
            {
                Console.WriteLine("Underage");
            }


            //Nested if else 
            Console.WriteLine("Enter no:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");

                if (number % 4 == 0)
                {
                    Console.WriteLine("and is divisible by 4");
                }
                else
                {
                    Console.WriteLine("cannot be divisible by 4");
                }
            }
            else
            {
                Console.WriteLine("Number is odd");
                if (number % 3 == 0)
                {
                    Console.WriteLine("and is divisible by 3");
                }
                else
                {
                    Console.WriteLine("cannot be divisible by 3");
                }
            }

            //for loop

            string[] cars = { "Audi", "Mercedes", "Jaguar" };
            Console.WriteLine("------For Loop------");
            Console.WriteLine("Cars List:");
            Array.Reverse(cars);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //for each loop
            Console.WriteLine("------ForEach Loop------");
            foreach (string a in cars)
            {
                Console.WriteLine(a);
            }

            // While Loop
            Console.WriteLine("------While loop-----");
            int j = 0;
            while (j < cars.Length)
            {
                Console.WriteLine(cars[j]);
                j++;
            }

            //do while
            Console.WriteLine("------Do While Loop------");
            int num = 0;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num < 5);


            //Switch Case
            Console.WriteLine("Enter a number for week:");
            int week = Convert.ToInt32(Console.ReadLine());
            switch (week)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 to 7");
                    break;
            }
            Console.ReadLine();
        }
    }
}
