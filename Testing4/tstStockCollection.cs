using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Available = true;
            TestItem.ShoeId = 7;
            TestItem.ShoeName = "Nike Dunk Low";
            TestItem.Supplier = "Nike";
            TestItem.ShoeSize = 6;
            TestItem.ShoeColor = "Green";
            TestItem.ShoePrice = 60.00m;
            TestItem.DateUpdated = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

      

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.Available = true;
            TestStock.ShoeId = 7;
            TestStock.ShoeName = "Nike Dunk Low";
            TestStock.Supplier = "Nike";
            TestStock.ShoeSize = 6;
            TestStock.ShoeColor = "Green";
            TestStock.ShoePrice = 60.00m;
            TestStock.DateUpdated = DateTime.Now;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }



        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.ShoeId = 7;
            TestItem.ShoeName = "Nike Dunk Low";
            TestItem.Supplier = "Nike";
            TestItem.ShoeSize = 6;
            TestItem.ShoeColor = "Green";
            TestItem.ShoePrice = 60.00m;
            TestItem.DateUpdated = DateTime.Now;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.ShoeId = 7;
            TestItem.ShoeName = "Nike Dunk Low";
            TestItem.Supplier = "Nike";
            TestItem.ShoeSize = 6;
            TestItem.ShoeColor = "Green";
            TestItem.ShoePrice = 60.00m;
            TestItem.DateUpdated = DateTime.Now;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ShoeId = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.ShoeName = "Nike Dunk Low";
            TestItem.DateUpdated = DateTime.Now;
            TestItem.Supplier = "Nike";
            TestItem.ShoeSize = 6;
            TestItem.ShoeColor = "Green";
            TestItem.ShoePrice = 60.00m;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.ShoeId = PrimaryKey;
            //modify the test record
            TestItem.Available = false;
            TestItem.ShoeName = "Puma Palermo";
            TestItem.DateUpdated = DateTime.Now;
            TestItem.Supplier = "Puma";
            TestItem.ShoeSize = 7;
            TestItem.ShoePrice = 80.00m;
            //set the record based on the new test data
            AllStocks.ThisStock = TestItem;
            //update the record
            AllStocks.Update();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.ShoeId = 7;
            TestItem.ShoeName = "Nike Dunk Low";
            TestItem.DateUpdated = DateTime.Now;
            TestItem.Supplier = "Nike";
            TestItem.ShoeSize = 6;
            TestItem.ShoeColor = "Green";
            TestItem.ShoePrice = 60.00m;
            //set this stock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.ShoeId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySupplierMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string (should return all records);
            FilteredStocks.ReportBySupplier("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportBySupplierNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a supplier name that doesn't exist
            FilteredStocks.ReportBySupplier("xxxxx");
            //test to see that there no records
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportBySupplierTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a supplier name that doesn't exist
            FilteredStocks.ReportBySupplier("xxxx");
            //check that the correct number of records are found
            if (FilteredStocks.Count == 2)
            {
                //check to see that the first record is 162
                if (FilteredStocks.StockList[0].ShoeId != 162)
                {
                    OK = false;
                }
                //check to see that the first recoord is 163
                if (FilteredStocks.StockList[1].ShoeId != 163)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

             
    }
}
