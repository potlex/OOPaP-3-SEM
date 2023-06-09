using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_12
{
    public static class PAVFileInfo
    {
        private const string path = @"D:\\ООПП\\Лабораторная работа 12\\pavlogfile.txt";

        private static FileInfo FI;

        static PAVFileInfo() => FI = new FileInfo(path);
        public static string GetPath() => "Directory name: " + FI.DirectoryName + '\n';
        public static string GetFileInfo()
        {
            string result = "";
            result += "Size: " + FI.Length + '\n';
            result += "Extension: " + FI.Extension + '\n';
            result += "Name: " + FI.Name + "\n\n";
            return result;
        }
        public static string GetTimeOf()
        {
            string result = "";
            result += "Time creation: " + FI.CreationTime.ToString() + "\n\n";
            result += "Time creation: " + FI.LastWriteTime.ToString() + "\n\n";
            return result;
        }
    }
}
