using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_8
{
    internal class Events
    {
        public void DoRename(Programmer obj, string Name)
        { 
            obj.Version = Name;
            Console.WriteLine($"Версия обновлена! Новая версия - {Name}");
        }
        public void DoNewProp(Programmer obj, string Name, string Version, string Type)
        { 
            obj.Name = Name;
            obj.Version = Version;
            obj.Type = Type;
            Console.WriteLine($"Название, версия и тип обновлены! Новые параметры - {Name}, {Version}, {Type}");
        }
    }
}
