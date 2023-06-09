using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal class Printer
    {
        public string IAmPrinting(Animal someobj) 
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Birds someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Mammals someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Fishs someobj)
        {
            return someobj.ToString();
        }
    }
}
