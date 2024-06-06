using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff clsstaff = new clsStaff();

        //retrieve data from the database
        DataTable dT = clsstaff.StatisticsGroupedByStaffSalary();

        //upload dT into GridView
        GridViewStGroupBySalary.DataSource = dT;
        GridViewStGroupBySalary.DataBind();

        //change the header of the first column
        GridViewStGroupBySalary.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clsstaff.StatisticsGroupedDateJoined();

        //upload dT into GridView
        GridViewStGroupByDateJoined.DataSource = dT;
        GridViewStGroupByDateJoined.DataBind();

        //change the header of the first column
        GridViewStGroupByDateJoined.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void btnPreviousPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}