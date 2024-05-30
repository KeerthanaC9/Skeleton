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
        string staffName = txtStaffName.Text;
        //capture the staff role
        string staffRole = txtStaffRole.Text;
        //capture the staff salary
        string staffSalary = txtStaffSalary.Text;
        //capture the staff job title
        string staffJobTitle = txtStaffJobTitle.Text;
        //capture the date joined
        string dateJoined = txtDateJoined.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        //Error = AStaff.Valid(staffSalary, staffJobTitle, staffName, staffRole, dateJoined);
        Error = AStaff.Valid(staffSalary, staffJobTitle, staffName, staffRole, dateJoined);
        if (Error == "")
        {
            //capture the staff name
            AStaff.StaffName = staffName;
            //capture the staff role
            AStaff.StaffRole = staffRole;
            //capture the staff salary
            AStaff.StaffSalary = Convert.ToInt32(staffSalary);
            //capture the staff job title
            AStaff.StaffJobTitle = staffJobTitle;
            //capture the date joined
            AStaff.DateJoined = Convert.ToDateTime(dateJoined);
            //store the staff in the session object
            Session["AStaff"] = AStaff;
            //navigate to the view page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e) 
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffId);
        //lblError.Text = Found.ToString();
        //if found
        if (Found == true) 
        {
            //display the values of the properties in the form
            txtDateJoined.Text = AStaff.DateJoined.ToString();
            txtStaffJobTitle.Text = AStaff.StaffJobTitle.ToString();
            txtStaffName.Text = AStaff.StaffName.ToString();
            txtStaffRole.Text = AStaff.StaffRole.ToString();
            txtStaffSalary.Text = AStaff.StaffSalary.ToString();

        }
    }
}