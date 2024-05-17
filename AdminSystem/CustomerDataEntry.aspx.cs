﻿using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer  AnCustomer = new clsCustomer();
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        Response.Write(AnCustomer.customerName);

    }

    protected void Unnamed2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the name
        AnCustomer.customerName = txtCustomerName.Text;
        //store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}