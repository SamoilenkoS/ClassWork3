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

        static void Main(string[] args)
        {
            // >, <, ==, >=, <=, !=
            // &&, ||, &, |
            CharType charType = ClassWork3.Task6('c');
            switch (charType)
            {
                case CharType.Digit:
                    Console.WriteLine("Digit");
                    break;
                case CharType.Letter:
                    Console.WriteLine("Letter");
                    break;
                case CharType.Other:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
