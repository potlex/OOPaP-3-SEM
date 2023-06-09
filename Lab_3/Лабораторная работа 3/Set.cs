using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_3
{
    public class Set
    {
        Set Production = new Set();
        public class Item;
        public int count = 1;
        public static Set operator ++(Set set)
        {
            Set set1 = new Set();
            set1.count++;
            return set1;
        }
        public static Set operator +(Set set, Set set2)
        {
            return set + set2;
        }
        public static bool operator <=(Set set, Set set2)
        { 
            return (set.Equals(set2) || set.Equals(set2));
        }
        public static bool operator >=(Set set, Set set2)
        { 
            return (set.Equals(set2) || set.Equals(set2));
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
    }
}
