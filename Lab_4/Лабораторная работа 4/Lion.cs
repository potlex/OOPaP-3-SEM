using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal class Lion : Mammals
    {
        Mammals mammal4;
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Lion(string _gender, string _typeOfMammals, string _typeOfAnimal, int _id, int _yearOfBirth, double _weight)
            : base(_id, _typeOfMammals, _typeOfAnimal, _yearOfBirth, _weight)
        {
            mammal4 = new Mammals(7, "tiger", "ground", 2000, 340);
            Gender = _gender;
            TypeOfAnimal = _typeOfAnimal;
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.TypeOfMammals + this.Id + this.Gender + this.YearOfBirth + this.Weight;
            return result;
        }
    }
}
