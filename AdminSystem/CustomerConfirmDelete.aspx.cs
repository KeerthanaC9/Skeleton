﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassLibrary;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerId);
        CustomerBook.Delete();
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}