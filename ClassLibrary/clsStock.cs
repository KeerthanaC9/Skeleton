using System;
using System.Data;

namespace ClassLibrary
{

    public class clsStock
    {
        //private data member for the address id property
        private Int32 mShoeId;

        //shoId public property

        public Int32 ShoeId
        {
            get
            {
                //this line of code sends data out of the property
                return mShoeId;
            }
            set
            {
                //this line of code allows data into the property
                mShoeId = value;
            }

        }

        private string mShoeName;

        public string ShoeName
        {
            get
            {
                return mShoeName;
            }
            set
            {
                mShoeName = value;
            }
        }

        private string mSupplier;

        public string Supplier
        {
            get
            {
                return mSupplier;
            }
            set
            {
                mSupplier = value;
            }
        }

        private Int32 mShoeSize;

        public int ShoeSize
        {
            get
            {
                return mShoeSize;
            }
            set
            {
                mShoeSize = value;
            }
        }

        private string mShoeColor;

        public string ShoeColor
        {
            get
            {
                return mShoeColor;
            }
            set
            {
                mShoeColor = value;
            }
        }

        private decimal mShoePrice;

        public decimal ShoePrice
        {
            get
            {
                return mShoePrice;
            }
            set
            {
                mShoePrice = value;
            }
        }

        private DateTime mDateUpdated;

        public DateTime DateUpdated
        {
            get
            {
                return mDateUpdated;
            }
            set
            {
                mDateUpdated = value;
            }
        }

        private Boolean mAvailable;

        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }



        public bool Find(int ShoeId)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the shoe id to search for
            DB.AddParameter("ShoeId", ShoeId);
            //execute the stored procedure
            DB.Execute("sproc_tblShoe_FilterByShoeId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mShoeId = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeId"]);
                mShoeName = Convert.ToString(DB.DataTable.Rows[0]["ShoeName"]);
                mSupplier = Convert.ToString(DB.DataTable.Rows[0]["Supplier"]);
                mShoeSize = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeSize"]);
                mShoeColor = Convert.ToString(DB.DataTable.Rows[0]["ShoeColor"]);
                mShoePrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ShoePrice"]);
                mDateUpdated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateUpdated"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                //return that everything worked ok
                return true;

            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }

       

        /****** Statistics Grouped By Shoe Name Method ******/
        public DataTable StatisticsGroupedByShoeName()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblShoe_Count_GroupByShoeName");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }

      

        /****** Statistics Grouped By Shoe Name Method ******/
        public DataTable StatisticsGroupedByDateUpdated()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblShoe_Count_GroupByDateUpdated");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }


        public string Valid(string shoeName, string supplier, string shoeColor, string dateUpdated)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the ShoeName is blank
            if (shoeName.Length == 0)
            {
                //record the error
                Error = Error + "The shoe name may not be blank : ";

            }
            //if the shoe name is greater than 50 characters
            if (shoeName.Length > 50)
            {
                //record the error
                Error = Error + "The shoe name must be less than 50 characters : ";

            }

            //if the supplier is blank
            if (supplier.Length == 0)
            {
                //record the error
                Error = Error + "The supplier may not be blank : ";
            }

            //if the supplier name is greater than 50 characters
            if (supplier.Length > 50)
            {
                //record the error
                Error = Error + "The supplier name must be less than 50 characters : ";
            }
            //if the shoe color is blank 
            if (shoeColor.Length == 0)
            {
                //record the error
                Error = Error + "The shoe color may not be blank : ";
            }
            //if the shoe color is greater than 50 characters
            if (shoeColor.Length > 50)
            {
                //record the error
                Error = Error + "The shoe color must be less than 50 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateUpdated value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateUpdated);

                if (DateTemp < DateComp) //compare dateUpdated with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";

                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
                return Error;
            }

            DateTemp = Convert.ToDateTime(dateUpdated);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }

            //return any error messages
            return Error;
        }

    }
    }






