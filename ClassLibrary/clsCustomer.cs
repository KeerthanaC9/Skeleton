using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
     
        public int CustomerId { get; set; }
        public bool Active { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public DateTime customerDob { get; set; }
        public string customerAddress { get; set; }
        public string customerPhoneNumber { get; set; }
    }
}