using System;
using System.Data;

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
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //create instances of DateTime to compare with DateTemp in the if statement
            DateTime DateLaunched = Convert.ToDateTime("26/04/2024");
            DateTime TodaysDate = DateTime.Now.Date;

            try
            {
                //copy the dateJoined value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateJoined);

                if (DateTemp < DateLaunched) //compare dateJoined with Date company launched 26/04/2024
                {
                    //record the error
                    Error = Error + "The date cannot be before 26/04/2024 : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > TodaysDate)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //rrecord the error
                Error = Error + "The date was not a valid date : ";
            }
            //if the staffName is blank
            if (staffName.Length == 0)
            {
                //record the error
                Error = Error + "The staff name may not be blank : ";
            }
            //if the staffName is greater than 50 characters
            if (staffName.Length > 50)
            {
                //record the error
                Error = Error + "The staff name must be less than 50 characters : ";
            }

            //if the staffRole is blank
            if (staffRole.Length == 0)
            {
                //record the error
                Error = Error + "The staff role may not be blank : ";
            }
            //if the staffRole is greater than 50 characters
            if (staffRole.Length > 50)
            {
                //record the error
                Error = Error + "The staff role must be less than 50 characters : ";
            }

            //if the staffJobTitle is blank
            if (staffJobTitle.Length == 0)
            {
                //record the error
                Error = Error + "The staff job title may not be blank : ";
            }
            //if the staffJobTitle is greater than 50 characters
            if (staffJobTitle.Length > 50)
            {
                //record the error
                Error = Error + "The staff job title must be less than 50 characters : ";
            }
            try
            {
                //copy the staffSalary value to the intStaffSalary variable
                Int32 intStaffSalary = Convert.ToInt32(staffSalary);
                if (intStaffSalary < 0) //check to see if the staff salary is negative
                {
                    //record the error
                    Error = Error + "The salary must not be negative : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The salary is not a valid integer : ";
            }
            //if the staffSalary is blank
            if (staffSalary.Length == 0)
            {
                //record the error
                Error = Error + "The salary may not be blank : ";
            }
            return Error;
        }

        /****** Statistics Grouped by Staff Salary Method ******/
        public DataTable StatisticsGroupedByStaffSalary()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupByStaffSalary");
            //There should be either zero, one or more records
            return DB.DataTable;
        }

        /****** Statistics Grouped By Date Joined Method ******/
        public DataTable StatisticsGroupedDateJoined()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupByDateJoined");
            //There should be either zero, one or more records
            return DB.DataTable;
        }
    }
}