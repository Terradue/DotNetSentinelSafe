using System;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Terradue.ESA.Sentinel.Classes.S1 {
    public partial class l1ProductType {

        public static l1ProductType FromAnnotationXml(string filename){

            FileStream annotationXmlStream = File.OpenRead(filename);
            XmlReader annotationXmlReader = XmlReader.Create(annotationXmlStream);
            XmlSerializer serializer = new XmlSerializer(typeof(Terradue.ESA.Sentinel.Classes.S1.l1ProductType));

            Terradue.ESA.Sentinel.Classes.S1.l1ProductType product = (Terradue.ESA.Sentinel.Classes.S1.l1ProductType)serializer.Deserialize(annotationXmlReader);

            return product;

        }

    }
}

