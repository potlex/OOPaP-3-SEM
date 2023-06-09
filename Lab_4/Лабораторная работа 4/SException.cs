using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal class SException : Exception
    {
        public SException(string message)
        : base(message)
        { }
    }
}
