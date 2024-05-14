using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];     
        //display the shoe id for this entry
        Response.Write(AStock.ShoeId);
        //display the shoe name for this entry
        Response.Write(AStock.ShoeName);
        //display the supplier for this entry
        Response.Write(AStock.Supplier);
        //display the shoe size for this entry
        Response.Write(AStock.ShoeSize);
        //display the shoe color for this entry
        Response.Write(AStock.ShoeColor);
        //display the shoe price for this entry
        Response.Write(AStock.ShoePrice);
        //display the date updated for this entry
        Response.Write(AStock.DateUpdated);
        //display the available check box
        Response.Write(AStock.Available);


    }
}