using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      

    }

    protected void Unnamed2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the name
        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerDob = txtCustomerDob.Text;
        string CustomerPhoneNumber = txtCustomerPhoneNumber.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        
        string Error = "";
        Error = AnCustomer.Valid(CustomerName,CustomerEmail,CustomerDob, CustomerPhoneNumber, CustomerAddress);
        if (Error == "")
        {
            AnCustomer.CustomerName = CustomerName;
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.CustomerDob = Convert.ToDateTime(CustomerDob);
            AnCustomer.CustomerPhoneNumber = CustomerPhoneNumber;
            AnCustomer.CustomerAddress = CustomerAddress;


            //store the address in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
  

    
}