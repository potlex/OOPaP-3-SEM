using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_3
{
    public class Developer
    {
        private readonly string FIO;
        private readonly int ID;
        private readonly string DEPARTMENT;

        public Developer(string FIO, int ID, string DEPARTMENT)
        {
            this.FIO = FIO;
            this.ID = ID;
            this.DEPARTMENT = DEPARTMENT;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ФИО - {FIO}, ID - {ID}, ОТДЕЛ -  {DEPARTMENT}");
        }
    }
}
