using ClassLibrary;
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
        
    } }


   