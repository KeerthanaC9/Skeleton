using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //crreare a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["Ancustomer"];
        //display the Name  for this entry
        Response.Write(AnCustomer.CustomerName);
        Response.Write(AnCustomer.CustomerEmail);
        Response.Write(AnCustomer.CustomerPhoneNumber);
        Response.Write(AnCustomer.CustomerAddress);
        Response.Write(AnCustomer.CustomerDob);

    }

}