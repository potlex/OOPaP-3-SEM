using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Set set1 = new Set("PAV", 1, "First Set");
            set1.AddItem("Lera");
            set1.AddItem("Kris");
            set1.prods.Id = 1;
            Set set2 = new Set("AFD", 2, "Second Set");
            set2.AddItem("Lera");
            set2.AddItem(" ");
            set2.AddItem("Max");
            set2.AddItem("Kris");
            set2.AddItem("Pavel");

            Set set3 = new Set("GAG", 3, "Third Set");
            set3.AddItem("Andrey");
            set3.AddItem("Egor");
            set3.AddItem("Max");
            set3.AddItem("Kris");


            Set set4 = new Set("SAJ", 4, "Fourth Set");
            set4.AddItem("Nika");
            set4.AddItem("");
            set4.AddItem("Egor");

            Set.Item it1 = new Set.Item(3);

            Console.WriteLine("--------- Перегрузка оператора ++ ---------"); //удалить элемент из множества
            it1 = it1++;
            set3.Show();
            Console.WriteLine("--------- Перегрузка оператора + ------------"); //пересечение множеств
            Set.Item it4 = it1 + it1;
            set2.Show();

            Console.WriteLine("--------- Перегрузка оператора <= ----------------"); //разница множеств
            bool resultF = set3 <= set1;
            Console.WriteLine(resultF);

            Console.WriteLine("--------- Перегрузка оператора >= ----------------"); //проверка на подмножество
            bool resultS = set1 >= set2;
            Console.WriteLine(resultS);

            Console.WriteLine("--------- Перегрузка оператора мощность множества ----------------"); //сравнение множеств
            set2.GetSizeSet();
            set2.Show();

            Console.WriteLine("------------- Расширение Dif ----------------"); //разница меэжу макс и мин
            set3.Show();
            int e = set3.MaxString();
            Console.WriteLine(e);
            int y = set3.MinString();
            Console.WriteLine(y);
            int r = set3.DefStrings();
            Console.WriteLine(r);

            Console.WriteLine("---------------------------------------------");
        }
    }
}
