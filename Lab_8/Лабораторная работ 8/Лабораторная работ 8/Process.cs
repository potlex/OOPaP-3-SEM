using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_8
{
    public class Process 
    {
        public static string RemoveSigns(string str)
        { 
            char[] signs = { ',', '.', ':', ';', '-', '!', '?' };
            for (int i = 0; i < str.Length; i++)
            {
                if (signs.Contains(str[i])) 
                    str = str.Remove(i, 1);
            }
            return str;
        }
        public static string AddSigns(string str)
        {
            str = str + '!';
            return str;
        }
        public static string UpperCase(string str)
        {
            Console.WriteLine(str.ToUpper());
            return str.ToUpper();
        }
        public static string RemoveSpace(string str)
        {
            str = str.Replace(" ", "");
            return str;
        }
        public static string LowerCase(string str) 
        {
            Console.WriteLine(str.ToLower());
            return str.ToLower();
        } 
    }
}
