using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_12
{
    public static class PAVDiskInfo
    {
        private static DriveInfo[] DI;

        static PAVDiskInfo() => DI = DriveInfo.GetDrives();

        public static string GetFreeSpace()
        {
            long space = 0;
            foreach (var elem in DI)
                space += elem.AvailableFreeSpace;

            return "Free space:\t" + space.ToString();
        }
        public static string GetFileSystem() => DI[0].DriveFormat;
        public static string GetDiskInfo()
        {
            string result = "";
            foreach (var elem in DI)
            {
                result += "Disk name: " + elem.Name + '\n';
                result += "Disk space: " + elem.TotalSize.ToString() + '\n';//
                result += "Disk free space: " + elem.TotalFreeSpace.ToString() + '\n';//
                result += "Volume label: " + elem.RootDirectory.ToString() + "\n\n";
            }
            return result;
        }
    }
}
