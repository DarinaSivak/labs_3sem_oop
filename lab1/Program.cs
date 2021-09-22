using System;
using System.Text;
using System.Linq;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите номер задания: ");
            short a = Convert.ToInt16(Console.ReadLine());
            switch (a) 
            {
                case 1: part1(); break;
                case 2: part2(); break;
                case 3: part3(); break;
                case 4: part4(); break;
                case 6: part6(); break;
            }

            // (int, int, int, char) LocalFunction(int[] arr, string str)
            // {
            //     return (arr.Max(), arr.Min(), arr.Sum(), str[0]);
            // }
            
            // int[] arr1 = { 1, 6, -5, 3, 7, 20, 99, -24 };
            // string txt = "Darina";
            // Console.WriteLine(LocalFunction(arr1,txt));
        }

        static void part1() 
        {
            //2a
            bool a = false;
            byte b = 134;
            sbyte c = -36;
            short d = 45;
            ushort e = 3456;
            int f = 3;
            uint g = 67;
            long h = -5632;
            ulong i = 231;
            float j = 5.999f;
            double k = 34.87;
            decimal l = -64.5m;
            char m = 'w';
            string n = "cat";
            object o = "me me";
            Console.WriteLine($"примитивные типы : {a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}, {i}, {j}, {k}, {l}, {m}, {n}, {o}");

            //2b
            byte bytenum = 6; //неявное приведение
            ushort byteToUshort = bytenum;
            Console.WriteLine(byteToUshort);
            ushort ushortnum = 6;
            uint ushortToUint = ushortnum;
            sbyte sbytenum = -6;
            int sbyteToInt = sbytenum;
            long longnum1 = 34, longnum2 = 3;
            double longToDouble = longnum1 + longnum2;
            float floatnum = 2.3f;
            double floatToDouble = floatnum;

            int integer1 = 12, integer2 = 5; //явное приведение
            byte intToByte = (byte)(integer1 - integer2);
            Console.WriteLine(intToByte);
            double dbnum1 = 7.4d, dbnum2 = 12.7d;
            decimal dbToDecimal = (decimal)(dbnum1/dbnum2);
            float floatnum1 = 2.3f;
            int flToInt = (int)(floatnum1);
            sbyte sbnum1 = 45, sbnum2 = 2;
            ushort sbToUshort = (ushort)(sbnum1*sbnum2);
            long lnum = 56;
            int lToInt = (int)(lnum);

            Console.Write("введите целое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("преобразование string в int: " + num);
            Console.Write("введите дробное число: ");
            float flo = float.Parse(Console.ReadLine());
            Console.WriteLine("преобразование string в float: " + flo);

            int pack = 8; //упаковка и распаковка
            Object object1 = pack;
            int unpack = (int)object1;
            Console.WriteLine(unpack);

            var word = "sunshine"; //неявно типизированная переменная
            var number = 123;
            Console.WriteLine("sunshine тип: " + word.GetType().ToString());
            Console.WriteLine("123 тип: " + number.GetType().ToString());

            int? nul = null; //nullable переменная
            if (nul.HasValue)
            {
                Console.WriteLine(nul.Value);
            }
            else
            {
                Console.WriteLine("nul = null");
            }

            // var abc = 23;
            // abc = 'b';
        }

        static void part2()
        {
            //2a
            Console.WriteLine("wow !");
            Console.WriteLine("рассвет");
            Console.WriteLine("Гораций Уолпол \"Замок Отранто\"");
            Console.WriteLine("red \nflower");

            string strToCompare1 = "hello";
            string strToCompare2 = "bye";

            int result = String.Compare(strToCompare1, strToCompare2);
            if (result < 0)
            {
                Console.WriteLine("строка strToCompare1 перед строкой strToCompare2");
            }
            else if (result > 0)
            {
                Console.WriteLine("строка strToCompare1 после строки strToCompare2");
            }
            else 
            {
                Console.WriteLine("строка strToCompare1 идентична строке strToCompare2");
            }

            //2b
            string str1 = "first"; //конкатенация
            string str2 = "second";
            string str3 = "third";
            string str4 = str1 + " " + str2 + " " + str3;
            Console.WriteLine(str4);
            str4 = String.Concat(str4, "!!!");
            Console.WriteLine(str4);

            char[] buff = new char[10]; //копирование
            str1.CopyTo(0, buff, 0, 0);
            Console.WriteLine(str1);

            char ch = 'o'; //поиск в строке second
            int indexOfChar = str2.IndexOf(ch);
            Console.WriteLine(indexOfChar);

            string text = "разделение строки на массив подстрок"; //разделение строки на массив подстрок
            string[] words = text.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            //string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            str2 = str2.Insert(6, str3); //вставка одной строки в другую
            Console.WriteLine(str2);

            string del = "удаление строки"; //удаление части строки
            int ind = del.Length - 1; //индекс последнего символа
            del = del.Remove(ind);
            Console.WriteLine(del);
            del = del.Remove(0, 2); //первые два символа
            Console.WriteLine(del);

            int cat1 = 3;
            int cat2 = 4;
            Console.WriteLine($"Площадь прямоугольного треугольника с катетами {cat1} и {cat2} равна {0.5 * cat1 * cat2}"); //интерполирование

            //2c
            string s1 = "string"; //метод IsNullOrEmpty для пустых и null строк
            string s2 = "";
            string s3 = null;
            bool res1 = string.IsNullOrEmpty(s1);
            bool res2 = string.IsNullOrEmpty(s2);
            bool res3 = string.IsNullOrEmpty(s3);
            Console.WriteLine("строка s1: " + res1);
            Console.WriteLine("строка s2: " + res2);
            Console.WriteLine("строка s3: " + res3);

            //2d
            StringBuilder sb = new StringBuilder("старая строка");
            Console.WriteLine(sb);
            sb.Remove(0, 7); //удаление
            Console.WriteLine(sb);
            sb.Insert(0, "новая "); //добавление в начало
            Console.WriteLine(sb);
            sb.AppendFormat(" здесь"); //добавление в конец
            Console.WriteLine(sb);
        }

        static void part3()
        {
            //3a
            short[,] arr = new short[,]
            {
                {1, 2, 3, 4, 5 },
                {6, 7, 8, 9, 10 },
                {11, 12, 13, 14, 15 },
                {16, 17, 18, 19, 20 },
                {21, 22, 23, 24, 25 }
            };

            for (short i = 0; i < 5; i++)
            {
                for (short j = 0; j < 5; j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }

            //3b
            string[] strArr = {"one", "two", "three", "four", "five", "six", "seven"};

            foreach(string el in strArr)
            {
                Console.Write($"{el} ");
            }

            Console.WriteLine($"длина массива: {strArr.Length}");

            Console.Write("введите позицию: ");
            short poz = Convert.ToInt16(Console.ReadLine());
            Console.Write("введите новое значение: ");
            string znach = Console.ReadLine();

            strArr[poz] = strArr[poz].Remove(0);
            strArr[poz] = strArr[poz].Insert(0, $"{znach}");

            foreach(string el in strArr)
            {
                Console.Write($"{el} ");
            }
            Console.Write("\nвведите вещественные элементы массива: ");

            //3c
            float[][] jaggedArr = new float[3][];
            jaggedArr[0] = new float[2];
            jaggedArr[1] = new float[3];
            jaggedArr[2] = new float[4];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = float.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int j = 0;
                foreach (int el in jaggedArr[i])
                {
                    Console.Write("\t" + jaggedArr[i][j]);
                    j++;
                }
                Console.WriteLine();
            }

            //3d
            var nontypearr = jaggedArr;
            string nonstr = "bob";
            var nontypestr = nonstr;
        }

        static void part4()
        {
            //4a
            (int, string, char, string, ulong) tuple = (18, "Darina", 'D', "Sivak", 156);

            //4b
            Console.WriteLine(tuple);
            Console.WriteLine($"{tuple.Item1}, {tuple.Item3}, {tuple.Item4}");

            //4c
            var (age, name, firstl, surname, heigh) = tuple;
            Console.WriteLine($"распаковка кортежа в переменные: {firstl}");
            
            //4d
            (short, short) tuple1 = (23, 36);
            (short, short) tuple2 = (17, 31);
            Console.WriteLine($"кортежи равны: {tuple1 == tuple2}");
            Console.WriteLine($"кортежи не равны: {tuple1 != tuple2}");
        }

        static void part6()
        {
            void func1()
            {
                unchecked //делаем переполнение, пропускает ошибку
                {
                    int maxint = 2147483647;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
                return;
            }
            void func2()
            {
                checked //делаем переполнение, не пропускает ошибку
                {
                    int maxint = 2147483647;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
                return;
            }

            Console.Write("введите номер функции: ");
            short swit = Convert.ToInt16(Console.ReadLine());
            switch (swit)
            {
                case 1: func1(); break;
                case 2: func2(); break;
            }
        }
    }
}
