using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass the method
        string StaffSalary = "26000";
        string StaffJobTitle = "Test Job";
        string StaffRole = "Test Role";
        string StaffName = "Test Name";
        string DateJoined = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateJoined, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Adebayo Olowofoyeku";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Administrator";
            //assign the data to the property
            AStaff.StaffRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 26000;
            //assign the data to the property
            AStaff.StaffSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffSalary, TestData);
        }

        [TestMethod]
        public void StaffJobTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Software Engineer";
            //assign the data to the property
            AStaff.StaffJobTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffJobTitle, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staff id
            if (AStaff.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staff id
            if (AStaff.DateJoined != Convert.ToDateTime("04/06/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staff id
            if (AStaff.StaffName != "Adeola")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staff id
            if (AStaff.StaffRole != "Staff")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staff id
            if (AStaff.StaffSalary != 400000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffJobTitleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the staff id
            if (AStaff.StaffJobTitle != "Cyber Security")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffJobTitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffJobTitle = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffJobTitleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffJobTitle = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffJobTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffJobTitle = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffJobTitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffJobTitle = ""; //this should be ok
            StaffJobTitle = StaffJobTitle.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffJobTitleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffJobTitle = ""; //this should be ok
            StaffJobTitle = StaffJobTitle.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffJobTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffJobTitle = ""; //this should be ok
            StaffJobTitle = StaffJobTitle.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffJobTitleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffJobTitle = ""; //this should be ok
            StaffJobTitle = StaffJobTitle.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; //this should be ok
            StaffName = StaffName.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; //this should be ok
            StaffName = StaffName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; //this should be ok
            StaffName = StaffName.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; //this should be ok
            StaffName = StaffName.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = ""; //this should be ok
            StaffRole = StaffRole.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffRoleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = ""; //this should be ok
            StaffRole = StaffRole.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = ""; //this should be ok
            StaffRole = StaffRole.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffRoleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = ""; //this should be ok
            StaffRole = StaffRole.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = Convert.ToDateTime("26/04/2024");
            //change the data to whatever the dat is plus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = Convert.ToDateTime("26/04/2024");
            //change the data to whatever the dat is plus 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = Convert.ToDateTime("26/04/2024");
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = Convert.ToDateTime("26/04/2024");
            //change the data to whatever the dat is plus 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            TestDate = Convert.ToDateTime("18/05/2024");
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the dat is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateJoinedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateJoined = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedBlank()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateJoined = "";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "-9999999999999";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryBlank()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "-1";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "0";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "1";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "a";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            //the max value for a 32 bit integer is 2147483647
            string StaffSalary = "2147483646";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            //the max value for a 32 bit integer is 2147483647
            string StaffSalary = "2147483647";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            System.Diagnostics.Debug.WriteLine(Error);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            //the max value for a 32 bit integer is 2147483647
            string StaffSalary = "2147483648";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            System.Diagnostics.Debug.WriteLine(Error);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "1073741823";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            System.Diagnostics.Debug.WriteLine(Error);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "9999999999999";
            //invoke the method
            Error = AStaff.Valid(StaffSalary, StaffJobTitle, StaffName, StaffRole, DateJoined);
            System.Diagnostics.Debug.WriteLine(Error);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StatStatisticsGroupedByStaffSalary()
        {
            //creste an instance of the eclass we want to create
            clsStaff AStaff = new clsStaff();
            //invoke the method
            DataTable dT =  AStaff.StatisticsGroupedByStaffSalary();
            //According to the last executed stored procedure, there should be rows of data
            int noOfRecord = 3;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatisticsGroupedByDateJoined()
        {
            //creste an instance of the eclass we want to create
            clsStaff AStaff = new clsStaff();
            //invoke the method
            DataTable dT = AStaff.StatisticsGroupedDateJoined();
            //According to the last executed stored procedure, there should be rows of data
            int noOfRecord = 2;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

    }
}
