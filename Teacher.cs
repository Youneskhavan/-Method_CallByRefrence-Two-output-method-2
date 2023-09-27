using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_by_refrence
{
    internal static class Teacher
    {

        public static void AvgSum(int a, int b, int c, out int Sum, out int Avg)
        {
            Sum = 0;
            Avg = 0;

            Sum = a + b + c;
            Avg = Sum / 3;
        }


    }
}
