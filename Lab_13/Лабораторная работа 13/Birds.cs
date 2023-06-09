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
    [XmlRoot("Human")]
    internal class Birds
    {
        private string typeOfBirds;
        public string TypeOfBirds
        {
            get { return typeOfBirds; }
            set { typeOfBirds = value; }
        }
        public Birds(string _typeOfBirds)
        {
            TypeOfBirds = _typeOfBirds;
        }
        public override string ToString()
        {
            string result = this.typeOfBirds;
            return result;
        }
    }
}
