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

        [TestMethod]
        public void AddMethodOK()
        {
            //creater an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffName = "Adeyemi";
            TestItem.StaffSalary = 260000;
            TestItem.StaffRole = "Manager";
            TestItem.DateJoined = DateTime.Now;
            TestItem.StaffJobTitle = "Robotics Engineer";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffName = "Nathaniel";
            TestItem.StaffSalary = 260000;
            TestItem.StaffRole = "Administrator";
            TestItem.DateJoined = Convert.ToDateTime("04/06/2024");
            TestItem.StaffJobTitle = "Software Engineer";
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test record
            TestItem.StaffName = "Solomon";
            TestItem.StaffSalary = 260000;
            TestItem.StaffRole = "Staff";
            TestItem.DateJoined = Convert.ToDateTime("04/06/2024");
            TestItem.StaffJobTitle = "Software Engineer";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffName = "Test Name";
            TestItem.StaffSalary = 200000;
            TestItem.StaffID = 100;
            TestItem.StaffRole = "Test Role";
            TestItem.StaffJobTitle = "Test Job Title";
            TestItem.DateJoined = DateTime.Now;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the rercord
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse( Found );
        }

        [TestMethod]
        public void ReportByStaffRoleMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should retrun all records)
            FilteredStaff.ReportByStaffRole("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffRoleNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a staff role that doesn't exist
            FilteredStaff.ReportByStaffRole("stagg");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count );
        }

        [TestMethod]
        public void ReportByStaffRoleTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a staff role that doesn't exist
            FilteredStaff.ReportByStaffRole("Administrator");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check to see that the first record is 2
                if (FilteredStaff.StaffList[0].StaffID != 2)
                {
                    OK = false;
                }
                //check to see that the second record is 2
                if (FilteredStaff.StaffList[1].StaffID != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue( OK );
        }
    }
}
