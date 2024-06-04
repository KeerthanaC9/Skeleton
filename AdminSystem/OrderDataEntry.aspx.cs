using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrder
       // clsOrder AnOrder = new clsOrder();
        // Capture the customer id
        //AnOrder.CustomerId = int.Parse(txtCustomerId.Text);
        // Capture the order id
        //AnOrder.OrderId = int.Parse(txtOrderId.Text);
        // Capture the current date as the order date
     //   AnOrder.OrderDate = DateTime.Parse(txtOrderDate.Text);
        // Capture the product id
     //  AnOrder.ProductId = int.Parse(txtProductId.Text);
        //capture the total price
       // AnOrder.TotalPrice = float.Parse(txtTotalPrice.Text);
        // Capture Active checkbox
       // AnOrder.Active = chkActive.Checked;
        //capture Order Deliovered checkbox
        //AnOrder.OrderDelivered = chkDelivered.Checked;
        // Store the Order in the session object
        //Session["AnOrder"] = AnOrder;
        // Navigate to the view page
        //Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class 
        //clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record 
//        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 
        //    txtOrderId.Text = AnOrder.OrderId.ToString();
          //  txtCustomerId.Text = AnOrder.CustomerId.ToString();
            //txtOrderDate.Text = AnOrder.OrderDate.ToString();
        //    txtProductId.Text = AnOrder.ProductId.ToString();
          //  txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            //chkActive.Checked = AnOrder.Active;
       //     chkDelivered.Checked = AnOrder.OrderDelivered;
        }
    }
}




