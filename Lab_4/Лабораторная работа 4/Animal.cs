using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    public abstract class Animal
    {
        private string typeOfAnimal;
        public string TypeOfAnimal
        {
            get { return typeOfAnimal; }
            set { typeOfAnimal = value; }
        }
        private int yearOfBirth;
        public int YearOfBirth
        {
            get { return yearOfBirth; }
            set 
            {
                string nowYear = DateTime.Now.Year.ToString();
                int yearNow = Convert.ToInt32(nowYear);
                if (yearOfBirth > yearNow)
                    throw new SException("Год превышает допустимые значения");
                yearOfBirth = value; 
            }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public Animal(string _typeOfAnimal, int _yearOfBirth, double _weight)
        {
            TypeOfAnimal = _typeOfAnimal;
            YearOfBirth = _yearOfBirth;
            Weight = _weight;

        }
    }
    public struct Animals
    {
        int age;
        string name;
        string typeOfAnimals;
        public Animals(int age = 0, string name = "null", string typeOfAnimals = "null")
        {
            this.age = age;
            this.name = name;
            this.typeOfAnimals = typeOfAnimals;
        }
    }
    public enum eAnimals
    {
        animal = 1,
        mammals,
        birds,
        fishs,
        lion,
        tiger,
        parrot,
        owl,
        shark,
        orca,
        crocodile
    }
    public interface IAnimable 
    {
        void Info();
    }
}
