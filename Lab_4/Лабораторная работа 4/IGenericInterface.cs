using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    interface IGenericInterface<L> where L : class
    {
        void Add(L elem);
        void Delete(L elem);
        void Show();
    }
}
