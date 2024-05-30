using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        //private data member for the date joined property
        private DateTime mDateJoined;
        public DateTime DateJoined 
        {
            get
            {
                //this line of code sends data out of the property
                return mDateJoined;
            }
            set
            {
                //this line of code allows data into the property
                mDateJoined = value;
            }
        }

        //private data member for the staff id property
        private Int32 mStaffId;
        public int StaffID 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        //private data member for the staff name property
        private string mStaffName;
        public string StaffName 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value;
            }
        }

        //private data member for the staff role property
        private string mStaffRole;
        public string StaffRole 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffRole;
            }
            set
            {
                //this line of code allows data into the property
                mStaffRole = value;
            }
        }

        //private data member for the staff salary property
        private Int32 mStaffSalary;
        public int StaffSalary 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffSalary;
            }
            set
            {
                //this line of code allows data into the property
                mStaffSalary = value;
            }
        }

        //private data member for the staff job title property
        private string mStaffJobTitle;
        public string StaffJobTitle 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffJobTitle;
            }
            set
            {
                //this line of code allows data into the property
                mStaffJobTitle = value;
            }
        }

        public bool Find(int staffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@StaffId", staffId);
            //execute the storred procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if onbe record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private date members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffJobTitle = Convert.ToString(DB.DataTable.Rows[0]["StaffJobTitle"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                mStaffSalary = Convert.ToInt32(DB.DataTable.Rows[0]["StaffSalary"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string staffSalary, string staffJobTitle, string staffName, string staffRole, string dateJoined)
        {
            return "";
        }
    }
}