using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Лабораторная_работа_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine(i);
            bool bo = true;
            Console.WriteLine(bo);
            byte by = 2;
            Console.WriteLine(by);
            sbyte sb = 1;
            Console.WriteLine(sb);
            char ch = '2';
            Console.WriteLine(ch);
            decimal de = 2.3m;
            Console.WriteLine(de);
            double dou = 2.33;
            Console.WriteLine(dou);
            float fl = 1.2f;
            Console.WriteLine(fl);
            uint ui = 55;
            Console.WriteLine(ui);
            long lo = 3;
            Console.WriteLine(lo);
            ulong ul = 10;
            Console.WriteLine(ul);
            short sh = 14;
            Console.WriteLine(sh);
            ushort us = 9;
            Console.WriteLine(us);
            object ob = 7;
            Console.WriteLine(ob);
            string st = "Hello";
            Console.WriteLine(st);
            dynamic dy = 1;
            Console.WriteLine(dy);
            

            // Неявные
            int num1 = 1234;
            double NewNum1 = num1;
            Console.WriteLine(NewNum1);
            int num2 = 240;
            long NewNum2 = num2;
            Console.WriteLine(NewNum2);
            float num3 = 2.3f;
            double NewNum3 = num3;
            Console.WriteLine(NewNum3);
            short num4 = 344;
            long Num4 = num4;
            Console.WriteLine(Num4);
            uint num5 = 5;
            float NewNum5 = num5;
            Console.WriteLine(NewNum5);

            // Явные
            byte byte1 = 1;
            sbyte NewByte1;
            NewByte1 = (sbyte)byte1;
            Console.WriteLine(NewByte1);
            int num6 = 2;
            char NewNum6;
            NewNum6 = (char)num6;
            Console.WriteLine(NewNum6);
            decimal num7 = 20.1m;
            float NewNum7;
            NewNum7 = (float)num7;
            Console.WriteLine(NewNum7);
            double num8 = 200.09;
            float NewNum8;
            NewNum8 = (float)num8;
            Console.WriteLine(NewNum8);
            long num9 = 4324243265235325235;
            short NewNum9;
            NewNum9 = (short)num9;
            Console.WriteLine(NewNum9);

            int point = 10;
            Object obj = point; // Операция упаковки
            int points = (int)obj; // Операция распаковки
            Console.WriteLine(obj);
            Console.WriteLine(points);

            var name = "Potapovich Aleksey";
            var age = 19;
            var isProgrammer = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(isProgrammer);

            int? value = null;
            IsNull(value);    // null
            value = 22;
            IsNull(value);    // 22

            void IsNull(int? yo)
            {
                if (yo == null) Console.WriteLine("null");
                else Console.WriteLine(yo);
            }

            var iselse = 4;
            // iselse = "Honey";

            // 2-a
            Console.WriteLine("Hello, Dayv");
            // 2-b
            string s1 = "Hello guys, how are you?";
            string s2 = "We're so good!";
            string s3 = " So nice!";
            string s4 = s1 + " " + s2;
            string s5 = string.Concat(s4, s3);
            Console.WriteLine(s5);
            string s6 = String.Copy(s5);
            Console.WriteLine(s6);
            int startIndex = 6;
            int amount = 8;
            string s7 = s6.Substring(startIndex, amount);
            Console.WriteLine(s7);
            //string[] s9 = s6.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(s9);
            string[] words = s6.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            string s10 = "my dear ";
            s6 = s6.Insert(6, s10);
            Console.WriteLine(s6);
            s6 = s6.Remove(0, 6);
            Console.WriteLine(s6);

            var today = DateTime.Parse("2019-11-09");

            var rus = $"Текущая дата: {today: dd.MM.yyyy}";
            var usa = $"Today: {today: yyyy.MM.dd}";

            Console.WriteLine(rus);
            Console.WriteLine();
            Console.WriteLine(usa);
            Console.WriteLine();
            string svoid = "";
            string snull = null;
            bool stof1 = String.IsNullOrEmpty(svoid);
            bool stof2 = String.IsNullOrEmpty(snull);
            Console.WriteLine(stof1);
            Console.WriteLine(stof2);
            StringBuilder sbm = new StringBuilder("everybody", 55);
            sbm.Insert(0, "Wwassup ");
            sbm.AppendFormat("!");
            sbm.Remove(1, 1);
            Console.WriteLine(sbm);
            // Массивы
            // a
            int[,] array = { { 1, 2, 3 } , { 4, 5, 6 } };
            int rows = array.GetUpperBound(0) + 1;    // количество строк
            int columns = array.Length / rows;        // количество столбцов
            for (int id = 0; id < rows; id++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[id, j]} \t");
                }
                Console.WriteLine();
            }
            // b
            string[] numbers = { "Tom", "Jack", "Peep", "Greg" };
            for (int id2 = 0; id2 < numbers.Length; id2++)
            {
                Console.Write($"{numbers[id2]}\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Длина массива - {numbers.Length}");
            Console.WriteLine("Введите номер элемента, чтобы изменить: ");
            string choice = Console.ReadLine();
            Console.WriteLine("Введите новый элемент: ");
            string paste = Console.ReadLine();
            int inum = Convert.ToInt32(choice);
            for (int id3 = 0; id3 < numbers.Length; id3++)
            {
                if (inum - 1 == id3)
                    numbers[id3] = paste;
            }
            for (int id2 = 0; id2 < numbers.Length; id2++)
            {
                Console.Write($"{numbers[id2]}\t");
            }
            Console.WriteLine();
            // c

            int[][] MyArray = new int[3][];
            MyArray[0] = new int[2];
            MyArray[1] = new int[3];
            MyArray[2] = new int[4];


            for (int x = 0; x < 2; x++)
            {
                string strValue = Console.ReadLine();
                int nummer = Convert.ToInt32(strValue);
                MyArray[0][x] = nummer;
            }

            for (int x = 0; x < 3; x++)
            {
                string strValue = Console.ReadLine();
                int nummer = Convert.ToInt32(strValue);
                MyArray[1][x] = nummer;
            }

            for (int x = 0; x < 4; x++)
            {
                string strValue = Console.ReadLine();
                int nummer = Convert.ToInt32(strValue);
                MyArray[2][x] = nummer;
            }
            for (int x = 0; x < 2; x++)
            {
                Console.Write("{0}\t", MyArray[0][x]);
            }
            Console.WriteLine();
            for (int x = 0; x < 3; x++)
            {
                Console.Write("{0}\t", MyArray[1][x]);
            }
            Console.WriteLine();
            for (int x = 0; x < 4; x++)
            {
                Console.Write("{0}\t", MyArray[2][x]);
            }
            Console.WriteLine();
            // d
            var arrayI = new object[0];
            var str = "";

            // 4
            // a
            (int, string, char, string, ulong) t1 = (10, "hello", 'G', "goodbye", 18);
            Console.WriteLine($"Кортеж с элементами {t1.Item1} и {t1.Item2} и {t1.Item3} и {t1.Item4} и {t1.Item5}.");
            // b
            Console.WriteLine($"Кортеж с элементами {t1.Item1} и {t1.Item3} и {t1.Item4}.");
            // c
            var (names, ages) = ("Tom", 23);
            Console.WriteLine(names);    // Tom
            Console.WriteLine(ages);     // 23
            // d
            var tuple1 = (23, 36);
            var tuple2 = (17, 31);
            Console.WriteLine(tuple1 == tuple2);
            Console.WriteLine(tuple1 != tuple2);

            // 5
            string strTE = "hELLO";
            (int, int, int, char) Localfunction(int[] numberss, string str1)
            {
                int maxNums = 0;
                int minNums = Int32.MaxValue;
                int sumNums = 0;

                for (int ID = 0; ID < numberss.Length; ID++)
                {
                    if (numberss[ID] > maxNums)
                    {
                        maxNums = numberss[ID];
                    }
                    if (numberss[ID] < minNums)
                    {
                        minNums = numberss[ID];
                    }
                    sumNums += numberss[ID];
                }
                char fstStr = strTE[0];
                var tuple1s = (maxNums, minNums, sumNums, fstStr);
                return tuple1s;
            }
            int[] nums = new int[4];
            nums[0] = 20;
            nums[1] = 30;
            nums[2] = 40;
            nums[3] = 100;
            string str2 = "abc";
            Console.WriteLine(Localfunction(nums, str2));

            //// 6
            int upMax = 1;
            int max = Int32.MaxValue;
            int funcUncheck()
            {
                unchecked
                {
                    max = max + upMax;
                    Console.WriteLine(max);
                }
                return max;
            }
            int funcCheck()
            {
                checked
                {
                    max = max + upMax;
                    Console.WriteLine(max);
                }
                return max;
            }
            Console.WriteLine(funcUncheck());
            Console.WriteLine(funcCheck());

            int? nullll = null;
            string strN = null;
            

        }
    }
}

