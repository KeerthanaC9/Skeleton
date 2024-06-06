using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        private clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

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

        public clsCustomer ThisCustomer
        {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerDob", mThisCustomer.CustomerDob);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerDob", mThisCustomer.CustomerDob);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByCustomerEmail(string CustomerEmail)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerEmail", CustomerEmail);
            DB.Execute("sproc_tblCustomer_FilterByCustomerEmail");
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();

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

        public bool Find(int CustomerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FindByCustomerId");
            if (DB.Count == 1)
            {
                mThisCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mThisCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mThisCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mThisCustomer.CustomerDob = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDob"]);
                mThisCustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNumber"]);
                mThisCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                return true;
            }
            return false;
        }
    }
}
