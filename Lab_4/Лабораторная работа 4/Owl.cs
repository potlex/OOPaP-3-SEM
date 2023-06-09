using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal class Owl : Birds
    {
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (gender != "male" || gender != "female")
                    throw new TException("Ошибка ввода пола животного");
                gender = value; 
            }
        }
        public Owl(string _gender, string _typeOfBirds, string _typeOfAnimal, int _yearOfBirth, double _weight)
            : base(_typeOfBirds, _typeOfAnimal, _yearOfBirth, _weight)
        {
            Gender = _gender;
            TypeOfBirds = _typeOfBirds;
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.TypeOfBirds + this.Gender + this.YearOfBirth + this.Weight;
            return result;
        }
    }
}
