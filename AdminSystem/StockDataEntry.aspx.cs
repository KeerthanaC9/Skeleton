using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ShoeId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stocks to be processed
        ShoeId = Convert.ToInt32(Session["ShoeId"]);
        if (IsPostBack == false)
        {
            //if this is not the new record
            if (ShoeId != -1)
            {
                //display the current data for the record
                DisplayStock();
                
            }
        }


        

    }

     void DisplayStock()
    {
        //create an instance of the stock
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        if (Stock.ThisStock.Find(ShoeId))
        {
            //display the data for the record
            txtShoeId.Text = Stock.ThisStock.ShoeId.ToString();
            txtShoeName.Text = Stock.ThisStock.ShoeName.ToString();
            txtSupplier.Text = Stock.ThisStock.Supplier.ToString();
            txtShoeSize.Text = Stock.ThisStock.ShoeSize.ToString();
            txtShoeColor.Text = Stock.ThisStock.ShoeColor.ToString();
            txtShoePrice.Text = Stock.ThisStock.ShoePrice.ToString();
            txtDateUpdated.Text = Stock.ThisStock.DateUpdated.ToString();
            chkAvailable.Checked = Stock.ThisStock.Available;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();

        //capture and convert the shoe id
        int ShoeId = -1;
        if (!string.IsNullOrEmpty(txtShoeId.Text))
        {
            ShoeId = Convert.ToInt32(txtShoeId.Text);
        }
        //capture the shoe id
        //string ShoeId = txtShoeId.Text;
        //capture the shoe Name
        string ShoeName = txtShoeName.Text;
        //capture the supplier
        string Supplier = txtSupplier.Text;
        //capture the shoe size
        string ShoeSize = txtShoeSize.Text;
        //capture the shoe color
        string ShoeColor = txtShoeColor.Text;
        //capture the shoe price
        string ShoePrice = txtShoePrice.Text;
        //capture the date updated
        string DateUpdated = txtDateUpdated.Text;
        //capture available check box
        string Available = chkAvailable.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(ShoeName, Supplier, ShoeColor, DateUpdated);
        if (Error == "")
        {
            //capture the shoe Id
            AStock.ShoeId = ShoeId;
            //capture the ShoeName
            AStock.ShoeName = ShoeName;
            //capture the Supplier
            AStock.Supplier = Supplier;
            //capture the town
            AStock.ShoeColor = ShoeColor;
            //capture the date updated
            AStock.DateUpdated = Convert.ToDateTime(DateUpdated);
            //capture the shoe size
            AStock.ShoeSize = Convert.ToInt32(ShoeSize);
            //capture the shoe price
            AStock.ShoePrice = Convert.ToDecimal(ShoePrice);
            //capture Available
            AStock.Available = chkAvailable.Checked;
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            //if this is a new record i.e. ShoeId = -1 then add the data
            if (ShoeId == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(ShoeId);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
            //set the ThisStock property 
            //StockList.ThisStock = AStock;
            //add the new record
            //StockList.Add();
            //redirect back to the lsit page 
            Response.Redirect("StockList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key
        Int32 ShoeId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by a user
        ShoeId = Convert.ToInt32(txtShoeId.Text);
        //Find the record
        Found = AStock.Find(ShoeId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtShoeId.Text = AStock.ShoeId.ToString();
            txtShoeName.Text = AStock.ShoeName;
            txtSupplier.Text = AStock.Supplier;
            txtShoeSize.Text = AStock.ShoeSize.ToString();
            txtShoeColor.Text = AStock.ShoeColor;
            txtShoePrice.Text = AStock.ShoePrice.ToString();
            txtDateUpdated.Text = AStock.DateUpdated.ToString();
            chkAvailable.Checked = AStock.Available;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect the user back to the list page
        Response.Redirect("StockList.aspx");
    }

    protected void btnReturnToMM_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}