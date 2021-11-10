using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForTasks
{
    public class ClassWork5
    {
        public static double Task3(double A)
        {
            double count = 0;
            while(count * count < A)
            {
                ++count;
            }

            return count != 0 ? count - 1 : count;
        }

        public static double Task4(int A)
        {
            Task3(A);
            double divider = 0;
            if(A % 2 == 0)
            {
                return A / 2;
            }
            for (int i = A / 2; i >= 1; i--)
            {
                if ((A % i) == 0)
                {
                    divider = i;
                    break;
                }
            }

            return divider;
        }

        public static int AtoPowerB(int A, int B)
        {
            Task4(A);
            for (int i = 1; i < B; i++)
            {
                A *= A;
            }

            return A;
        }
    }
}
