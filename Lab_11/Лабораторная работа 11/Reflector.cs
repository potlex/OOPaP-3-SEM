using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_11
{
    internal class Reflector
    {
        static string filePath = "D:\\ООПП\\Лабораторная работа 11\\file.txt";
        static string filePathRead = "D:\\ООПП\\Лабораторная работа 11\\read.txt";
        public static StreamWriter file = new StreamWriter(filePath, false);
        static StreamReader read = new StreamReader(filePathRead);

        public static void OutAssemblyName(string name) 
        {
            string typeName = "Лабораторная_работа_11." + name;
            Type type = Type.GetType(typeName, false, true);
            file.WriteLine($"Имя сборки - {type.Assembly}");
        }
        public static void OutPublicConstructors(string name)
        {
            string typeName = "Лабораторная_работа_11." + name;
            Type type = Type.GetType(typeName, false, true);

            foreach (ConstructorInfo constr in type.GetConstructors())
            {
                if (constr.IsPublic)
                {
                    file.Write(constr.Name + '(');
                    ParameterInfo[] parameters = constr.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) file.Write(", ");
                    }
                    file.WriteLine(");");
                }
            }
        }
        public static void OutPublicMethods(string name)
        {
            string typeName = "Лабораторная_работа_11." + name;
            Type type = Type.GetType(typeName, false, true);

            foreach (MethodInfo mi in type.GetMethods())
            {
                if (mi.IsPublic)
                {
                    file.Write(mi.Name + '(');
                    ParameterInfo[] parameters = mi.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) file.Write(", ");
                    }
                    file.WriteLine(");");
                }
            }
        }
        public static void MethodForType(string name)
        {
            string typeName = "Лабораторная_работа_11." + name;
            Type type = Type.GetType(typeName, false, true);

            foreach (FieldInfo fi in type.GetFields())
            {
                file.WriteLine(fi.DeclaringType + " " + fi.FieldType + " " + fi.Name);
            }

            foreach (PropertyInfo pi in type.GetProperties())
            {
                file.WriteLine(pi.DeclaringType + " " + pi.PropertyType + " " + pi.Name);
            }

        }
        public static void OutInterfaces(string name)
        {
            string typeName = "Лабораторная_работа_11." + name;
            Type type = Type.GetType(typeName, false, true);

            foreach (Type i in type.GetInterfaces())
            {
                file.WriteLine("interface " + i.Name);
            }
        }
        public static void OutMethodsWithParm(string name, string parm)
        {
            string typeName = "Лабораторная_работа_11." + name;
            Type type = Type.GetType(typeName, false, true);

            foreach (MethodInfo mi in type.GetMethods())
            {
                ParameterInfo[] param = mi.GetParameters();
                for (int j = 0; j < param.Length; j++)
                {
                    if (parm == param[j].ParameterType.Name)
                    {
                        file.Write(mi.Name + '(');
                        ParameterInfo[] parameters = mi.GetParameters();
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                            if (i + 1 < parameters.Length) file.Write(", ");
                        }
                        file.WriteLine(");");
                        break;
                    }
                }
            }
        }
        static public void Invoke(string name, string method)
        {
            List<string> list = new List<string>();
            list.Add(read.ReadLine());
            list.Add(read.ReadLine());
            list.Add(read.ReadLine());
            object[] parms = new object[] { list };
            Type type = Type.GetType(name);
            object obj = Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod(method);
            object result = methodInfo.Invoke(obj, parms);
            Console.WriteLine(result);
        }
        public static object Create(string name, object[] param)
        {
            string typeName = "Лабораторная_работа_11." + name;
            Type type = Type.GetType(typeName, false, true);
            object obj = Activator.CreateInstance(type, param);
            Console.WriteLine(obj.ToString());
            return obj;
        }
    }
}
