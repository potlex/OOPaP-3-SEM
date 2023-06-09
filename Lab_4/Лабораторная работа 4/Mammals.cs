using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Лабораторная_работа_4
{
    internal class Mammals : Animal
    {
        private int id;
        public int Id
        {
            get { return id; }
            set 
            {
                if (id < 0)
                    throw new FException("ID не может быть отрицательным");
                id = value; 
            }
        }

        private string typeOfMammals;
        public string TypeOfMammals
        {
            get { return typeOfMammals; }
            set { typeOfMammals = value; }
        }
        public override string ToString()
        {
            string result = this.TypeOfAnimal + this.TypeOfMammals + this.Id + this.YearOfBirth + this.Weight;
            return result;
        }
        public override int GetHashCode()
        {
            return id;
        }
        public override bool Equals(object obj)
        {
            if (obj is Mammals mammal)
                return typeOfMammals == mammal.typeOfMammals;
            return false;
        }
        public Mammals(int _id, string _typeOfMammals, string _typeOfAnimal, int _yearOfBirth, double _weight)
            : base(_typeOfAnimal, _yearOfBirth, _weight)
        {
            Id = _id;
            TypeOfMammals = _typeOfMammals;
        }
    }
}
