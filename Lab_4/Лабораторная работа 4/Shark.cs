using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    internal class Shark : Mammals
    {
        Fishs fish3; 
        private string typeOfShark;
        public string TypeOfShark
        {
            get { return typeOfShark; }
            set { typeOfShark = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Shark(string _typeOfShark, string _gender, int _id,
            string _typeOfMammals, string _typeOfAnimal, int _yearOfBirth, double _weight)
            : base(_id, _typeOfMammals, _typeOfAnimal, _yearOfBirth, _weight)
        {
            fish3 = new Fishs("shark", "male", "water", 2011, 1200);
            TypeOfShark = _typeOfShark;
            Gender = _gender;
            TypeOfAnimal = _typeOfAnimal;
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.TypeOfMammals + this.Id + this.TypeOfShark + this.Gender + this.YearOfBirth + this.Weight;
            return result;
        }
    }
}
