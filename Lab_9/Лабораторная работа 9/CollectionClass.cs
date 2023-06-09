using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_9
{
    internal class CollectionClass<TKey, TValue> : IEnumerable
    {
        public Dictionary<TKey, TValue> people = new Dictionary<TKey, TValue>();
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public void Add(TKey key, TValue value)
        {
            people.Add(key, value);
            count++;
        }
        public void Remove(TKey key)
        {
            people.Remove(key);
            count--;
        }
        public void Show()
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Имя - {person.Value}");
            }
        }
        public void Search(TKey key, TValue value)
        {
            people.TryGetValue(key, out value);
        }
        public void Clear()
        {
            people.Clear();
            count = 0;
        }

        public IEnumerator GetEnumerator() => people.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
