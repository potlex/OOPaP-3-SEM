using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    public class Fishs : Animal
    {
        private string typeOfFish;
        public string TypeOfFish
        {
            get { return typeOfFish; }
            set { typeOfFish = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Fishs(string _typeOfFish, string _gender, string _typeOfAnimal, int _yearOfBirth, double _weight) 
            : base(_typeOfAnimal, _yearOfBirth, _weight)
        {
            TypeOfFish = _typeOfFish;
            Gender = _gender;
            TypeOfAnimal = _typeOfAnimal;
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.Gender + this.TypeOfFish + this.YearOfBirth + this.Weight;
            return result;
        }
    }
}
