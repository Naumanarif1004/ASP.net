using System;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Model
{
   [Serializable]
    [XmlRoot]
    public class PersonInf
    {
        public PersonInf()
        {

        }
        [XmlAnyAttribute]
        public int PersonId { get; set; }
        [XmlElement]
        public string PersonName { get; set; }
        [XmlElement]
        public DateTime created { get; set; }
    }
}
