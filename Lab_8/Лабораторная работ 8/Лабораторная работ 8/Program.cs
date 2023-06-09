using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer("John", "6.124", "JavaScript");
            Programmer p2 = new Programmer("Nikola", "17.1", "Python");
            Programmer p3 = new Programmer("Max", "9.0", "C++");
            Events CE = new Events();

            p1.rename += CE.DoRename;
            p1.newProp += CE.DoNewProp;
            p2.rename += CE.DoRename;


            p1.Action("John", "6.128, 9.0", "JavaScript, C++");
            Console.WriteLine("----------------------------------------");
            p2.Action("Nikola", "17.1", "Python");
            Console.WriteLine("----------------------------------------");
            p3.Action("Maxim", "9.0, 8.21", "C++, C#");
            string str = "Hel.   lo- wo?  r l-d,";
            Func<string, string> A;

            A = Process.RemoveSigns;
            Console.WriteLine($"Без знаков препинания\n{str}\n{A(str)}\n");
            A = Process.RemoveSpace;
            Console.WriteLine($"Убрать пробелы\n{str}\n{A(str)}\n");
            A = Process.UpperCase;
            Console.WriteLine($"Заглавные буквы\n{str}\n{A(str)}\n");
            A = Process.LowerCase;
            Console.WriteLine($"Прописные буквы\n{str}\n{A(str)}\n");
            A = Process.AddSigns;
            Console.WriteLine($"Добавление символов\n{str}\n{A(str)}\n");
        }
    }
}