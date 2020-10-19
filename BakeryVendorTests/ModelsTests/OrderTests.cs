using System;
using System.Collections.Generic;
using BakeryVendor.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakeryVendorTests 
{
    [TestClass]
    public class OrderTests : IDisposable 
    {
        public void Dispose () 
        {
            Order.ClearAll ();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Item () 
        {
            Order newOrder = new Order ("test", "test", 0, "test");
            Assert.AreEqual (typeof (Order), newOrder.GetType ());
        }

        [TestMethod]
        public void GetTitle_ReturnsTitle_String () 
        {
            //Arrange
            string title = "Donuts";
            Order newOrder = new Order (title, "test", 0, "test");

            //Act
            string result = newOrder.Title;

            //Assert
            Assert.AreEqual (title, result);
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String () 
        {
            //Arrange
            string description = "Full order of 12 dozen";
            Order newOrder = new Order ("test", description, 0, "test");

            //Act
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual (description, result);
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_Int () 
        {
            //Arrange
            int price = 124;
            Order newOrder = new Order ("test", "test", price, "test");

            //Act
            int result = newOrder.Price;

            //Assert
            Assert.AreEqual (price, result);
        }

        [TestMethod]
        public void GetDate_ReturnsDate_String () 
        {
            //Arrange
            string date = "12/4/20";
            Order newOrder = new Order ("test", "test", 0, date);

            //Act
            string result = newOrder.Date;

            //Assert
            Assert.AreEqual (date, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String () 
        {
            //Arrange
            string description = "Full order of Donuts.";
            Order newOrder = new Order ("test", description, 0, "test");

            //Act
            string updateDescription = "Half order of Donuts.";
            newOrder.Description = updateDescription;
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual (updateDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList () 
        {
            // Arrange
            List<Order> newList = new List<Order> ();

            // Act
            List<Order> result = Order.GetAll ();

            // Assert
            CollectionAssert.AreEqual (newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList () 
        {
            // Arrange
            string description01 = "12 rolls";
            string description02 = "4 buns";
            Order newOrder1 = new Order ("test", description01, 0, "test");
            Order newOrder2 = new Order ("test", description02, 0, "test");
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            // Act
            List<Order> result = Order.GetAll ();

            // Assert
            CollectionAssert.AreEqual (newList, result);
        }

        [TestMethod]
        public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
        {
            //Arrange
            string description = "15 pastries.";
            Order newOrder = new Order("test", description, 0, "test");

            //Act
            int result = newOrder.Id;

            //Assert
            Assert.AreEqual(1, result);
        }

         [TestMethod]
        public void Find_ReturnsCorrectOrder_Item()
        {
            //Arrange
            string description01 = "Walk the dog";
            string description02 = "Wash the dishes";
            Order newOrder1 = new Order("test", description01, 0, "test");
            Order newOrder2 = new Order("test", description02, 0, "test");

            //Act
            Order result = Order.Find(2);

            //Assert
            Assert.AreEqual(newOrder2, result);
        }
    }
}