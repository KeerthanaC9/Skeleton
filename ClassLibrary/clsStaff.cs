using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public DateTime DateJoined { get; set; }
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffRole { get; set; }
        public int StaffSalary { get; set; }
        public string StaffJobTitle { get; set; }
    }
}