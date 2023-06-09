using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal partial class Orca : Fishs
    {
        public int size;
        public Orca(int size, string _gender, string _typeOfFish , string _typeOfAnimal, int _yearOfBirth, double _weight)
            : base(_gender, _typeOfFish, _typeOfAnimal, _yearOfBirth, _weight)
        {
            this.size = size;
        }
        internal partial void InfoSize();
    }
}
