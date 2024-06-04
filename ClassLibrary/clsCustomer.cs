using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private int mCustomerId;
        private string mCustomerName;
        private string mCustomerEmail;
        private string mCustomerAddress;
        private string mCustomerPhoneNumber;
        private DateTime mCustomerDob;

        public int CustomerId
        {
            get { return mCustomerId; }
            set { mCustomerId = value; }
        }

        public string CustomerName
        {
            get { return mCustomerName; }
            set { mCustomerName = value; }
        }

        public string CustomerEmail
        {
            get { return mCustomerEmail; }
            set { mCustomerEmail = value; }
        }

        public DateTime CustomerDob
        {
            get { return mCustomerDob; }
            set { mCustomerDob = value; }
        }

        public string CustomerAddress
        {
            get { return mCustomerAddress; }
            set { mCustomerAddress = value; }
        }

        public string CustomerPhoneNumber
        {
            get { return mCustomerPhoneNumber; }
            set { mCustomerPhoneNumber = value; }
        }

        public bool Find(int CustomerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            if(DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerDob = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDob"]);
                mCustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNumber"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public string Valid(string customerName, string customerEmail, string customerDob, string customerPhoneNumber, string customerAddress)
        {
            return "";
        }
    }
}
