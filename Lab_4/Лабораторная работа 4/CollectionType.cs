using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    public class CollectionType<L> : IGenericInterface<L> where L : class
    {
        private List<L> cCollection = null;
        public List<L> CCollection
        {
            get
            {
                if (cCollection == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    return cCollection;
                }
            }
            set
            {
                cCollection = value;
            }
        }
        public void Add(L elem)
        {
            cCollection.Add(elem);
        }
        public void Delete(L elem)
        {
            cCollection?.Remove(elem);
        }
        public void Show()
        {
            foreach (L item in cCollection)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
