using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the date added property
        private bool mActive;
        //OrderDate Added public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        //private data member for the address id property
        private float mTotalPrice;
        //OrderId public property
        public float TotalPrice
        {
            get
            {
                //this line of code sends data out of the property 
                return mTotalPrice;

            }
            set
            {
                //this line of code allows data into the property 
                mTotalPrice = value;
            }
        }

        //private data member for the address id property
        private Int32 mCustomerId;
        //OrderId public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property 
                return mCustomerId;

            }
            set
            {
                //this line of code allows data into the property 
                mOrderId = value;
            }
        }

        //private data member for the address id property
        private Int32 mProductId;
        //OrderId public property
        public Int32 ProductId
        {
            get
            {
                //this line of code sends data out of the property 
                return mProductId;

            }
            set
            {
                //this line of code allows data into the property 
                mProductId = value;
            }
        }

        //private data member for the date added property
        private DateTime mOrderDate;
        //OrderDate Added public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }



        //private data member for the address id property
        private Int32 mOrderId;
        //OrderId public property
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property 
                return mOrderId;

            }
            set
            {
                //this line of code allows data into the property 
                mOrderId = value;
            }
        }

        //private data member for the customer id property
        private bool mOrderDelivered;
        //addressId public property
        public bool OrderDelivered
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDelivered;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDelivered = value;
            }
        }
        public bool Find(int orderId)
        {
            //create aninstance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderId", orderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mTotalPrice = Convert.ToSingle(DB.DataTable.Rows[0]["TotalPrice"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mOrderDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                //return that everything worked OK
                return true;

            }
            else
            {
                return false;
            }
        }

        public string Valid(string customerId, string orderDate, string productId, string totalPrice, string totalPrice1)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values 
            DateTime DateTemp;
            //if the CustomerId is blank
            if (customerId.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Id may not be blank : ";
            }
            //if the customer id is greate than 10 characters
            if (customerId.Length > 10)
            {
                //record the error
                Error = Error + "The Customer Id must be less than 10 characters : ";
            }
            //if the productid is blank
            if (productId.Length == 0)
            {
                //record the error
                Error = Error + "The Product Id may not be blank : ";
            }
            //if the product id is greater than 10 characters
            if (productId.Length > 10)
            {
                //record the error
                Error = Error + "The Product Id Must be less than 10 characters : ";
            }

            //if the Total Price is blank
            if (totalPrice.Length == 0)
            {
                //record the error
                Error = Error + "The Total Price must be completed : ";
            }

            //if the Total Price is greater than 4 digits 
            if (totalPrice.Length > 4)
            {
                Error = Error + "The Total Price must no exceed 4 digits : ";
            }

            try
            {
                //copy the OrderDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (OrderDate < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                //check to see if the date is greater than todays date
                if (OrderDate > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future ; ";
                }

                //return any error messages 
                return Error;
            }
            catch
            {
                //record the error if the date is not a valid date
                Error = Error + "The date was not a valid date : ";
            }

            //return any error messages
            return Error;
        }

        public string Valid(object orderId, object customerId, object orderDate, object productId, object totalPrice)
        {
            throw new NotImplementedException();
        }

        public string Valid(object orderId, int customerId, DateTime orderDate, int productId, float totalPrice)
        {
            throw new NotImplementedException();
        }

        public string Valid(string customerId, string orderDate, string productId, string totalPrice)
        {
            throw new NotImplementedException();
        }
    }
}