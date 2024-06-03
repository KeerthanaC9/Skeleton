using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    { 
        // Declare the list and the current customer
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        // Constructor
        public clsCustomerCollection()
        {
            // Initialize database connection and fetch records
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            Int32 RecordCount = DB.Count;
            Int32 Index = 0;

            while (Index < RecordCount)
            {
                // Create a new customer object
                clsCustomer AnCustomer = new clsCustomer();

                // Populate the customer object with data from the database
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerDob = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDob"]);
                AnCustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNumber"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);

                // Add the customer object to the list
                mCustomerList.Add(AnCustomer);

                // Move to the next record
                Index++;
            }

            // Optionally add test data here, but this should be removed in production
            AddTestData();
        }

        // Property to access the customer list
        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }

        // Property to get the count of customers
        public int Count
        {
            get { return mCustomerList.Count; }
            set { }
        }

        // Property to access the current customer
        public clsCustomer ThisCustomer
        {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }

        // Method to add a new customer (stub)
        public int Add()
        {
            // Simulate adding a customer and returning a new ID
            mThisCustomer.CustomerId = 123;
            return mThisCustomer.CustomerId;
        }

        // Method to add test data for debugging purposes
        private void AddTestData()
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
    }
}
