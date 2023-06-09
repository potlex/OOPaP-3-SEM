using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Лабораторная_работа_8
{
    internal class Programmer
    {
        public string Name;
        public string Version;
        public string Type;

        public delegate void Rename(Programmer obj, string Name);
        public delegate void NewProp(Programmer obj, string Name, string Version, string Type);
        public event Rename rename;
        public event NewProp newProp;

        public Programmer(string name, string version, string type) 
        {
            Name = name;
            Version = version;
            Type = type;
        }
        public void Action(string Name, string Version, string Type)
        {
            Console.WriteLine(ToString());
            Console.Write("Изменения объектов: ");

            if (rename != null)
            {
                rename(this, Name);
            }
            else
            {
                Console.Write("Имя не изменено.");
            }

            if (newProp != null)
            {
                newProp(this, Name, Version, Type);
            }
            else
            {
                Console.Write("Версия и язык не изменены.");
            }

            Console.WriteLine();
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            string prog = Name + " -  название, " + Version + " - версия, " + Type + " -  тип.";
            return prog;
        }
    }
}
