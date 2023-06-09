using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_12
{
    public static class PAVDirInfo
    {
        private const string path = @"D:\\ООПП\\Лабораторная работа 12";
        private static DirectoryInfo DI;

        static PAVDirInfo() => DI = new DirectoryInfo(path);

        public static string CountOfFiles() => "Count of files: " + DI.GetFiles(path).Count().ToString() + "\n";
        public static string DateOfCreation() => "Date of creation: " + DI.CreationTime.ToString() + "\n";
        public static string CountOfSubdir() => "Count of subdirectories: " + DI.GetDirectories().Count().ToString() + "\n";
        public static string ParentDirectories()
        {
            string result = "List of parent directories: ";
            DirectoryInfo directory = DI.Parent;
            while (directory.Name != DI.Root.ToString())
            {
                result += directory.Name + "\n";
                directory = directory.Parent;
            }
            result += directory.Name + "\n";
            return result;
        }
    }
}
