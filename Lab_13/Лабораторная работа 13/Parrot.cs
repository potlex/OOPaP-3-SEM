using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Лабораторная_работа_13
{
    [Serializable]
    [XmlRoot("Bird")]
    internal class Parrot : Birds
    {
        Birds birds4;
        private string colorOfParrot;
        public string ColorOfParrot
        {
            get { return colorOfParrot; }
            set { colorOfParrot = value; }
        }
        [NonSerialized]
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Parrot(string _colorOfParrot, string _gender, string _typeOfBirds) 
            : base(_typeOfBirds)
        {
            birds4 = new Birds("sky");
            ColorOfParrot = _colorOfParrot;
            Gender = _gender;
        }
        public override string ToString()
        {
            string result = this.TypeOfBirds + this.Gender + this.ColorOfParrot;
            return result;
        }
    }
}
