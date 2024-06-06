using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);


        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);

        }


        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            int TestData = 3;
            AnCustomer.CustomerId = TestData;
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "JOHN SMITH";
            AnCustomer.customerName = TestData;
            Assert.AreEqual(AnCustomer.customerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "jsmith@gmail.com";
            AnCustomer.customerEmail = TestData;
            Assert.AreEqual(AnCustomer.customerEmail, TestData);
        }
        [TestMethod]
        public void CustomerDobPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = new DateTime(2004, 4, 10);
            AnCustomer.customerDob = TestData;
            Assert.AreEqual(AnCustomer.customerDob, TestData);
        }


        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "65 Apple Lane";
            AnCustomer.customerAddress = TestData;
            Assert.AreEqual(AnCustomer.customerAddress, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "07865888665";
            AnCustomer.customerPhoneNumber = TestData;
            Assert.AreEqual(AnCustomer.customerPhoneNumber, TestData);
        }




        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance od the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the Validation
            Boolean Found = false;
            //Create some test Data to use with the method
            int CustomerId = 7;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        public bool Find(int CustomerId)

        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerId = 7;
            Found = AnCustomer.Find(CustomerId);
            if(AnCustomer.CustomerId != 7)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
    }

