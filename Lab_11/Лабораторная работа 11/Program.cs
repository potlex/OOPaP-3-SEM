using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Collections;

namespace Лабораторная_работа_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector.OutAssemblyName("Example");
            Reflector.OutPublicConstructors("Example");
            Reflector.OutPublicMethods("Example");
            Reflector.MethodForType("Example");
            Reflector.OutInterfaces("Example");
            Reflector.OutMethodsWithParm("Example", "String");
            Reflector.Invoke("Лабораторная_работа_11.Example", "ToConsole");

            object[] list = new object[] { "Hello" };
            object example = Reflector.Create("Example", list);

            Reflector.file.Close();
        }
    }
}