using LibraryForTasks;
using System;

namespace ConsoleForTasks
{
    class Program
    {
        public static void Task2(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public static void TestGeneral(string a)
        {

        }

        public static void GenerateFullName(
            in string firstName,
            in string lastName,
            out string fullName)
        {
            fullName = firstName + lastName;
        }

        static void Menu()
        {
            int userChoise = Convert.ToInt32(Console.ReadLine());
            switch (userChoise)
            {
                case 1:
                    //Task1();
                    break;
                case 2:
                    //Task2();
                    break;
                case 3:
                    //Task3();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("No action");
                    break;
            }
        }

        static void MultiplicationTable()
        {
            for (int j = 2; j <= 9; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{j}*{i}={j * i}");
                }
            }
        }

        static void ASCIITable()
        {
            for (int i = 0; i <= 128; i++)
            {
                Console.WriteLine($"{i} = {(char)i}");
            }
        }

        static void SumFromAToBMultipliedByN()
        {
            int a = Convert.ToInt32(Console.ReadLine());//1
            int b = Convert.ToInt32(Console.ReadLine());//99999
            int n = Convert.ToInt32(Console.ReadLine());//3
            //Find sum of numbers from A to B which multiples of N
            if (n != 0)
            {
                int sum = 0;
                a += (a % n != 0) ? (n - (a % n)) : 0;
                for (; a <= b; a += n)
                {
                    sum += a;
                }

                Console.WriteLine(sum);
            }
        }

        static void IceCreamCountAndReminder()
        {
            double N = Convert.ToDouble(Console.ReadLine());
            double K = Convert.ToDouble(Console.ReadLine());
            int count = 0;

            while (N >= K)
            {
                N -= K;
                ++count;
            }

            Console.WriteLine($"{N} money remain.");
            Console.WriteLine($"{count} ice creams could be bought.");
        }

        static void Main(string[] args)
        {
            int userInput;
            do
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        IceCreamCountAndReminder();
                        break;
                    case 2:
                        SumFromAToBMultipliedByN();
                        break;
                    case 0:
                        break;
                }
            } while (userInput != 0);
        }
    }
}
