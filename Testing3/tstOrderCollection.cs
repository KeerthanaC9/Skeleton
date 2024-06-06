using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderId = 9;
            TestItem.CustomerId = 10;
            TestItem.OrderDate = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            TestItem.ProductId = 5;
            TestItem.TotalPrice = 15.50f;
            TestItem.Active = true;
            TestItem.Delivered = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.CustomerId = 10;
            TestOrder.OrderDate = DateTime.ParseExact("05/10/2024", "dd/MM/yyyy", null);
            TestOrder.ProductId = 5;
            TestOrder.TotalPrice = 15.50f;
            TestOrder.Active = true;
            TestOrder.Delivered = true;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.CustomerId = 10;
            TestItem.OrderDate = DateTime.ParseExact("05/10/2024", "dd/MM/yyyy", null);
            TestItem.ProductId = 5;
            TestItem.TotalPrice = 15.50f;
            TestItem.Active = true;
            TestItem.Delivered = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderId = 9;
            TestItem.CustomerId = 10;
            TestItem.OrderDate = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            TestItem.ProductId = 5;
            TestItem.TotalPrice = 15.50f;
            TestItem.Active = true;
            TestItem.Delivered = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 10;
            TestItem.OrderDate = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            TestItem.ProductId = 5;
            TestItem.TotalPrice = 15.50f;
            TestItem.Active = true;
            TestItem.Delivered = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            TestItem.CustomerId = 15;
            TestItem.OrderDate = DateTime.ParseExact("26/09/2003", "dd/MM/yyyy", null);
            TestItem.ProductId = 9;
            TestItem.TotalPrice = 17.50f;
            TestItem.Active = false;
            TestItem.Delivered = false;
            AllOrders.ThisOrder = TestItem;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual (AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the order collection and a test order
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            // Create a primary key variable
            int PrimaryKey = 0;
            // Set the properties of the test item
            TestItem.CustomerId = 5;
            TestItem.OrderDate = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            TestItem.ProductId = 5;
            TestItem.TotalPrice = 15.50f;
            TestItem.Active = true;
            TestItem.Delivered = true;

            // Assign the test item to the collection
            AllOrders.ThisOrder = TestItem;

            // Add the test item to the collection and get the primary key
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;

            // Find the test item in the collection
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            // Ensure the item was found
            Assert.IsTrue(Found);

            // Delete the test item from the collection
            AllOrders.Delete();

            // Try to find the test item again
            Found = AllOrders.ThisOrder.Find(PrimaryKey);

            // Assert that the item is not found after deletion
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByOrderDateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderDate("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderdateTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByOrderDate("06/01/2003");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderId != 4)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderId != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }
}
