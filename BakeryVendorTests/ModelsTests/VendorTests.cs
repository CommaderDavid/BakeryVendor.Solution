using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendor.Models;

namespace BakeryVendorTests 
{
    [TestClass]
    public class VendorTests : IDisposable 
    {
        public void Dispose () 
        {
            Vendor.ClearAll ();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor () 
        {
            Vendor newVendor = new Vendor ("test", "test");
            Assert.AreEqual (typeof (Vendor), newVendor.GetType ());
        }

        [TestMethod]
        public void GetName_ReturnsName_Name ()
        {
            //Arrange
            string name = "Test name";
            Vendor newVendor = new Vendor (name, "test");

            //Act
            string result = newVendor.Name;

            //Assert
            Assert.AreEqual (name, result);
        }

         [TestMethod]
        public void GetId_ReturnsVendorId_Int () 
        {
            //Arrange
            string name = "Test Vendor";
            Vendor newVendor = new Vendor (name, "test");

            //Act
            int result = newVendor.Id;

            //Assert
            Assert.AreEqual (1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList () 
        {
            //Arrange
            string name01 = "Work";
            string name02 = "School";
            Vendor newVendor1 = new Vendor (name01, "test");
            Vendor newVendor2 = new Vendor (name02, "test");
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

            //Act
            List<Vendor> result = Vendor.GetAll ();

            //Assert
            CollectionAssert.AreEqual (newList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor () 
        {
            //Arrange
            string name01 = "Work";
            string name02 = "School";
            Vendor newVendor1 = new Vendor (name01, "test");
            Vendor newVendor2 = new Vendor (name02, "test");

            //Act
            Vendor result = Vendor.Find (2);

            //Assert
            Assert.AreEqual (newVendor2, result);
        }

        [TestMethod]
        public void AddOrder_AssociatesOrderWithVendor_OrderList () 
        {
            // Arrange
            string description = "Full order of Donuts";
            Order newOrder = new Order ("test", description, 0, "test");
            List<Order> newList = new List<Order> { newOrder };
            string name = "Vandels Donuts & Coffee";
            Vendor newVendor = new Vendor (name, "test");
            newVendor.AddOrder (newOrder);

            // Act
            List<Order> result = newVendor.Orders;

            // Assert
            CollectionAssert.AreEqual (newList, result);
        }
    }
}