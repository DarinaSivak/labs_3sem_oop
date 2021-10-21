using System;
using System.Data.SqlTypes;
using System.IO.Enumeration;
using System.Linq;

namespace lab4
{
    public class Stack
    {
        public int[] DataArray; //данные стека
        private int sizeArray;

        public Stack(int[] a, int sizeArray)
        {
            DataArray = a;
            this.sizeArray = sizeArray;
        }

        public void In()
        {
            int count = 0;
            Console.Write("введите элементы стека: ");
            for (int i = 0; i < sizeArray; i++)
            {
                DataArray[i] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine("стек пуст !");
            }
        }

        public void Print()
        {
            Console.Write("вывод элементов стека: ");
            int count = 0;
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write(DataArray[i] + " ");
                count++;
            }
            
            Console.WriteLine();

            if (count == 0)
            {
                Console.WriteLine("стек пуст !");
            }
        }
        
        public static Stack operator +(Stack s1, int newEl)
        {
            s1.DataArray[s1.DataArray.Length + 1] = newEl;
            return s1;
        }

        public static Stack operator -(Stack s1, int numOfEl)
        {
            Stack s2 = new Stack(new int[s1.DataArray.Length], s1.DataArray.Length);
            int i = 0;
            foreach (int element in s1.DataArray)
            {
                if (element != numOfEl)
                {
                    s2.DataArray[i] = s1.DataArray[element];
                    i++;
                }
            }

            return s2;
        }

        public static bool operator true(Stack s1)
        {
            return (s1.DataArray.Length == 0);

        }

        public static bool operator false(Stack s1)
        {
            return (s1.DataArray.Length > 0);
        }

        public static Stack operator >(Stack s1, Stack s2)
        {
            int[] newStack = new int[s1.DataArray.Length + s2.DataArray.Length];
            for (int i = 0; i < s1.DataArray.Length; i++)
            {
                newStack[i] = s1.DataArray[i];
            }

            int j = 0;
            for (int i = s1.DataArray.Length; i < s1.DataArray.Length + s2.DataArray.Length; i++)
            {
                newStack[i] = s2.DataArray[j];
                j++;
            }

            for (int i = 0; i < newStack.Length; i++)
            {
                for (int l = 0; l < newStack.Length - 1; l++)
                {
                    if (newStack[l] > newStack[l + 1])
                    {
                        (newStack[l], newStack[l + 1]) = (newStack[l + 1], newStack[l]);
                    }
                }
            }

            return new Stack(newStack, newStack.Length);
        }
        
        public static Stack operator <(Stack s1, Stack s2)
        {
            int[] newStack = new int[s1.DataArray.Length + s2.DataArray.Length];
            for (int i = 0; i < s1.DataArray.Length; i++)
            {
                newStack[i] = s1.DataArray[i];
            }

            int j = 0;
            for (int i = s1.DataArray.Length; i < s1.DataArray.Length + s2.DataArray.Length; i++)
            {
                newStack[i] = s2.DataArray[j];
                j++;
            }

            return new Stack(newStack, newStack.Length);
        }
    }

    class Owner
    {
        private int id;
        private int ID { get; set; }
        private string name;
        private string Name { get; set; }
        private string organization;
        private string Organization { get; set; }
    
        public Owner(int id, string name, string organization)
        {
            ID = id;
            Name = name;
            Organization = organization;
        }
    }
    
    class Date
    {
        private int day;

        private int Day
        {
            set
            {
                if (value is > 0 and < 31)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("неверно введенные данные");
                }
            }
            get => day;
        }
        private int month;

        private int Month
        {
            set
            {
                if (value is > 0 and < 12)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("неверно введенные данные");
                }
            }
            get => month;
        }
        private int year;

        private int Year
        {
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("неверно введенные данные");
                }
            }
            get => year;
        }
    
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
}