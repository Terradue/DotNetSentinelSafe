using System;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Terradue.Sentinel.Safe.Sar {
    public partial class l1ProductType {

        public static l1ProductType FromAnnotationXml(string filename){

            FileStream annotationXmlStream = File.OpenRead(filename);
            XmlReader annotationXmlReader = XmlReader.Create(annotationXmlStream);
            XmlSerializer serializer = new XmlSerializer(typeof(l1ProductType));

            l1ProductType product = (l1ProductType)serializer.Deserialize(annotationXmlReader);

            return product;

        }

    }
}

