using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ClassLibrary
{
    public class clsOrder
    {
        // Private data members for the properties
        private Int32 mOrderId;
        private Int32 mCustomerId;
        private DateTime mOrderDate;
        private Int32 mProductId;
        private float mTotalPrice;
        private bool mActive;
        private bool mDelivered;

        // Public properties
        public Int32 OrderId
        {
            get { return mOrderId; }
            set { mOrderId = value; }
        }

        public int CustomerId
        {
            get { return mCustomerId; }
            set { mCustomerId = value; }
        }

        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }

        public int ProductId
        {
            get { return mProductId; }
            set { mProductId = value; }
        }

        public float TotalPrice
        {
            get { return mTotalPrice; }
            set { mTotalPrice = value; }
        }

        public bool Active
        {
            get { return mActive; }
            set { mActive = value; }
        }

        public bool Delivered
        {
            get { return mDelivered; }
            set { mDelivered = value; }
        }

        private static readonly List<clsOrder> Orders = new List<clsOrder>
        {
            // Add initial data here if necessary
        };

        public bool Find(int orderId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the order ID to search for
            DB.AddParameter("@OrderId", orderId);
            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mTotalPrice = Convert.ToSingle(DB.DataTable.Rows[0]["TotalPrice"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                // Return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating that there is a problem
                return false;
            }
        }
        /*public bool Find(int orderId)
        {
            // Search for the order with the given orderId
            var AnOrder = Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (AnOrder != null)
            {
                // If found, copy properties to the current instance
                this.OrderId = AnOrder.OrderId;
                this.CustomerId = AnOrder.CustomerId;
                this.OrderDate = AnOrder.OrderDate;
                this.ProductId = AnOrder.ProductId;
                this.TotalPrice = AnOrder.TotalPrice;
                this.Active = AnOrder.Active;
                this.Delivered = AnOrder.Delivered;
                return true;
            }
            return false;

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");

        }*/

        public string Valid(string customerId, string orderDate, string productId, string totalPrice, string active, string delivered)
        {
            throw new NotImplementedException();
        }

        public DataTable StatisticsGroupedByProductId()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_Count_GroupByProductId");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedOrderDate()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_Count_GroupOrderDate");
            return DB.DataTable;
        }
    }
}

public class ClsOrder
{
    // Private data members for the properties
    private Int32 mOrderId;
    private Int32 mCustomerId;
    private DateTime mOrderDate;
    private Int32 mProductId;
    private float mTotalPrice;
    private bool mActive;
    private bool mDelivered;

    // Public properties
    public Int32 OrderId
    {
        get { return mOrderId; }
        set { mOrderId = value; }
    }

    public int CustomerId
    {
        get { return mCustomerId; }
        set { mCustomerId = value; }
    }

    public DateTime OrderDate
    {
        get { return mOrderDate; }
        set { mOrderDate = value; }
    }

    public int ProductId
    {
        get { return mProductId; }
        set { mProductId = value; }
    }

    public float TotalPrice
    {
        get { return mTotalPrice; }
        set { mTotalPrice = value; }
    }

    public bool Active
    {
        get { return mActive; }
        set { mActive = value; }
    }

    public bool Delivered
    {
        get { return mDelivered; }
        set { mDelivered = value; }
    }

    
}
