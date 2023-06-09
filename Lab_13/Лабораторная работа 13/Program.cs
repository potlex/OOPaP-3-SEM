using System.Xml.Serialization;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml;
//using System.Runtime.Serialization.Formatters.Soap;

namespace Лабораторная_работа_13
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Parrot parrot = new Parrot("yellow", "male", "day"); 
            Console.WriteLine("Binary:");
            BinaryFormatter formatter = new BinaryFormatter();  
            using (FileStream fs = new FileStream("Bin.dat", FileMode.OpenOrCreate))    
            {
                formatter.Serialize(fs, parrot);
            }
            using (FileStream fs = new FileStream("Bin.dat", FileMode.OpenOrCreate))
            {
                Parrot newParrot = (Parrot)formatter.Deserialize(fs);
                newParrot.ToString();
            }

            //Parrot parrot1 = new Parrot("red-blue", "male", "day");
            //Console.WriteLine("\nSOAP:");
            //SoapFormatter soapformatter = new SoapFormatter();  
                                                                
            //using (Stream fs = new FileStream("SOAP.dat", FileMode.OpenOrCreate))
            //{
            //    soapformatter.Serialize(fs, parrot1);
            //}
            //using (Stream fs = new FileStream("SOAP.dat", FileMode.OpenOrCreate))
            //{
            //    Parrot newParrot1 = (Parrot)soapformatter.Deserialize(fs);
            //    newParrot1.ToString();
            //}

            Parrot parrot2 = new Parrot("white-black", "male", "day");
            Console.WriteLine("\nJSON:");
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Parrot));
            using (FileStream fs = new FileStream("JSONForm.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, parrot2);
            }
            using (FileStream fs = new FileStream("JSONForm.json", FileMode.OpenOrCreate))
            {
                Parrot newParrot2 = jsonFormatter.ReadObject(fs) as Parrot;
                newParrot2.ToString();
            }

            Parrot parrot3 = new Parrot("green", "male", "day");
            Console.WriteLine("\nXML:");
            XmlSerializer xml = new XmlSerializer(typeof(Parrot));    
            using (FileStream fs = new FileStream("XMLSerial.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, parrot3);
            }
            using (FileStream fs = new FileStream("XMLSerial.xml", FileMode.OpenOrCreate))
            {
                Parrot newParrot3 = xml.Deserialize(fs) as Parrot;
                newParrot3.ToString();
            }

            Parrot p1 = new Parrot("green-yellow", "male", "day");
            Parrot p2 = new Parrot("green-red", "male", "day");
            Parrot p3 = new Parrot("green", "male", "day");
            Parrot[] bs = new Parrot[] { p1, p2, p3 };
            Console.WriteLine("\nArray:");
            DataContractSerializer array = new DataContractSerializer(typeof(Parrot[]));
            using (FileStream fs = new FileStream("array.xml", FileMode.OpenOrCreate))
            {
                array.WriteObject(fs, bs);
            }
            using (FileStream fs = new FileStream("array.xml", FileMode.OpenOrCreate))
            {
                Parrot[] newB = (Parrot[])array.ReadObject(fs);
                foreach (Parrot b in newB)
                {
                    b.ToString();
                }
            }

            Console.WriteLine("\nXPath:");  
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("parrots.xml");
            XmlElement xRoot = xDoc.DocumentElement;    
            Console.WriteLine("All nodes:");
            XmlNodeList all = xRoot.SelectNodes("*");   
            foreach (XmlNode x in all)
            {
                Console.WriteLine(x.OuterXml);         
            }
            Console.WriteLine("Info about parrot:");
            XmlNodeList parts = xRoot.SelectNodes("Parrot");  
            foreach (XmlNode x in parts)
            {
                Console.WriteLine(x.SelectSingleNode("NameOfW").InnerText); 
            }

            Console.WriteLine("\nLINQ to XML:");
            XDocument xdoc = new XDocument();
            XElement zoo = new XElement("zoo");
            XAttribute ps_color = new XAttribute("color", "red");
            XElement ps_gender = new XElement("gender", "female");
            XElement ps_type = new XElement("type", "day");
            zoo.Add(ps_color);
            zoo.Add(ps_gender);
            zoo.Add(ps_type);

            XElement zoo2 = new XElement("zoo");
            XAttribute ps_color2 = new XAttribute("color", "red");
            XElement ps_gender2 = new XElement("gender", "female");
            XElement ps_type2 = new XElement("type", "day");
            zoo2.Add(ps_color2);
            zoo2.Add(ps_gender2);
            zoo2.Add(ps_type2);

            XElement root = new XElement("root");  
            root.Add(zoo);
            root.Add(zoo2);
            xdoc.Add(root);
            xdoc.Save("linq.xml");                 

            var items = xdoc.Element("root").Elements("zoo")
                .Where(p => p.Element("color").Value == "red")
                .Select(p => p);
            foreach (var item in items)
            {
                Console.WriteLine(item.Attribute("color").Value + " - " + item.Element("gender").Value + " - " + item.Element("type").Value);
            }
            var coun = xdoc.Element("root").Elements("zoo")
                .Where(p => p.Attribute("gender").Value == "male")
                .Select(p => p);
            foreach (var c in coun)
            {
                Console.WriteLine(c.Attribute("color").Value + " - " + c.Element("gender").Value + " - " + c.Element("type").Value);
            }
        }
    }
}