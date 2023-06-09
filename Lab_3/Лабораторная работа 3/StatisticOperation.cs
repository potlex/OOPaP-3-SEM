using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_3
{
    static class StatisticOperation
    {
        public static int CountOfWords(this string str) 
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            count += words.Length;
            return count;
        }
        public static int MaxString(this Set set)
        {
            string input = set.ToString();
            string[] str = input.Split(new char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLen = Int32.MinValue;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxLen)
                    maxLen = str[i].Length;
            }
            return maxLen;
        }
        public static int MinString(this Set set)
        {
            string input = set.ToString();
            string[] str = input.Split(new char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int minLen = Int32.MaxValue;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length < minLen)
                    minLen = str[i].Length;
            }
            return minLen;
        }
        public static int DefStrings(this Set set)
        {
            return MaxString(set) - MinString(set);
        }
        public static int SumString(this Set set)
        {
            int strLen = 0;

            foreach (string item in set.GetHash())
            {
                strLen += item.Length;
            }
            return strLen;
        }

        public static int CharCount(this string str, char c)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }

            return counter;
        }
        public static void ShowItems(this Set set1)
        {
            foreach (Set.Item item in Set.items)
            {
                Console.Write(item.Data + " ");
            } 
        }
    }
}
