using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        private clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrder ThisOrder
        {
            get { return mThisOrder; }
            set { mThisOrder = value; }
        }

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@ProductId", mThisOrder.ProductId);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.AddParameter("@Delivered", mThisOrder.Delivered);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@ProductId", mThisOrder.ProductId);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.AddParameter("@Delivered", mThisOrder.Delivered);
            DB.Execute("sproc_tblOrder_Update");
        }
        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FindByOrderId");
            if (DB.Count == 1)
            {
                mThisOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mThisOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mThisOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mThisOrder.ProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mThisOrder.TotalPrice = Convert.ToSingle(DB.DataTable.Rows[0]["TotalPrice"]);
                mThisOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mThisOrder.Delivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                return true;
            }
            return false;
        }

        public void ReportByOrderDate(string OrderDate)
        {
            //filters the records based on a full or partial staff role
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the StaffRole parameter to the database
            DB.AddParameter("@Orderdate", OrderDate);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderDate");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                AnOrder.ProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                AnOrder.TotalPrice = Convert.ToSingle(DB.DataTable.Rows[0]["TotalPrice"]);
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                AnOrder.Delivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
    }
}
