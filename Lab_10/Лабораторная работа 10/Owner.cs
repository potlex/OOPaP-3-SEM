using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_10
{
    internal class Owner
    {
        public string FIO;
        public int Flat;
        public int Age;

        public Owner(string fIO, int flat, int age)
        {
            FIO = fIO;
            Flat = flat;
            Age = age;
        }
    }
}
