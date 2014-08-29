using NUnit.Framework;
using System;
using Terradue.ESA.Sentinel.Classes.S1;

namespace Terradue.ESA.Sentinel {

    [TestFixture()]
    public class ProductTests {

        [Test()]
        public void DeserializeL1ProductType() {

            l1ProductType product = l1ProductType.FromAnnotationXml("../Terradue/ESA/Sentinel/Samples/rs2-iw1-slc-hh-20130426t045831-20130426t045914-001771-000001-001.xml");
            Assert.AreEqual(product.adsHeader.startTime, DateTime.Parse("2013-04-26T04:58:31.024003"), "Error reading the start date of the product");


        }
    }
}

