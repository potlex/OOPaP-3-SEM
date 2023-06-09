using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_12
{
    public static class PAVLog
    {
        private const string path = @"D:\\ООПП\\Лабораторная работа 12\\pavlogfile.txt";
        private static StreamWriter logWriter;

        static PAVLog() => logWriter = new StreamWriter(path, true, Encoding.Default);

        public static void Write(string str) => logWriter.WriteLine(str);

        public static string GetInfoByDay(DateTime date)
        {
            logWriter.Close();
            string result = "";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                const string sessionKeyWord = "Session: ";
                string[] infos = sr.ReadToEnd().Split('$');
                if (infos.Count() == 0)
                    return null;
                int strCount = -1;
                int prevStrIndex = -1;
                foreach (var s in infos)
                {
                    strCount++;
                    int isExist = s.IndexOf(sessionKeyWord);
                    if (isExist == -1)
                    {
                        prevStrIndex = strCount;
                        continue;
                    }
                    string sessionTime = "";
                    for (int i = isExist + sessionKeyWord.Length; i < s.Length; i++)
                        sessionTime += s[i];

                    DateTime sessTime = Convert.ToDateTime(sessionTime);
                    if (sessTime == date)
                        result += infos[prevStrIndex] + "\n\n";
                }
            }
            logWriter = new StreamWriter(path, true, Encoding.Default);
            return result;
        }

        public static int GetRecordCount()
        {
            logWriter.Close();
            int res = 0;
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                res = sr.ReadToEnd().Split('$').Where(s => s.StartsWith("Session") == false).Count();
            }
            logWriter = new StreamWriter(path, true, Encoding.Default);
            return res;
        }


        public static void Close() => logWriter.Close();
    }
}
