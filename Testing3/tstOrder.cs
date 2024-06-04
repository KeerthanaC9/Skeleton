// using ClassLibrary;
// using FsCheck;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System;

// namespace Testing3
// {
//     [TestClass]
//     public class tstOrder
//     {
//         [TestMethod]
//         public void InstanceOK()
//         {
//             //create an instance of the class we weant to create 
//             clsOrder AnOrder = new clsOrder();
//             //test to see that it exists
//             Assert.IsNotNull(AnOrder);
//         }

//         [TestMethod]
//         public void ActiveOrderOK()
//         {
//             //create an instance of the class we weant to create 
//             clsOrder AnOrder = new clsOrder();
//             //create some test data to assign to the property 
//             Boolean TestData = true;
//             //assign the data to the property 
//             AnOrder.Active = TestData;
//             //test to see that the two values are the same 
//             Assert.AreEqual(AnOrder.Active, TestData);
//         }

//         [TestMethod]
//         public void DateAddedOrderOK()
//         {
//             //create an instance of the class we want to create 
//             clsOrder AnOrder = new clsOrder();
//             //create some test data to assign to the property 
//             DateTime TestData = DateTime.Now.Date;
//             //assign the data to the property 
//             AnOrder.DateAdded = TestData;
//             //test to see that the two values are the same 
//             Assert.AreEqual(AnOrder.DateAdded, TestData);
//         }

//         [TestMethod]
//         public void OrderIdOK()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create some test data to assign to the property
//             Int32 TestData = 1;
//             //assign the data to the property
//             AnOrder.OrderId = TestData;
//             //test to see that the two values are the same
//             Assert.AreEqual(AnOrder.OrderId, TestData);
//         }

//         [TestMethod]
//         public void ProductIdOK()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create some test data to assign to the property
//             Int32 TestData = 1;
//             //assign the data to the property
//             AnOrder.ProductId = TestData;
//             //test to see that the two values are the same
//             Assert.AreEqual(AnOrder.ProductId, TestData);
//         }

//         [TestMethod]
//         public void CustomerIdOK()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create some test data to assign to the property
//             Int32 TestData = 1;
//             //assign the data to the property
//             AnOrder.CustomerId = TestData;
//             //test to see that the two values are the same
//             Assert.AreEqual(AnOrder.CustomerId, TestData);
//         }

//         [TestMethod]
//         public void OrderDeliveredOK()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create some test data to assign to the property
//             bool TestData = true;
//             //assign the data to the property
//             AnOrder.OrderDelivered = TestData;
//             //test to see that the two values are the same
//             Assert.AreEqual(AnOrder.OrderDelivered, TestData);
//         }

//         [TestMethod]
//         public void TotalPriceOK()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create some test data to assign to the property
//             float TestData = 100.0f;
//             //assign the data to the property
//             AnOrder.TotalPrice = TestData;
//             //test to see that the two values are the same
//             Assert.AreEqual(AnOrder.TotalPrice, TestData);
//         }

//         public void FindMethodOK()
//         {
//             //create instance of the class we wan to create 
//             clsOrder AnOrder = new clsOrder();
//             //create a boolean variable to store the results of the validation
//             Boolean Found = false;
//             //create some test data to use with the method 
//             Int32 OrderId = 21;
//             //Invoke the method
//             Found = AnOrder.Find(OrderId);
//             //test to see if the result is true 
//             Assert.IsTrue(Found);
//         }

//         public void TestOrderIdFound()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create a Boolean variable to store the result of the search
//             Boolean Found = false;
//             //create a Boolean variable to record if the data is OK (assume it is)
//             Boolean OK = true;
//             //create some test data to use with the method
//             Int32 OrderId = 7;
//             //invoke the method
//             Found = AnOrder.Find(OrderId);
//             //check the Order id property
//             if (AnOrder.OrderId != 7)
//             {
//                 OK = false;
//             }
//             //test to see that the result is correct
//             Assert.IsTrue(OK);
//         }

//         public void TestCustomerIdFound()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create a Boolean variable to store the result of the search
//             Boolean Found = false;
//             //create a Boolean variable to record if the data is OK (assume it is)
//             Boolean OK = true;
//             //create some test data to use with the method
//             Int32 CustomerId = 43;
//             //invoke the method
//             Found = AnOrder.Find(CustomerId);
//             //check the customer id property
//             if (AnOrder.CustomerId != 43)
//             {
//                 OK = false;
//             }
//             //test to see that the result is correct
//             Assert.IsTrue(OK);
//         }

//         public void TestOrderDateFound()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create a Boolean variable to store the result of the search
//             Boolean Found = false;
//             //create Boolean variable to record if the data is OK (assume it is)
//             Boolean OK = true;
//             //create some test data to use with the method
//             Int32 OrderId = 7;
//             //invoke the method
//             Found = AnOrder.Find(OrderId);
//             //check the date added property
//             if (AnOrder.OrderDate != Convert.ToDateTime("06/01/2008"))
//             {
//                 OK = false;
//             }
//             //test to see that the result is correct
//             Assert.IsTrue(OK);
//         }

//         public void TestProductIdFound()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create a Boolean variable to store the result of the search
//             Boolean Found = false;
//             //create a Boolean variable to record if the data is OK (assume it is)
//             Boolean OK = true;
//             //create some test data to use with the method
//             Int32 ProductId = 157;
//             //invoke the method
//             Found = AnOrder.Find(ProductId);
//             //check the product id property
//             if (AnOrder.ProductId != 157)
//             {
//                 OK = false;
//             }
//             //test to see that the result is correct
//             Assert.IsTrue(OK);
//         }

//         public void TestTotalPriceFound()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create a Boolean variable to store the result of the search
//             Boolean Found = false;
//             //create Boolean variable to record if the data is OK (assume it is)
//             Boolean OK = true;
//             //create some test data to use with the method
//             Int32 OrderId = 7;
//             //invoke the method
//             Found = AnOrder.Find(OrderId);
//             //check the total price property
//             if (AnOrder.TotalPrice != 157)
//             {
//                 OK = false;
//             }
//             //test to see that the result is correct
//             Assert.IsTrue(OK);
//         }

//         public void TestActiveFound()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create a Boolean variable to store the result of the search
//             Boolean Found = false;
//             //create Boolean variable to record if the data is OK (assume it is)
//             Boolean OK = true;
//             //create some test data to use with the method
//             Int32 OrderId = 7;
//             //invoke the method
//             Found = AnOrder.Find(OrderId);
//             //check the active property
//             if (AnOrder.Active != true)
//             {
//                 OK = false;
//             }
//             //test to see that the result is correct
//             Assert.IsTrue(OK);
//         }

//         public void TestDeliveredFound()
//         {
//             //create an instance of the class we want to create
//             clsOrder AnOrder = new clsOrder();
//             //create a Boolean variable to store the result of the search
//             Boolean Found = false;
//             //create Boolean variable to record if the data
