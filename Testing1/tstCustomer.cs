using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string CustomerName = "Yahya";
        string CustomerEmail = "Y@gmail.com";
        string CustomerPhoneNumber = "07853877654";
        string CustomerAddress = "17 Happy Lane";
        string CustomerDob = "12/03/2004";
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
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
            AnCustomer.CustomerName = TestData;
            Assert.AreEqual(AnCustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "jsmith@gmail.com";
            AnCustomer.CustomerEmail = TestData;
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerDobPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = new DateTime(2004, 4, 10);
            AnCustomer.CustomerDob = TestData;
            Assert.AreEqual(AnCustomer.CustomerDob, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "65 Apple Lane";
            AnCustomer.CustomerAddress = TestData;
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "07865888665";
            AnCustomer.CustomerPhoneNumber = TestData;
            Assert.AreEqual(AnCustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            int CustomerId = 7;
            Found = AnCustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerId = 7;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerId != 7)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerId = 7;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerName != "Test Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerEmail != "Test Email")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDobFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerId = 7;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerDob != Convert.ToDateTime("26/09/2002"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




























































































































































        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerId = 7;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerAddress != "Test Address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneNumberFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerId = 7;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerPhoneNumber != "Test Number")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
    }


}
