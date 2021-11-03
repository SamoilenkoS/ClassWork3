using System;

namespace LibraryForTasks
{
    public class ClassWork3
    {
        public static bool Task1(int a)
        {
            return a <= 10;
        }

        public static int Task2(int min)
        {
            int result;
            if (min < 15)
            {
                result = 1;
            }
            else if (min < 30)
            {
                result = 2;
            }
            else if (min < 45)
            {
                result = 3;
            }
            else
            {
                result = 4;
            }

            return result;
        }

        public static bool Task3(double a, double b, double c)
        {
            return
                ((a + b) > c) &&
                ((a + c) > b) &&
                ((b + c) > a);
        }

        public static (double? X1, double? X2) Task4(double a, double b, double c)
        {//null
            double d = b * b - 4 * a * c;
            if (d == 0)//one root
            {
                double x = -b / (2 * a);

                return (x, x);
            }
            else if (d > 0)
            {
                double X1 = (-b + Math.Sqrt(d)) / (2 * a);
                double X2 = (-b - Math.Sqrt(d)) / (2 * a);

                return (X1, X2);
            }
            else
            {
                return (null, null);
            }
        }

        public static bool Task5(int year)
        {
            return year % 4 == 0;
        }

        public static CharType Task6(char c)
        {
            if (char.IsDigit(c))
            {
                return CharType.Digit;
            }
            else if (char.IsLetter(c))
            {
                return CharType.Letter;
            }
            else
            {
                return CharType.Other;
            }
        }

        public static int Task7(int a)
        {
            return (a % 2 == 0 && (a < 10 || a > 20)) ? a * a : a;
        }

        public static int Task8(int a, int b, int c)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            if (a > c)
            {
                int temp = a;
                a = c;
                c = temp;
            }

            return b > c ? c : b;
        }
    }
}
