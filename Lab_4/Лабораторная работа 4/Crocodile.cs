using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal class Crocodile : Animal
    {
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Crocodile(string _gender, string _typeOfAnimal, int _yearOfBirth, double _weight) : base(_typeOfAnimal, _yearOfBirth, _weight)
        {
            Gender = _gender;
            TypeOfAnimal = _typeOfAnimal;
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.Gender + this.YearOfBirth + this.Weight;
            return result;
        }
    }
}
