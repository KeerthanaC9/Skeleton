using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffSalary = 26000;
            TestItem.StaffName = "Adebayo";
            TestItem.StaffID = 1;
            TestItem.StaffJobTitle = "Software Engineer";
            TestItem.StaffRole = "Administrator";
            TestItem.DateJoined = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
            //create an instance of the class we want to create
            //clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //Int32 SomeCount = 0;
            //assign the data to the property
            //AllStaff.Count = SomeCount;
            //test to see that the two values are the same
            //Assert.AreEqual(AllStaff.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "Adebayo";
            TestStaff.StaffSalary = 26000;
            TestStaff.StaffJobTitle = "Software Engineer";
            TestStaff.DateJoined = DateTime.Now;
            TestStaff.StaffRole = "Administrator";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the propeerty
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //creat the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 1;
            TestItem.StaffName = "Adebayo";
            TestItem.StaffSalary = 26000;
            TestItem.StaffJobTitle = "Software Engineer";
            TestItem.DateJoined = DateTime.Now;
            TestItem.StaffRole = "Administrator";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }
}
