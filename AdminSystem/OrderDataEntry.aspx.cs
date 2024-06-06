using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    int OrderId;
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string CustomerId = txtCustomerId.Text;
        string OrderDate = txtOrderDate.Text;
        string ProductId = txtProductId.Text;
        string TotalPrice = txtTotalPrice.Text;
        string Active = chkActive.Text;
        string Delivered = chkDelivered.Text;
        string Error = "";
        Error = AnOrder.Valid(CustomerId, OrderDate, ProductId, TotalPrice, Active, Delivered);
        if (Error == "")
        {
            //capture the order id 
            AnOrder.OrderId = OrderId;
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
            AnOrder.Delivered = chkDelivered.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class 
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record 
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtOrderId.Text = AnOrder.OrderId.ToString();
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtProductId.Text = AnOrder.ProductId.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            chkActive.Checked = AnOrder.Active;
            chkDelivered.Checked = AnOrder.Delivered;
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ThisOrder.Find(OrderId);
        txtOrderId.Text = Order.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = Order.ThisOrder.CustomerId.ToString();
        txtOrderDate.Text = Order.ThisOrder.OrderDate.ToString();
        txtProductId.Text = Order.ThisOrder.ProductId.ToString();
        txtTotalPrice.Text = Order.ThisOrder.TotalPrice.ToString();
        chkActive.Checked = Order.ThisOrder.Active;
        chkDelivered.Checked = Order.ThisOrder.Delivered;
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}




