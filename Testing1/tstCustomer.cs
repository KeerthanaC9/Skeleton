
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.IO;



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
            int TestData = 143;
            AnCustomer.CustomerId = TestData;
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "Daemon Targaryen";
            AnCustomer.CustomerName = TestData;
            Assert.AreEqual(AnCustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "DTagaryen@gmail.com";
            AnCustomer.CustomerEmail = TestData;
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerDobPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = new DateTime(08 / 07 / 2004);
            AnCustomer.CustomerDob = TestData;
            Assert.AreEqual(AnCustomer.CustomerDob, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "13 Dragon Stone LE4 6JK";
            AnCustomer.CustomerAddress = TestData;
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "07692222768";
            AnCustomer.CustomerPhoneNumber = TestData;
            Assert.AreEqual(AnCustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            int CustomerId = 143;
            Found = AnCustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerId = 143;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerId != 143)
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
            int CustomerId = 143;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerName != "Daemon Targaryen")
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
            int CustomerId = 143;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerEmail != "DTagaryen@gmail.com")
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
            int CustomerId = 143;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerDob != Convert.ToDateTime("08/07/2004"))
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
            int CustomerId = 143;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerAddress != "13 Dragon Stone LE4 6JK")
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
            int CustomerId = 143;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerPhoneNumber != "07692222768")
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


        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerName = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNamePlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerDob = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
         public void CustomerDobMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-17);
            string CustomerDob = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            string CustomerDob = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-19);
            string CustomerDob = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-109);
            string CustomerDob = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-110);
            string CustomerDob = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-111);
            string CustomerDob = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-55);
            string CustomerDob = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-150);
            string CustomerDob = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPhoneNumber = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhoneNumber = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhoneNumber = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhoneNumber = "";
            CustomerPhoneNumber = CustomerPhoneNumber.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhoneNumber = "";
            CustomerPhoneNumber = CustomerPhoneNumber.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerPhoneNumber = "";
            CustomerPhoneNumber = CustomerPhoneNumber.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhoneNumber = "";
            CustomerPhoneNumber = CustomerPhoneNumber.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPhoneNumber = "";
            CustomerPhoneNumber = CustomerPhoneNumber.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
 public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatStatisticsGroupByEmail()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DataTable dT = AnCustomer.StatisticsGroupByEmail();
            int noOfRecord = 6;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatisticsGroupDob()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DataTable dT = AnCustomer.StatisticsGroupDob();
            int noOfRecord = 7;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

    }


}
