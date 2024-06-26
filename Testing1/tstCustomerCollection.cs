﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{

    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Andrew";
            TestItem.CustomerEmail = "Andrew@gmail.com";
            TestItem.CustomerDob = DateTime.ParseExact("26/09/1998", "dd/MM/yyyy", null);
            TestItem.CustomerPhoneNumber = "07853877987";
            TestItem.CustomerAddress = "98 Gresly Lane";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerName = "Andrew";
            TestCustomer.CustomerEmail = "Andrew@gmail.com";
            TestCustomer.CustomerDob = DateTime.ParseExact("26/09/1998", "dd/MM/yyyy", null);
            TestCustomer.CustomerPhoneNumber = "07853877987";
            TestCustomer.CustomerAddress = "98 Gresly Lane";

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Andrew";
            TestItem.CustomerEmail = "Andrew@gmail.com";
            TestItem.CustomerDob = DateTime.ParseExact("26/09/1998", "dd/MM/yyyy", null);
            TestItem.CustomerPhoneNumber = "07853877987";
            TestItem.CustomerAddress = "98 Gresly Lane";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "JOEY NEIL";
            TestItem.CustomerEmail = "JNeil@gmail.com";
            TestItem.CustomerDob = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            TestItem.CustomerPhoneNumber = "07432988765";
            TestItem.CustomerAddress = "16 Cranberry Road";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 145;
            TestItem.CustomerName = "JOEY NEIL";
            TestItem.CustomerEmail = "JNeil@gmail.com";
            TestItem.CustomerDob = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            TestItem.CustomerPhoneNumber = "07432988765";
            TestItem.CustomerAddress = "16 Cranberry Road";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;

            TestItem.CustomerId = 147;
            TestItem.CustomerName = "JOEY NEIL";
            TestItem.CustomerEmail = "JNeil@gmail.com";
            TestItem.CustomerDob = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            TestItem.CustomerPhoneNumber = "07432988765";
            TestItem.CustomerAddress = "16 Cranberry Road";
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void DeleteMethod()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerId = 4;
            TestItem.CustomerName = "JOEY NEIL";
            TestItem.CustomerEmail = "JNeil@gmail.com";
            TestItem.CustomerDob = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            TestItem.CustomerPhoneNumber = "07432988765";
            TestItem.CustomerAddress = "16 Cranberry Road";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCustomerEmailMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerEmail("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByCustomerEmailNotFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerEmail("xxxxxxxxxxxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }



        [TestMethod]
        public void ReportByCustomerEmailTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            bool OK = true;
            FilteredCustomers.ReportByCustomerEmail("xxx");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerId != 310)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].CustomerId !=311)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}