namespace LibraryForTasks
{
    public class HomeWork2
    {
        public static double Task1(int a, int b)
        {
            return (5 * a + b * b) / (b - a);
        }

        public static void Task2(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public static(double division, double reminder) Task3(double a, double b)
        {
            return (a / b, a % b);
        }

        public static double Task4(double a, double b, double c)
        {
            return (c - b) / a;
        }

        public static(double valueA, double valueB) Task5(
            double X1,
            double Y1,
            double X2,
            double Y2)
        {
            double X = (Y1 - Y2) / (X1 - X2);
            return (X, Y2 - X * X2);
        }
    }
}
