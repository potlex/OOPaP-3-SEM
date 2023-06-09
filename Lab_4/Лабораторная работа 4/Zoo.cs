using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    public class Zoo
    {
        public List<Animal> animals = new List<Animal>();
        public List<Animal> anim
        {
            get { return animals; }
            set {
                if (value == null)
                    Console.WriteLine("null - ошибка!");
                else
                    animals = value; 
            }
        }
        public void Add(Animal obj)
        {
            animals.Add(obj);
        }
        public void Remove(Animal obj)
        {
            animals.Remove(obj);
        }
        public void Print()
        {
            foreach (Animal item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
