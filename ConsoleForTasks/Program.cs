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

        static double GetMedian(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }

        static int GetPositiveNumbersCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ++count;
                }
            }

            return count;
        }

        static void ModifyArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = array[i] * -1;
                }
                else
                {
                    array[i] = array[i] * array[i];
                }
            }
        }

        static int GetSumBetweenMinAndMax(int[] array)
        {
            int maxI = 0;
            int minI = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxI])
                {
                    maxI = i;
                }
                if (array[i] < array[minI])
                {
                    minI = i;
                }
            }
            int sum = 0;
            if (maxI < minI)
            {
                int temp = maxI;
                maxI = minI;
                minI = temp;
            }

            for (int i = minI + 1; i < maxI; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static int[] GetArrayWithPositiveNumbers(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }

            if(count == 0)
            {
                return null;
            }

            int[] positiveNumbersArray = new int[count];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    positiveNumbersArray[j++] = array[i];
                }
            }

            return positiveNumbersArray;
        }

        static void Main(string[] args)
        {
            //Ctrl+Shift+Space
            int size = 10;//Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-10, -5);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();

        }
    }
}
