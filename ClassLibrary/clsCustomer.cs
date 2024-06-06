using System;
using System.Data;
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
            if (DB.Count == 1)
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
                //create a string variable to store the error
                String Error = "";
                DateTime DateTemp;
                DateTime DateComp = DateTime.Now.Date.AddYears(-18);
                DateTime DateComp2 = DateTime.Now.Date.AddYears(-110);

            try
            {
                DateTemp = Convert.ToDateTime(customerDob);
                if (DateTemp > DateComp)
                {
                    Error = Error + "You cannot be younger than 18 : ";
                }
                if (DateTemp < DateComp2)
                {
                    Error = Error + "You cannot be older than 150 : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
               
                if (customerName.Length == 0)
                {
                    //record the error
                    Error = Error + "The  name may not be blank : ";
                }
                if (customerName.Length > 50)
                {
                    //record the error
                    Error = Error + "The  name must be less than 6 characters : ";
                }
               
                if (customerEmail.Length == 0)
                {
                    //record the error
                    Error = Error + "The email may not be blank : ";
                }

               if (customerEmail.Length > 50)
                {
                    //record the error
                    Error = Error + "The email must be less than 9 characters : ";
                }
                if (customerPhoneNumber.Length == 0)
                {
                    //record the error
                    Error = Error + "The phone number may not be blank : ";
                }
               
                if (customerPhoneNumber.Length > 50)
                {
                    //record the error
                    Error = Error + "The phone number must be less than 50 characters : ";
                }
                if (customerAddress.Length == 0)
                {
                    //record the error
                    Error = Error + "The address may not be blank : ";
                }
                if (customerAddress.Length > 50)
                {
                    //record the error
                    Error = Error + "The address must be less than 50 characters : ";
                }
                //return any error messages
                return Error;
            }
        public DataTable StatisticsGroupByEmail()
        {
            // Create an instance of the clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure for grouping by email
            DB.Execute("sproc_tblCustomer_Count_GroupByEmail");
            // Return the resulting DataTable
            return DB.DataTable;
        }

        public DataTable StatisticsGroupDob()
        {
            // Create an instance of the clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure for grouping by date of birth
            DB.Execute("sproc_tblCustomer_Count_GroupDob");
            // Return the resulting DataTable
            return DB.DataTable;
        }



    }
}
