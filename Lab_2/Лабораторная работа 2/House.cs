using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_2
{
    public partial class House
    {
        private readonly int id;
        private int flat;
        public int Flat
        {
            get { return Flat; }
            set
            {
                if (value < 1 || value > 120)
                {
                    Flat = 0;
                }
                else
                {
                    Flat = value;
                }
            }
        }
        private double area;
        public double Area
        {
            get { return Area; }
            set { Area = value; }
        }
        private int level;
        public int Level
        {
            get { return Level; }
            set { Level = value; }
        }
        private int rooms;
        public int Rooms
        {
            get { return Rooms; }
            set { Rooms = value; }
        }
        private string street;
        public string Street
        {
            get { return Street; }
            set { Street = value; }
        }
        private string type_of_house;
        public string Type_of_house
        {
            get { return Type_of_house; }
            set { Type_of_house = value; }
        }
        private int op_time;
        public int Op_time
        {
            get { return Op_time; }
            set { Op_time = value; }
        }

        public void HouseAge(ref int AgeOfHouse)
        {
            AgeOfHouse = DateTime.Now.Year - AgeOfHouse;
        }

        public void HouseDate(out int DateOfBuild, ref int AgeHouse)
        {
            DateOfBuild = DateTime.Now.Year - AgeHouse;
        }

        public static int count;
        public House(int x, int y)
        {
            count++;
            this.id = x;
            this.flat = y;
            House.count++;
        }

        public override int GetHashCode()
        {
            Console.WriteLine($"Hashcode of flats: {flat.GetHashCode()}");
            return flat.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"{id}\t{flat}\t{area}\t{level}\t{rooms}\t{street}\t{type_of_house}\t{op_time}\t{city}";
        }

        //id, flat, area, level, rooms, street, type_of_house, op_time
        public House(int i, int f, double a, int l, int r, string s, string t, int o) { id = i; flat = f; area = a; level = l; rooms = r; street = s; type_of_house = t; op_time = o; count++; }
        public House(int iii) { id = iii; flat = 2; area = 72.5; level = 1; rooms = 3; street = "Янковского"; type_of_house = "Небоскрёб"; op_time = 50; count++; }
        public House(int ii, int ff, double aa, int ll) { id = ii; flat = ff; area = aa; level = ll; rooms = 2; street = "Яна Чечота"; type_of_house = "Панельный"; op_time = 60; count++; }

        public const string city = "Minsk";

        public void GetInfo()
        {
            Console.WriteLine($"ID: {id} | Квартира: {flat} | Площадь: {area} | Этаж: {level} | Комнаты: {rooms} | Улица: {street} | Тип дома: {type_of_house} | Время эксплуатации: {op_time}");
        }
        static House()
        {
            Console.WriteLine("Flats: ");
        }
        private House() { }

        public static void Array()
        {
            var House = new House[3];
            House[0] = new House(1, 43, 54.5, 7, 2, "Яна Чечота", "Панельный", 35);
            House[1] = new House(2, 7, 80, 2, 4, "Вокзальная", "Панельный", 50);
            House[2] = new House(3, 157, 60.4, 21, 2, "Свердлова", "Небоскрёб", 50);

            Console.WriteLine("Введите количество комнат: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Квартира: ");
            foreach (var m in House)
            {
                if (m.rooms == k)
                    Console.WriteLine(m);
            }

            Console.WriteLine("Введите верх интервала: ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите низ интервала: ");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Квартиры: ");
            foreach (var d in House)
            {
                if (d.level < j & d.level > t)
                    Console.WriteLine(d);
            }
        }
    }
}
