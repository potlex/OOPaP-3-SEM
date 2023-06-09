using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                CollectionClass<int, Concert> collection1 = new CollectionClass<int, Concert>() { };
                Concert c1 = new Concert("kizaru");
                Concert c2 = new Concert("ATL");
                Concert c3 = new Concert("JABBI");
                Concert c4 = new Concert("Krimzon");

                collection1.Add(1, c1);
                collection1.Add(2, c2);
                collection1.Add(3, c3);
                collection1.Add(4, c4);
                collection1.Show();
                Console.Write("Введите количество удаляемых элементов: ");
                string toRemove;
                toRemove = Console.ReadLine();p
                int n = Convert.ToInt32(toRemove);
                while (n > 0)
                {
                    collection1.Remove(--n + 1);
                }
                collection1.Show();

                LinkedList<Concert> link = new LinkedList<Concert>();
                foreach (var item in collection1.people)
                {
                    link.AddLast(item.Value);
                }
                foreach (var item in link)
                {
                    Console.WriteLine(item.Name);
                }
                Concert c5 = new Concert("Krimzon");
                foreach (var item in link)
                {
                    if (item.Name == c5.Name)
                        Console.WriteLine(item.Name);
                }

                ObservableCollection<Concert> peoples = new ObservableCollection<Concert>();
                peoples.CollectionChanged += CollectionChanged;
                peoples.Add(c1);
                peoples.Remove(c2);
            }
        }
        private static void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Добавлен новый объект");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Удален объект");
                    break;
            }
        }
    }
}