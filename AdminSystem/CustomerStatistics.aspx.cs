using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer clscustomer = new clsCustomer();
        DataTable dT = clscustomer.StatisticsGroupByEmail();
        GridViewStGroupByEmail.DataSource = dT;
        GridViewStGroupByEmail.DataBind();
        GridViewStGroupByEmail.HeaderRow.Cells[0].Text = " Total ";
        dT = clscustomer.StatisticsGroupDob();

        GridViewStGroupByDob.DataSource = dT;
        GridViewStGroupByDob.DataBind();

        GridViewStGroupByDob.HeaderRow.Cells[0].Text = " Text ";
    }

    protected void GridViewStGroupByEmail_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}