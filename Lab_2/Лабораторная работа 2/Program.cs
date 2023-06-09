using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_2
{
    class Program
    {
        static void Main(string[] args)
        {
            House Airhome = new House(4, 141, 80.5, 23, 4, "Полевая", "Небоскрёб", 35);
            House West = new House(6, 54, 38, 9, 2, "Горецкого", "Панельный", 60);
            House NewLine = new House(6, 17, 19, 3, 1, "Гагарина", "Лесенка", 25);

            Airhome.GetInfo();
            Console.WriteLine(Airhome.Equals(West));
            Airhome.GetHashCode();
            Console.WriteLine(Airhome.ToString());

            int x = 1990; 
            Airhome.HouseAge(ref x); 
            Console.WriteLine("Возраст здания: " + x);
            int y;
            int zz = 54;
            Airhome.HouseDate(out y, ref zz);
            Console.WriteLine("Год строительства: " + y);


            House.Array();
            var home = new { flat = 3, level = 1 };
            Console.WriteLine(home.flat);
        }
    }
}
