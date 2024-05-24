using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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

    }
}
