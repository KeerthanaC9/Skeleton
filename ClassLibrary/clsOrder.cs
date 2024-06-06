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
            // Add initial data here if necessary
        };

        public bool Find(int orderId)
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
                this.OrderDelivered = AnOrder.OrderDelivered;
                return true;
            }
            return false;
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
    private decimal mTotalPrice;
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

    public decimal TotalPrice
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
            mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
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
}
