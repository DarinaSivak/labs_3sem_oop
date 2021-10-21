using System;
using System.Data.SqlTypes;
using System.IO.Enumeration;
using System.Linq;

namespace lab4
{
    public static class StatisticOperation
    {
        public static int Sum(Stack s1)
        {
            int summa = 0;
            foreach (int a in s1.DataArray)
            {
                summa += a;
            }
            return summa;
        }

        public static int MaxMin(Stack s1)
        {
            int max = s1.DataArray[0], min = s1.DataArray[0];
            foreach (var t in s1.DataArray)
            {
                if (max < t)
                {
                    max = t;
                }
                if (min > t)
                {
                    min = t;
                }
            }

            return max - min;
        }

        public static int Count(Stack s1)
        {
            int res = s1.DataArray.Length;
            return res;
        }

        public static int NumOfWords(this string str)
        {
            int count = 0;
            foreach (var t in str)
            {
                if (t == ' ')
                {
                    count++;
                }
            }

            return count + 1;
        }

        public static int AverEl(Stack s1)
        {
            int count = s1.DataArray.Length/2;
            int aver = s1.DataArray[count];
            return aver;
        }
    }
}