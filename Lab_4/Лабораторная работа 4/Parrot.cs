using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal class Parrot : Birds
    {
        Birds birds4;
        private string colorOfParrot;
        public string ColorOfParrot
        {
            get { return colorOfParrot; }
            set { colorOfParrot = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Parrot(string _colorOfParrot, string _gender,
            string _typeOfAnimal, string _typeOfBirds, int _yearOfBirth, double _weight) 
            : base(_typeOfAnimal, _typeOfBirds, _yearOfBirth, _weight)
        {
            birds4 = new Birds("sky", "parrot", 2021, 0.2);
            ColorOfParrot = _colorOfParrot;
            Gender = _gender;
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.TypeOfBirds + this.Gender + this.ColorOfParrot + this.YearOfBirth + this.Weight;
            return result;
        }
    }
}
