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
        clsOrder AnOrder = new clsOrder();
        // Capture the customer id
        AnOrder.CustomerId = int.Parse(txtCustomerId.Text);
        // Capture the order id
        AnOrder.OrderId = int.Parse(txtOrderId.Text);
        // Capture the current date as the order date
        AnOrder.OrderDate = DateTime.Parse(txtOrderDate.Text);
        // Capture the product id
        AnOrder.ProductId = int.Parse(txtProductId.Text);
        //capture the total price
        AnOrder.TotalPrice = float.Parse(txtTotalPrice.Text);
        // Capture Active checkbox
        AnOrder.Active = chkActive.Checked;
        //capture Order Deliovered checkbox
        AnOrder.OrderDelivered = chkDelivered.Checked;
        // Store the Order in the session object
        Session["AnOrder"] = AnOrder;
        // Navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }
}




