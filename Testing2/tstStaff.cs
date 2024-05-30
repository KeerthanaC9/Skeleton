using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffID = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            String TestData = "Adebayo Olowofoyeku";
            AStaff.StaffName = TestData;
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            String TestData = "Administrator";
            AStaff.StaffRole = TestData;
            Assert.AreEqual(AStaff.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 26000;
            AStaff.StaffSalary = TestData;
            Assert.AreEqual(AStaff.StaffSalary, TestData);
        }

        [TestMethod]
        public void StaffJobTitlePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            String TestData = "Software Engineer";
            AStaff.StaffJobTitle = TestData;
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
            if (AStaff.DateJoined != Convert.ToDateTime("03/05/2024"))
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
            if (AStaff.StaffName != "Adebayo")
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
            if (AStaff.StaffRole != "Administrator")
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
            if (AStaff.StaffSalary != 260000)
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
            if (AStaff.StaffJobTitle != "Software Engineer")
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

    }
}
