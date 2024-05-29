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
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff name
        AStaff.StaffName = txtStaffName.Text;
        //capture the staff role
        AStaff.StaffRole = txtStaffRole.Text;
        //capture the staff salary
        AStaff.StaffSalary = Convert.ToInt32(txtStaffSalary.Text);
        //capture the staff job title
        AStaff.StaffJobTitle = txtStaffJobTitle.Text;
        //capture the date joined
        AStaff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
        //store the staff in the session object
        Session["AStaff"] = AStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}