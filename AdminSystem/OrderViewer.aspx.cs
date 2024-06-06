using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the data from the session object
        clsOrder AnOrder = (clsOrder)Session["AnOrder"];

        // Display whatever has been inputted by the user for this entry 
        if (AnOrder != null)
        {
            Response.Write("Customer ID: " + AnOrder.CustomerId + "<br />");
            Response.Write("Order ID: " + AnOrder.OrderId + "<br />");
            Response.Write("Order Date: " + AnOrder.OrderDate.ToString("MM/dd/yyyy") + "<br />");
            Response.Write("Product ID: " + AnOrder.ProductId + "<br />");
            Response.Write("Total Price: £" + AnOrder.TotalPrice + "<br />");
            Response.Write("Active: " + (AnOrder.Active ? "Yes" : "No") + "<br />");
            Response.Write("Order Delivered: " + (AnOrder.Delivered ? "Yes" : "No") + "<br />");
        }
    }
}
