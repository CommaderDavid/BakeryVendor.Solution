using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendor.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendorTests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Item()
        {
            Order newOrder = new Order("test", "test", 0, 0);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitle_ReturnsTitle_String()
        {
            //Arrange
            string title = "Donuts";
            Order newOrder = new Order(title, "test", 0, 0);

            //Act
            string result = newOrder.Title;

            //Assert
            Assert.AreEqual(title, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "Full order of 12 dozen";
            Order newOrder = new Order("test", description, 0, 0);

            //Act
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_Int()
        {
            //Arrange
            int price = 124;
            Order newOrder = new Order("test", "test", price, 0);

            //Act
            int result = newOrder.Price;

            //Assert
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void GetDate_ReturnsDate_Int()
        {
            //Arrange
            int date = 12;
            Order newOrder = new Order("test", "test", 0, date);

            //Act
            int result = newOrder.Date;

            //Assert
            Assert.AreEqual(date, result);
        }
    }
}