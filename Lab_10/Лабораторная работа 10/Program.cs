using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_10
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string[] mounths = { "January", "February", "March", "April", "May", "June", "July",
                "August", "September", "October", "November", "December" };
            int n = 8;
            var selectMouths1 = from m in mounths
                               where m.Length == n
                               select m;
            var selectMouths2 = from m in mounths
                               where Equals(m, "December") || Equals(m, "January") || Equals(m, "February")
                               || Equals(m, "June") || Equals(m, "July") || Equals(m, "August")
                                select m;
            var selectMouths3 = from m in mounths
                                orderby m
                                select m;
            var selectMouths4 = from m in mounths
                                where m.Contains("u") && m.Length >= 4
                                select m;
            Console.WriteLine("1:");
            foreach (var item in selectMouths1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("2:");
            foreach (var item in selectMouths2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("3:");
            foreach (var item in selectMouths3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("4:");
            foreach (var item in selectMouths4)
            {
                Console.WriteLine(item);
            }
            ////////////////////////////////////////////////////////////////////////////
            List<House> houses = new List<House>() { };
            List<Owner> owners = new List<Owner>() { };

            House h1 = new House(1, 12, 75.4, 2, 3, "Шаранговича", "Панельный", 160);
            House h2 = new House(2, 31, 54, 6, 2, "Янковского", "Панельный", 115);
            House h3 = new House(3, 54, 60.6, 9, 2, "М.Танка", "Панельный", 90);
            House h4 = new House(4, 78, 71, 15, 3, "Янковского", "Многоэтажный", 110);
            House h5 = new House(5, 23, 34, 4, 1, "Янковского", "Панельный", 130);
            House h6 = new House(6, 45, 81.4, 4, 4, "М.Танка", "Хрущёвка", 95);
            House h7 = new House(7, 145, 40, 26, 1, "Шаранговича", "Многоэтажный", 140);
            House h8 = new House(8, 116, 45, 21, 2, "Шаранговича", "Многоэтажный", 140);
            House h9 = new House(9, 55, 60, 9, 3, "Шаранговича", "Многоэтажный", 140);
            House h10 = new House(10, 120, 60, 20, 2, "Шаранговича", "Многоэтажный", 160);
            House h11 = new House(11, 99, 65, 17, 3, "Шаранговича", "Многоэтажный", 140);
            House h12 = new House(12, 69, 65, 12, 2, "Шаранговича", "Многоэтажный", 140);
            Owner o1 = new Owner("Григорьев Виктор Семёнович", 45, 34);
            Owner o2 = new Owner("Фурье Игорь Викторович", 69, 27);
            Owner o3 = new Owner("Кручкова Анастасия Александровна", 120, 21);

            houses.Add(h1);
            houses.Add(h2);
            houses.Add(h3);
            houses.Add(h4);
            houses.Add(h5);
            houses.Add(h6);
            houses.Add(h7);
            houses.Add(h8);
            houses.Add(h9);
            houses.Add(h10);
            houses.Add(h11);
            houses.Add(h12);
            owners.Add(o1);
            owners.Add(o2);
            owners.Add(o3);

            int count = 0;
            var selectedFlats1 = from f in houses
                                 where f.Rooms == 3
                                 select f.Flat;
            var selectedFlats2 = from f in houses
                                 where f.Street == "Шаранговича"
                                 && f.Type_of_house == "Многоэтажный"
                                 select f.Flat;
            var selectedFlats3 = from f in houses
                                 where f.Street == "Шаранговича"
                                 select count = houses.Count();
            var selectedFlats4 = from f in houses
                                 where f.Rooms == 3
                                 && f.Level == 5 || f.Level == 6
                                 || f.Level == 7 || f.Level == 8
                                 || f.Level == 9 || f.Level == 10
                                 || f.Level == 11 || f.Level == 12
                                 || f.Level == 13 || f.Level == 14
                                 || f.Level == 15 || f.Level == 16
                                 || f.Level == 17 || f.Level == 18
                                 || f.Level == 19 || f.Level == 20
                                 select f.Flat;
            Console.WriteLine("1:");
            foreach (var item in selectedFlats1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("2:");
            foreach (var item in selectedFlats2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("3:");
            foreach (var item in selectedFlats3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("4:");
            foreach (var item in selectedFlats4)
            {
                Console.WriteLine(item);
            }

            var selectedFlats5 = houses
                .Where(f => f.Rooms == 2 || f.Rooms == 3)
                .GroupBy(f => f.id)
                .Take(5)
                .Select(f => f)
                .Count();
            Console.WriteLine("5:");
            Console.WriteLine(selectedFlats5);

            var selectedFlats6 = from flats in houses
                                  join names in owners
                                  on flats.Flat equals names.Flat
                                  select new 
                                  { 
                                      OwnerName = names.FIO,
                                      HouseFlat = flats.Flat
                                  };
            Console.WriteLine("6:");
            foreach (var item in selectedFlats6)
            {
                Console.WriteLine(item);
            }
        }
    }
}
