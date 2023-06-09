using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_11
{
    internal class Example : IShow
    {
        public string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public Example() { }
        public Example(string _name)
        {
            Name = _name;
        }
        public void Show() 
        {
            Console.WriteLine(name);
        }
        public void ToConsole(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public override string ToString()
        {
            return "Имя - " + name;
        }
    }
}
