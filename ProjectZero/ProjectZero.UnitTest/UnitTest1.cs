using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectZero.Libraries.Classes;

namespace ProjectZero.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RestaurantReadTestMethod()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Restaurant>));
            DataHandler dh = new DataHandler();
            List<Restaurant> restaurants = dh.Read();
            int expected = 2;
            int actual = restaurants.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
