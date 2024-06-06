using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock clsstock = new clsStock();

        //retrieve data from the database
        DataTable dT = clsstock.StatisticsGroupedByShoeName();

        //upload dT into GridView
        GridViewStGroupByShoeName.DataSource = dT;
        GridViewStGroupByShoeName.DataBind();

        //change the header of the first column
        GridViewStGroupByShoeName.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clsstock.StatisticsGroupedByDateUpdated();

        //upload dT into GridView
        GridViewStGroupByDateUpdated.DataSource = dT;
        GridViewStGroupByDateUpdated.DataBind();

        //change the header of the first column
        GridViewStGroupByDateUpdated.HeaderRow.Cells[0].Text = " Total ";


    }



    protected void GridViewStGroupByDateUpdated_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridViewStGroupByShoeName_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnBackToPreviousPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}