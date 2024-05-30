using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //constructor for the class
        public clsStaffCollection() 
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_selectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while thre are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //rerad in the fields for the current record
                AStaff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffSalary"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffJobTitle = Convert.ToString(DB.DataTable.Rows[Index]["StaffJobTitle"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
        
        //while therre are records to process
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList 
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public clsStaff ThisStaff { get; set; }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later;

            }
        }


    }
}