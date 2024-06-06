using ClassLibrary;
using FsCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method
        string OrderId = "3";
        string CustomerId = "3";
        string OrderDate = DateTime.Now.ToShortDateString();
        string ProductId = "8";
        string TotalPrice = "11.50";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we weant to create 
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActiveOrderOK()
        {
            //create an instance of the class we weant to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnOrder.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void OrderDateOrderOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void ProductIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            AnOrder.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductId, TestData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 0;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void OrderDeliveredOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AnOrder.OrderDelivered = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDelivered, TestData);
        }

        [TestMethod]
        public void TotalPriceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            float TestData = 7.5f;
            //assign the data to the property
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int OrderId = 5;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        public void AddMethodOK()
        {
            //create an instanfe of he class we want to create 
            clsOrder AllOrders = new clsOrder();
            //Create the item of the test data 
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.OrderDelivered = true;
            TestItem.CustomerId = 8;
            TestItem.TotalPrice = 14.50f;
            TestItem.ProductId = 3;
            TestItem.OrderId = 7;
            //set this order to the test data 
            AllOrders.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the ytest data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 5;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the Order id property
            if (AnOrder.OrderId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = AnOrder.Find(CustomerId);
            //check the customer id property
            if (AnOrder.CustomerId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 5;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the date added property
            if (AnOrder.OrderDate != Convert.ToDateTime("01/11/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 3;
            //invoke the method
            Found = AnOrder.Find(ProductId);
            //check the product id property
            if (AnOrder.ProductId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 5;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the total price property
            if (AnOrder.TotalPrice != 7.50)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 5;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the active property
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestDeliveredFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 5;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the Order Delivered property
            if (AnOrder.OrderDelivered != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void CustomerIdMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string CustomerId = ""; //this should trigger an error 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void CustomerIdMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string CustomerId = "1"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void CustomerIdMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string CustomerId = "11"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void CustomerIdMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string CustomerId = "111111111"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void CustomerIdMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string CustomerId = "1111111111"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void CustomerIdMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string CustomerId = "1111111111"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void CustomerIdMid()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string CustomerId = "11111"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void CustomerIdExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string CustomerId = "";
            CustomerId = CustomerId.PadRight(100, '1'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 years 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void OrderDateMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 years 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 years 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void OrderDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void ProductIdMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string ProductId = ""; //this should trigger an error 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void ProductIdMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string ProductId = "1"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void ProductIdMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string ProductId = "11"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void ProductIdMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string ProductId = "111111111"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void ProductIdMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string ProductId = "1111111111"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void ProductIdMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string ProductId = "1111111111"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void ProductIdMid()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string ProductId = "11111"; //this should be ok 
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void ProductIdExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method
            string ProductId = "";
            ProductId = ProductId.PadRight(100, '1'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the only accepted number of digits 
            TestPrice = 11.11m;
            //change the price to whatever the accepted number of digits less 1
            TestPrice = TestPrice - 00.01m; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void TotalPriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the only accepted number of digits 
            TestPrice = 11.11m;
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the only accepted number of digits 
            TestPrice = 11.11m;
            //change the price to whatever the accepted number of digits less 1
            TestPrice = TestPrice + 100.00m; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void TotalPriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test price data
            decimal TestPrice;
            //set the price to the only accepted number of digits 
            TestPrice = 11.11m;
            //change the price to whatever the accepted number of digits less 1
            TestPrice = TestPrice + 11111100.00m; //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void TotalPriceInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the TotalPrice to a non-price value
            string TotalPrice = "this is not a price!";
            //invoke the method
            Error = AnOrder.Valid(OrderId, CustomerId, OrderDate, ProductId, TotalPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
    
}