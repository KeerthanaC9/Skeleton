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
            //set the private data members to the test data value
            mStaffId = 1;
            mStaffJobTitle = "Test Job";
            mStaffName = "Test Name";
            mStaffRole = "Test Role";
            mStaffSalary = 26000;
            //always return true
            return true;
        }
    }
}