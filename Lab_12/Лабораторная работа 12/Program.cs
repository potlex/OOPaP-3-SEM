using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\ООПП\Лабораторная работа 12";
            Console.WriteLine(PAVDiskInfo.GetDiskInfo());
            PAVLog.Write(PAVDiskInfo.GetDiskInfo());

            Console.WriteLine(PAVFileInfo.GetFileInfo());
            PAVLog.Write(PAVFileInfo.GetFileInfo());
            PAVLog.Write("$Session: " + DateTime.Now.Date.ToString() + "$");

            PAVFileManager.MoveFiles(path);
            PAVFileManager.MoveDirectoriesByExtension(path, ".js");
            PAVFileManager.ToZip(path);

            Console.WriteLine("From file:");
            Console.WriteLine($"Count: {PAVLog.GetRecordCount()}");
            Console.WriteLine("\n");
            Console.WriteLine(PAVLog.GetInfoByDay(DateTime.Now.Date));

            PAVFileManager.FromZip();

            PAVLog.Close();
        }
    }
}
