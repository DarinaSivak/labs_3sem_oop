using System;
using System.Data.SqlTypes;
using System.IO.Enumeration;
using System.Linq;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите размер стека: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] stack1 = new int[n];
            int[] stack2 = new int[n];
            Stack s1 = new Stack(stack1, n);
            s1.In();
            s1.Print();
            
            Console.Write("введите элемент для добавления: ");
            int addEl = Convert.ToInt32(Console.ReadLine());
            s1 = s1 + addEl;
            Console.WriteLine(s1);
            
            Console.Write("введите элемент для удаления: ");
            int remEl = Convert.ToInt32(Console.ReadLine());
            s1 = s1 - remEl;
            Console.WriteLine(s1);

            Console.WriteLine(s1 ? "стек пуст" : "стек содержит элементы");

            Stack s2 = new Stack(stack2, n);
            s2.In();
            s2.Print();
            
            Stack s3 = s1 > s2;
            foreach (int i in s3.DataArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("сумма: " + StatisticOperation.Sum(s1));
            Console.WriteLine("разница макс и мин: " + StatisticOperation.MaxMin(s1));
            Console.WriteLine("количество элементов: " + StatisticOperation.Count(s1));
            
            string str = "hello world today is a good day";
            Console.WriteLine("количество слов: " + str.NumOfWords());
            Console.WriteLine("средний элемент: " + StatisticOperation.AverEl(s1));
        }
    }
}
