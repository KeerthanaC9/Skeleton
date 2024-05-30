using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public float TotalPrice { get; set; }
        public bool OrderDelivered { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        private static readonly List<clsOrder> Orders = new List<clsOrder>
    {
        
    };

        public bool Find(int orderId)
        {
            throw new NotImplementedException();
        }

        // Search for the order with the given orderId
        //var AnOrder = Orders.FirstOrDefault(o => o.OrderId == orderId);
        //if (AnOrder != null)
        //{
        // If found, copy properties to the current instance
        //  this.OrderId = AnOrder.OrderId;
        // this.CustomerId = AnOrder.CustomerId;
        //this.OrderDate = AnOrder.OrderDate;
        //this.ProductId = AnOrder.ProductId;
        //this.TotalPrice = AnOrder.TotalPrice;
        //this.Active = AnOrder.Active;
        //this.OrderDelivered = AnOrder.OrderDelivered;
        //return true;
        //}
        //return false;
    }
    }

    public class ClsOrder
        {
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
            public bool Find(Action orderIdOK)
            {
                //always return true
                return true;
            }

            //private data member for the customer id property
            private Int32 mCustomerId;
            //addressId public property
            public int CustomerId
            {
                get
                {
                    //this line of code sends data out of the property
                    return mCustomerId;
                }
                set
                {
                    //this line of code allows data into the property
                    mCustomerId = value;
                }
            }

            //private data member for the customer id property
            private Int32 mOrderDate;
            //addressId public property
            public int OrderDate
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

            //private data member for the customer id property
            private Int32 mProductId;
            //addressId public property
            public int ProductId
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

            //private data member for the customer id property
            private Int32 mTotaLPrice;
            //addressId public property
            public int TotalPrice
            {
                get
                {
                    //this line of code sends data out of the property
                    return mTotaLPrice;
                }
                set
                {
                    //this line of code allows data into the property
                    TotalPrice = value;
                }
            }

            //private data member for the customer id property
            private Int32 mActive;
            //addressId public property
            public int Ative
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

            //private data member for the customer id property
            private Int32 mDelivered;
            //addressId public property
            public int Delivered
            {
                get
                {
                    //this line of code sends data out of the property
                    return mDelivered;
                }
                set
                {
                    //this line of code allows data into the property
                    mDelivered = value;
                }
            }

            public bool Find(int orderId, int mCustmerId, DateTime mOrderDate, int mProductId, decimal mTotalPrice, bool mActive, bool mDelivered)
            {
                //create an instance of the data connection
                clsDataConnection DB = new clsDataConnection();
                //add the parameter for the address id to search for 
                DB.AddParameter("@OrderId", OrderId);
                //execute the stored procedure
                DB.Execute("sproc_tblOrder_FilterByOrderId");
                //if one recorder is found (there should be either one or zero)
                if (DB.Count == 1)
                {
                    //copy the data from the database to the private data members
                    mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                    mCustmerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                    mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                    mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                    mTotalPrice = Convert.ToInt32(DB.DataTable.Rows[0]["TotalPrice"]);
                    mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                    mDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                    //return that everythingn worked OK
                    return true;
                }
                //if no record was found
                else
                {
                    //return false indicating that there is a problem
                    return false;

                }
            }
        }
    //}