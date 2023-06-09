using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_9
{
    internal class Concert 
    {
        public string Name;

        public Concert(string _name)
        {
            Name = _name;
        }
        public override string ToString() 
        {
            return base.ToString() + Name;
        }
    }
}
