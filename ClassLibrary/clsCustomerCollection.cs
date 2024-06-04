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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll"); // Corrected stored procedure name
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerDob = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDob"]);
                AnCustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNumber"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }
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
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerDob", mThisCustomer.CustomerDob);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);

            return DB.Execute("sproc_tblCustomer_Insert");
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
