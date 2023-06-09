using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4
{
    public class SaveFile<L>
    {
        public static void WriteToFile(List<L> arr) 
        {
            StreamWriter file = new StreamWriter("data.txt", false);
            foreach (var item in arr)
            {
                file.Write($"{item}\n");
            }
            file.Close();
        }
        public static void ReadToFile() 
        {
            StreamReader file = new StreamReader("data.txt");
            Console.WriteLine(file.ReadToEnd());
            file.Close();
        }
    }
}
