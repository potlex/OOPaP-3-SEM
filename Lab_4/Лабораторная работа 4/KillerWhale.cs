using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal partial class Orca
    {
        internal partial void InfoSize() 
        {
            if (size >= 10)
                Console.WriteLine($"Косатка размером {size} м. - большая косатка");
            else if (size >= 6)
                Console.WriteLine($"Косатка размером {size} м. - средняя косатка");
            else
                Console.WriteLine($"Косатка размером {size} м. - маленькая косатка");
        }
    }
}
