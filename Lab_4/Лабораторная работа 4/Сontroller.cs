using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    public static class Controller
    {
        public static double GetWeight<T>(Zoo ex)
        {
            double sum = 0;
            int count = 0;
            foreach (Animal anim in ex.animals)
            {
                Animal ana = anim;
                if (anim is T)
                {
                    sum += anim.Weight;
                    count++;
                }
            }
            return sum / count;
        }
        public static void Predators(Zoo ex) 
        {
            int countPred = 0;

            foreach (var item in ex.animals)
            {
                if (item.TypeOfAnimal == "predator")
                {
                    if (item is Birds)
                        countPred++;
                }
            }
            Console.WriteLine($"Количество хищных птиц - {countPred}");
        }
        public static void PrintAn(Zoo ex)
        {
            ex.animals.OrderBy(animal => animal.YearOfBirth);
        }
    }
}
