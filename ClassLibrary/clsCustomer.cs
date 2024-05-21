using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private int mCustomerId;
        public int CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            { 
                mCustomerId = value;
            }
        }
        public bool Active { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public DateTime customerDob { get; set; }
        public string customerAddress { get; set; }
        public string customerPhoneNumber { get; set; }

        public bool Find(int CustomerId)
        {
            mCustomerId = 7;
            return true;
        }

       

        public static implicit operator bool(clsCustomer v)
        {
            throw new NotImplementedException();
        }
     

        }
        }
