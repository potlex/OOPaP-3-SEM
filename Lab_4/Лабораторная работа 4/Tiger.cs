using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    sealed internal class Tiger : Mammals
    {
        private string colorOfTiger;
        public string ColorOfTiger
        {
            get { return colorOfTiger; }
            set { colorOfTiger = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Tiger(string _colorOfTiger, string _gender, int _id,
            string _typeOfMammals, string _typeOfAnimal, int _yearOfBirth, double _weight)
            : base(_id, _typeOfMammals, _typeOfAnimal, _yearOfBirth, _weight)
        {
            ColorOfTiger = _colorOfTiger;
            Gender = _gender;
            TypeOfAnimal = _typeOfAnimal;
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.TypeOfMammals + this.Id + this.Gender + this.ColorOfTiger + this.YearOfBirth + this.Weight;
            return result;
        }
    }
}
