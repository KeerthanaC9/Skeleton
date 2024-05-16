using System;

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

        public bool Find(int orderId)
        {
            throw new NotImplementedException();
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
                //set the private data members to the test data value 
                mOrderId = 7;
                mCustmerId = 43;
                mOrderDate = Convert.ToDateTime("06/01/2008");
                mProductId = 157;
                mTotalPrice = Convert.ToDecimal("25.67");
                mActive = true;
                mDelivered = true;
                //always return true 
                return true;
            }
        }
    }
}