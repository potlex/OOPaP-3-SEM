using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_3
{
    public class Production
    {
        public int Id { get; set; }
        private string Name { get; set; }
        Production prod = new Production(2, "Fath");

        public Production(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public class Set 
    {
        private static int ind = 0;
        public static List<Item> items = new List<Item>();
        public int count = 0;
        private readonly Developer developer;
        public HashSet<String> collection;
        private readonly Date date;
        public int size;
        public Production prods;

        public Set(string devFIO, int devId, string devDepartment)
        {
            this.developer = new Developer(devFIO, devId, devDepartment);
            this.collection = new HashSet<string>();
            this.date = new Date();
        }
        public class Item
        {
            public int Data { get; set; }
            public int Index { get; set; }
            public Item(int data)
            {
                Data = data;
                Index = ind++;
                items.Add(this);
            }
            Item its = new Item(4);

            public static Item operator ++(Item it)
            {
                it.Data++;
                return it;
            }

            public static Item operator +(Item it1, Item it2)
            {
                Set.Item it3 = new Set.Item(3);
                it3.Data = it1.Data + it2.Data;
                return it3;
            }

        }
    
        public HashSet<string> GetHash()
        {
            return collection;
        }
        public void Show()
        {
            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public Developer GetDeveloper()
        {
            return developer;
        }

        public int GetSize()
        {
            int size = 0;
            foreach (string item in collection)
            {
                size++;
            }
            return size;
        }

        public void AddItem(string item)
        {
            collection.Add(item);
        }

        public class Date
        {
            public readonly DateTime time;

            public Date()
            {
                time = DateTime.Now;
            }
        }

        public string GetItemByIndex(int index)
        {
            if (index > this.GetSize() - 1)
                throw new Exception("GetItemByIndex: OutOfRange");

            int size = -1;
            foreach (string item in collection)
            {
                size++;
                if (size == index)
                    return item;
            }
            return "";
        }

    
        
        public static bool operator <=(Set set, Set set2)
        {
            return (set.Equals(set) || set.Equals(set2));
        }
        public static bool operator >=(Set set, Set set2)
        {
            return (set.Equals(set) || set.Equals(set2));
        }
        public int GetSizeSet()
        {
            int size = 0;
            foreach (string item in collection)
            {
                size++;
            }
            return size;
        }
        public static Set.Item operator %(Set set, int idx)
        {
            Item result = null;
            foreach (Item item in items)
            {
                if (item.Index == idx)
                    result = item;
            }
            return result;
        }
    }
}
