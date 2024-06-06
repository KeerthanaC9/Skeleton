using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsStockCollection
    {

    //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for ThisStock
        clsStock mThisStock = new clsStock();

        //constructor for the class 
        public clsStockCollection()
        {

            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblShoe_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
                 
        }


        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@ShoeName", mThisStock.ShoeName);
            DB.AddParameter("@Supplier", mThisStock.Supplier);
            DB.AddParameter("@ShoeSize", mThisStock.ShoeSize);
            DB.AddParameter("@ShoeColor", mThisStock.ShoeColor);
            DB.AddParameter("@ShoePrice", mThisStock.ShoePrice);
            DB.AddParameter("@DateUpdated", mThisStock.DateUpdated);
            DB.AddParameter("@Available", mThisStock.Available);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblShoe_Insert");
        }

   
        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ShoeId", mThisStock.ShoeId);
            //execute the stored procedure
            DB.Execute("sproc_tblShoe_Delete");
        }

        public void ReportBySupplier(string Supplier)
        {
            //filters the records based on a full or partial supplier name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the supplier parameter to the database
            DB.AddParameter("@Supplier", Supplier);
            //execute the stored procedure
            DB.Execute("sproc_tblShoe_FilterBySupplier");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank supplier object
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AStock.ShoeId = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoeId"]);
                AStock.ShoeName = Convert.ToString(DB.DataTable.Rows[Index]["ShoeName"]);
                AStock.DateUpdated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateUpdated"]);
                AStock.Supplier = Convert.ToString(DB.DataTable.Rows[Index]["Supplier"]);
                AStock.ShoeSize = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoeSize"]);
                AStock.ShoeColor = Convert.ToString(DB.DataTable.Rows[Index]["ShoeColor"]);
                AStock.ShoePrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ShoePrice"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point to the next record
                Index++;
            }
        }

        public void Update()
        {
            //update an existing record based on the values of ThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("ShoeId", mThisStock.ShoeId);
            DB.AddParameter("ShoeName", mThisStock.ShoeName);
            DB.AddParameter("Supplier", mThisStock.Supplier);
            DB.AddParameter("ShoeSize", mThisStock.ShoeSize);
            DB.AddParameter("ShoeColor", mThisStock.ShoeColor);
            DB.AddParameter("ShoePrice", mThisStock.ShoePrice);
            DB.AddParameter("DateUpdated", mThisStock.DateUpdated);
            DB.AddParameter("Available", mThisStock.Available);
            //execute the stored procedure
            DB.Execute("sproc_tblShoe_Update");

        }

       
        }

       

    }
    
    

   







