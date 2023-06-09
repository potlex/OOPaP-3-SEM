using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    public class Realize : BaseClone, IAnimable
    {
        public string name;
        public int age;
        public Realize(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public BaseClone Info(BaseClone clone)
        {
            return clone;
        }
        public override void Info()
        {
            Console.WriteLine("Имя: " + name + "\nВозраст: " + age);
        }
    }
}
