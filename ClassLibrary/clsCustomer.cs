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

        public bool Find(int customerId)
        {
            mCustomerId = 7;
            mCustomerName = "Test Name";
            mCustomerEmail = "Test Email";
            mCustomerDob = DateTime.ParseExact("26/09/2002", "dd/MM/yyyy", null);
            mCustomerAddress = "Test Address";
            mCustomerPhoneNumber = "Test Number";

            return true;
        }

        public string Valid(string customerName, string customerEmail, string customerDob, string customerPhoneNumber, string customerAddress)
        {
            return "";
        }
    }
}
