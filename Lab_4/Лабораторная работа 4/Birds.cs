using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Лабораторная_работа_4
{
    internal class Birds : Animal
    {
        private string typeOfBirds;

        public string TypeOfBirds
        {
            get { return typeOfBirds; }
            set { typeOfBirds = value; }
        }
        public Birds(string _typeOfAnimal, string _typeOfBirds, int _yearOfBirth, double _weight) : base(_typeOfAnimal, _yearOfBirth, _weight)
        {
            TypeOfBirds = _typeOfBirds;
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.TypeOfBirds + this.YearOfBirth + this.Weight;
            return result;
        }
    }
}
