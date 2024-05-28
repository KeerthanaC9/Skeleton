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
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff name for this entry
        Response.Write(AStaff.StaffName);
        Response.Write(AStaff.StaffRole);
        Response.Write(AStaff.StaffSalary);
        Response.Write(AStaff.StaffJobTitle);
        Response.Write(AStaff.DateJoined);
    }
}