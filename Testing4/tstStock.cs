using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.IO;
using System.IO.Pipes;
using System.Security.Cryptography;

namespace Testing4
{


    [TestClass]
    public class tstStock
    {
        //good test data 
        //create some test data to pass the method
        string ShoeName = "Nike Air Force 1";
        string Supplier = "Nike";
        string ShoeColor = "Blue";
        string DateUpdated = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]

        public void AvailablePropertyOK()
        {
            clsStock AStock = new clsStock();

            Boolean TestData = true;

            AStock.Available = TestData;

            Assert.AreEqual(AStock.Available, TestData);
        }

        [TestMethod]

        public void DateUpdatedPropertyOK()
        {

            clsStock AStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            AStock.DateUpdated = TestData;

            Assert.AreEqual(AStock.DateUpdated, TestData);
        }

        [TestMethod]

        public void ShoeIdPropertyOK()
        {
            clsStock AStock = new clsStock();

            Int32 TestData = 1;

            AStock.ShoeId = TestData;

            Assert.AreEqual(AStock.ShoeId, TestData);
        }

        [TestMethod]

        public void ShoeNamePropertyOK()
        {
            clsStock AStock = new clsStock();

            string TestData = "Nike Air Force 1";

            AStock.ShoeName = TestData;

            Assert.AreEqual(AStock.ShoeName, TestData);
        }

        [TestMethod]

        public void SupplierPropertyOK()
        {
            clsStock AStock = new clsStock();

            string TestData = "Nike";

            AStock.Supplier = TestData;

            Assert.AreEqual(AStock.Supplier, TestData);
        }

        [TestMethod]

        public void ShoeSizePropertyOK()
        {
            clsStock AStock = new clsStock();

            Int32 TestData = 6;

            AStock.ShoeSize = TestData;

            Assert.AreEqual(AStock.ShoeSize, TestData);
        }

        [TestMethod]

        public void ShoeColorPropertyOK()
        {
            clsStock AStock = new clsStock();

            string TestData = "blue";

            AStock.ShoeColor = TestData;

            Assert.AreEqual(AStock.ShoeColor, TestData);
        }

        [TestMethod]

        public void ShoePricePropertyOK()
        {
            clsStock AStock = new clsStock();

            decimal TestData = 70.00m;

            AStock.ShoePrice = TestData;

            Assert.AreEqual(AStock.ShoePrice, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ShoeId = 7;
            //invoke the method
            Found = AStock.Find(ShoeId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestShoeIdFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeId = 7;
            //invoke the method
            Found = AStock.Find(ShoeId);
            //check the shoe id
            if (AStock.ShoeId != 7)
            {
                OK = false;
            }
            //test to see that the result is corrct
            Assert.IsTrue(OK);



        }
        [TestMethod]

        public void TestShoeNameFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShoeId = 7;
            Found = AStock.Find(ShoeId);
            if (AStock.ShoeName != "Nike Dunk Low")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestSupplierFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShoeId = 7;
            Found = AStock.Find(ShoeId);
            if (AStock.Supplier != "Nike")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestShoeSizeFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShoeId = 7;
            Found = AStock.Find(ShoeId);
            if (AStock.ShoeSize != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestShoeColorFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShoeId = 7;
            Found = AStock.Find(ShoeId);
            if (AStock.ShoeColor != "Green")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestShoePriceFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShoeId = 7;
            Found = AStock.Find(ShoeId);
            if (AStock.ShoePrice != Convert.ToDecimal(60.00m))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateUpdatedFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShoeId = 7;
            Found = AStock.Find(ShoeId);
            if (AStock.DateUpdated != Convert.ToDateTime("16/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestAvailableFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ShoeId = 7;
            Found = AStock.Find(ShoeId);
            if (AStock.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ShoeNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string ShoeName = ""; // this should trigger an error
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeNameMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "aa"; //This should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShoeName = "";
            ShoeName = ShoeName.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeNameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShoeName = "";
            ShoeName = ShoeName.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeNameMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShoeName = "";
            ShoeName = ShoeName.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeName = "";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "";
            ShoeName = ShoeName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Supplier = "";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMin()
        {
            //create an insatnce of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier = "a";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the reuslt is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier = "aa";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMaxLessOne()
        {
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier = "";
            Supplier = Supplier.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier = "";
            Supplier = Supplier.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Supplier = "";
            Supplier = Supplier.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to sore any error message
            String Error = "";
            //this should pass
            string Supplier = "";
            Supplier = Supplier.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the reuslt is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            Supplier = Supplier.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void ShoeColorMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to sore any error message
            String Error = "";
            //this should fail
            string ShoeColor = "";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColorMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShoeColor = "a";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void ShoeColorMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pas
            string ShoeColor = "aa";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColorMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShoeColor = "";
            ShoeColor = ShoeColor.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColorMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShoeColor = "";
            ShoeColor = ShoeColor.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void ShoeColorMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeColor = "";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColorMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //tring variabble to store any error message
            String Error = "";
            //this should pass
            string ShoeColor = "";
            ShoeColor = ShoeColor.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoeColorExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store nay error message
            String Error = "";
            //create some test data to pass the method
            string ShoeColor = "";
            ShoeColor = ShoeColor.PadRight(500, 'a'); //This should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateUpdatedExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String DateUpdated = TestDate.ToString();
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateUpdatedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateUpdated = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateUpdatedMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateUpdated = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateUpdatedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateUpdated = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateUpdatedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateUpdated = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void DateUpdatedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the DateUpdated to a non date value
            string DateUpdated = "this is not a date!";
            //invoke the method
            Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StatStatisticsGroupedByShoeName()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //invoke the method
            DataTable dT = AStock.StatisticsGroupedByShoeName();
            //According to the last executed stored procedure, there shoul dbe three rows of data 
            int noOfRecord = 8;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }


        [TestMethod]
        public void StatStatisticsGroupedByDateUpdated()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //invoke the method
            DataTable dT = AStock.StatisticsGroupedByDateUpdated();
            //According to the last executed stored procedure, there shoul dbe three rows of data 
            int noOfRecord = 13;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }





    }

}


