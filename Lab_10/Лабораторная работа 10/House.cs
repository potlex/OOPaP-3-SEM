using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_10
{
    public partial class House
    {
        public readonly int id;
        public int Flat;
        public double Area;
        public int Level;
        public int Rooms;
        public string Street;
        public string Type_of_house;
        public int Op_time;

        public void HouseAge(ref int AgeOfHouse)
        {
            AgeOfHouse = DateTime.Now.Year - AgeOfHouse;
        }

        public void HouseDate(out int DateOfBuild, ref int AgeHouse)
        {
            DateOfBuild = DateTime.Now.Year - AgeHouse;
        }

        public static int count;
        public House(int _id, int _flat, double _area, int _level, 
            int _rooms, string _street, string _type_of_house, int _op_time)
        {
            id = _id;
            Flat = _flat;
            Area = _area;
            Level = _level;
            Rooms = _rooms;
            Street = _street;
            Type_of_house = _type_of_house;
            Op_time = _op_time;
        }

        public override int GetHashCode()
        {
            Console.WriteLine($"Hashcode of flats: {Flat.GetHashCode()}");
            return Flat.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"{id}\t{Flat}\t{Area}\t{Level}\t{Rooms}\t{Street}\t{Type_of_house}\t{Op_time}\t{city}";
        }

        public const string city = "Minsk";

        public void GetInfo()
        {
            Console.WriteLine($"ID: {id} | Квартира: {Flat} | Площадь: {Area} | Этаж: {Level} " +
                $"| Комнаты: {Rooms} | Улица: {Street} | Тип дома: {Type_of_house} | Время эксплуатации: {Op_time}");
        }
        private House() { }
    }
}
