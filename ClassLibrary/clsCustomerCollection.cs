using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        public clsCustomerCollection()
        {



            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Andrew";
            TestItem.CustomerEmail = "Andrew@gmail.com";
            TestItem.CustomerDob = DateTime.ParseExact("26/09/1998", "dd/MM/yyyy", null);
            TestItem.CustomerPhoneNumber = "07853877987";
            TestItem.CustomerAddress = "98 Gresly Lane";
            mCustomerList.Add(TestItem);

            TestItem = new clsCustomer();
            TestItem.CustomerId = 2;
            TestItem.CustomerName = "Andy";
            TestItem.CustomerEmail = "Andy@gmail.com";
            TestItem.CustomerDob = DateTime.ParseExact("19/06/1988", "dd/MM/yyyy", null);
            TestItem.CustomerPhoneNumber = "07865900876";
            TestItem.CustomerAddress = "56 Hempsy Lane";
            mCustomerList.Add(TestItem);

        }
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {

            get { return mCustomerList; }

            set { mCustomerList = value; }
        }

        public int Count
        {

            get { return mCustomerList.Count; }

            set { }
        }
        public clsCustomer ThisCustomer { get; set; }

    }
}