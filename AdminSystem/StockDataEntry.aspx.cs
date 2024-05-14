using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the shoe id
        AStock.ShoeId = Convert.ToInt32(txtShoeId.Text);
        //capture the shoe name
        AStock.ShoeName = txtShoeName.Text;
        //capture the supplier
        AStock.Supplier = txtSupplier.Text;
        //capture the shoe size 
        AStock.ShoeSize = Convert.ToInt32(txtShoeSize.Text);
        //capture the shoe color
        AStock.ShoeColor = txtShoeColor.Text;
        //captrue the shoe price
        AStock.ShoePrice = Convert.ToDecimal(txtShoePrice.Text);
        //capture the date updated
        AStock.DateUpdated = Convert.ToDateTime(DateTime.Now);
        //capture available check box
        AStock.Available = chkAvailable.Checked;
        //store the address in the session object
        Session["AStock"] = AStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");

      

    }

   
}